using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Movie_Booking_System.Util
{
    public class Controller
    {
        private static DBManager dbMan = new DBManager();

        public static void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public static DataTable showallMovies()
        {
            string query = $"SELECT * FROM Movies";
            return dbMan.ExecuteReader(query);
        }

        public static DataTable Getallfooditems()
        {
            string query = $"SELECT * FROM FoodItems";
            return dbMan.ExecuteReader(query);
        }
        public static DataTable Getauthority()
        {
            string query = $"SELECT Authority FROM Accounts";
            return dbMan.ExecuteReader(query);
        }
        public static int DeleteHelpTicket(int TicketID)
        {
            string query = $"DELETE FROM HelpTickets WHERE HelpTicketID ={TicketID};";
            return dbMan.ExecuteNonQuery(query);
        }
        public static int UpdateAuthority(int UserID,string authority)
        {
            string query = $"UPDATE Accounts SET Authority='{authority}' WHERE UserID ={UserID};";
            return dbMan.ExecuteNonQuery(query);
        }
        public static int Updatefooditmqty(int qty, int foodid)
        {
            string query = $"UPDATE FoodItems SET FoodQty={qty} WHERE FoodID ={foodid};";
            return dbMan.ExecuteNonQuery(query);
        }
        public static DataTable GetUserID()
        {
            string query = $"SELECT UserID FROM Accounts";
            return dbMan.ExecuteReader(query);
        }
        public static DataTable GetAllAccounts()
        {
            string query = $"SELECT * FROM Accounts";
            return dbMan.ExecuteReader(query);
        }
        public static int DeleteAccount(int UserID)
        {
            string query = $"DELETE FROM Accounts WHERE UserID ={UserID};";
            return dbMan.ExecuteNonQuery(query);
        }
        public static int DeleteFooditm(int FoodID)
        {
            string query = $"DELETE FROM FoodItems WHERE FoodID ={FoodID};";
            return dbMan.ExecuteNonQuery(query);
        }

        public static int InsertNewOrder(string UserID)  // ahmad
        {
            string query =
                "INSERT INTO Orders (UserID)\n" +
                $"Values ({UserID})";
            return dbMan.ExecuteNonQuery(query);
        }
        public static int AddFoodItm(string foodname,int qty,int price,string desc)
        {
            string query =
                            "INSERT INTO FoodItems (FoodName, FoodQty, Price, FoodDescription) " +
                            $"Values ('{foodname}' , {qty} , {price}, '{desc}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public static int GetNewOrderID(string UserID)  // ahmad
        {
            string query = $@"
            SELECT ISNULL(MAX(OrderID),0)
            FROM Orders
            WHERE UserID = " + UserID.ToString();

            return (int)dbMan.ExecuteScalar(query);
        }

        public static DataTable showallFoods()   // ahmad
        {
            string query = $"SELECT * FROM FoodItems";
            return dbMan.ExecuteReader(query);
        }

        public static DataTable GetFoodPriceandQty(String FoodID)    // ahmad
        {
            string query =
                "SELECT FoodQty, Price\n" +
                "FROM FoodItems\n" +
                "WHERE FoodID = " + FoodID + "\n";

            return dbMan.ExecuteReader(query);
        }

        public static int InsertFoodOrder(string DoodID, string OrderCount, string OrderID)  // ahmad
        {
            string query =
                "INSERT INTO Orders_Details (FoodID, OrderCount, OrderID)\n" +
                $"Values ({DoodID}, {OrderCount}, {OrderID})";
            return dbMan.ExecuteNonQuery(query);
        }


        public static int DeleteOrders(string OrderID)  // ahmad
        {
            string query;
            if (OrderID != "")
            {
                query =
                "Delete Orders_Details\n" +
                $"Where OrderID = {OrderID} ";
                return dbMan.ExecuteNonQuery(query);
            }
            return -1;
        }

        public static DataTable GetOrders()     // ahmad
        {
            string query =
                "SELECT Orders_Details.OrderID, Orders_Details.FoodID, FoodItems.FoodName, Orders_Details.OrderCount, FoodItems.Price, Orders.Fulfilled, Orders.UserID \n" +
                "FROM Orders_Details, FoodItems, Orders\n" +
                "WHERE Orders.OrderID = Orders_Details.OrderID and Orders_Details.FoodID = FoodItems.FoodID\n Order by Orders_Details.OrderID";

            return dbMan.ExecuteReader(query);
        }

        public static int UpdateOrder(int OrderID)   // ahmad
        {
            string query =
                "UPDATE Orders\n" +
                "SET Fulfilled = 1\n" +
                $"WHERE OrderID = {OrderID}\n";
            return dbMan.ExecuteNonQuery(query);
        }

        public static int GetOrdersCountFromFood(int FoodID)   // Ahmad
        {
            string query = $@"
        SELECT ISNULL(SUM(OrderCount),0)
        FROM Orders_Details
        WHERE FoodID = " + FoodID.ToString();

            return (int)dbMan.ExecuteScalar(query);
        }


        public static DataTable GetTotalOrderPrice(String OrderID)   // Ahmad
        {

            string query = $@"
        SELECT SUM( CAST(Orders_Details.OrderCount AS DECIMAL(7,2))  * FoodItems.Price) as TotalPrice
        FROM Orders_Details,FoodItems
        WHERE Orders_Details.FoodID = FoodItems.FoodID and Orders_Details.OrderID = " + OrderID;

            return dbMan.ExecuteReader(query);

        }

        public static int InsertAccount(string Fname, string Lname, string email, string pass, int PhoneNumber, string authority)
        {
            string query =
                "INSERT INTO Accounts (Fname, Lname, Email, Pass, PhoneNumber, Authority)\n" +
                $"Values ('{Fname}', '{Lname}', '{email}', '{pass}', {PhoneNumber}, '{authority}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public static userMode CheckUser(string Email, string Password, out int ID)
        {
            string query =
                "SELECT Authority,UserID\n" +
                "FROM Accounts\n" +
                $"WHERE Email='{Email}' AND Pass='{Password}'";

            DataTable table = dbMan.ExecuteReader(query);
            if (table == null)
            {
                ID = -1;
                return userMode.Guest;
            }
            object ResultObject = table.Rows[0][0];
            string Result;
            if (ResultObject != null)
                Result = ResultObject.ToString();
            else
                Result = null;
            ID = (int)table.Rows[0][1];

            return HelperFunctions.ParseAuthorityToEnum(Result);
        }

        public static DataTable GetTickets(bool unSeenOnly = true)
        {
            string query;
            if (unSeenOnly)
                query =
                    "SELECT HelpTicketID, Header, Fname, Lname\n" +
                    "FROM HelpTickets, Accounts\n" +
                    $"WHERE HelpTickets.UserID = Accounts.UserID AND Seen=0\n";
            else
                query =
                    "SELECT HelpTicketID, Header, Fname, Lname\n" +
                    "FROM HelpTickets, Accounts\n" +
                    "WHERE HelpTickets.UserID = Accounts.UserID\n";

            return dbMan.ExecuteReader(query);
        }
        public static DataTable GetTicketsAdmin()
        {
            string query =
                    "SELECT HelpTicketID, Header, Fname, Lname, Seen\n" +
                    "FROM HelpTickets, Accounts\n" +
                    "WHERE HelpTickets.UserID = Accounts.UserID\n";
            return dbMan.ExecuteReader(query);
        }


        public static DataTable GetUserTickets(int UserID)
        {
            string query =
                "SELECT HelpTicketID, Header, Fname, Lname\n" +
                "FROM HelpTickets, Accounts\n" +
                $"WHERE HelpTickets.UserID = Accounts.UserID AND Accounts.UserID = {UserID}\n";

            return dbMan.ExecuteReader(query);
        }

        public static DataTable GetTicket(int TicketID)
        {

            string query =
                "SELECT HelpTickets.*, Fname, Lname\n" +
                "FROM HelpTickets, Accounts\n" +
                $"WHERE HelpTickets.UserID = Accounts.UserID AND HelpTickets.HelpTicketID = {TicketID}\n";

            return dbMan.ExecuteReader(query);
        }

        public static void MarkTicket(int TicketID)
        {
            string query =
                "UPDATE HelpTickets\n" +
                "SET Seen=1\n" +
                $"WHERE HelpTicketID = {TicketID}\n";
            dbMan.ExecuteNonQuery(query);
            return;
        }

        public static int SubmitTicket(int UserID, string Header, string Content)
        {
            string query =
                "INSERT INTO HelpTickets (UserID,Header,Content)\n" +
                $"VALUES ({UserID},'{Header}','{Content}')\n";
            return dbMan.ExecuteNonQuery(query);
        }

        public static void SubmitReview(int UserID, int Rating, int MovieID)
        {
            string query =
                "INSERT INTO MovieReviews (UserID,MovieID,Rating)\n" +
                $"VALUES ({UserID},{MovieID},{Rating})\n";
            dbMan.ExecuteNonQuery(query);
        }

        public static DataTable FetchUser(int UserID)
        {
            string query =
                "SELECT Fname, Lname\n" +
                "FROM Accounts\n" +
                $"WHERE UserID = {UserID}\n";
            return dbMan.ExecuteReader(query);
        }

        public static DataTable GetCurrentShows()
        {
            string query =
                "SELECT M.MovieID, M.MovieName, M.MovieDescription, M.MoviePicturePath\n" +
                "FROM\n" +
                    "(\n" +
                    "SELECT DISTINCT Movies.*\n" +
                    "FROM Shows, Movies\n" +
                    "WHERE Shows.MovieID = Movies.MovieID) M\n";
            return dbMan.ExecuteReader(query);
        }

        public static DataTable GetShowsForMovie(int MovieID)
        {
            string query =
                "SELECT Shows.StartTime, Shows.EndTime, Cinemas.CinemaType, COUNT(SeatNumber) AS Seats_Available\n" +
                "FROM Shows, Cinemas, Seats\n" +
                "WHERE Shows.CinemaID = Seats.CinemaID\n" +
                "GROUP BY Shows.StartTime, Shows.EndTime, CinemaID\n";
            return dbMan.ExecuteReader(query);
        }

        public static DataTable GetMovie(int MovieID)
        {
            string query =
                "SELECT Movies.MovieName, Movies.MoviePicturePath, Movies.MovieDescription\n" +
                "FROM Movies\n" +
                $"WHERE Movies.MovieID = {MovieID} \n";
            return dbMan.ExecuteReader(query);
        }

        public static DataTable GetShowTimes(int MovieID)
        {
            string query =
                "SELECT Shows.CinemaID, Cinemas.CinemaType, Shows.StartTime, Shows.EndTime, Shows.ShowDate\n" +
                "FROM Shows, Movies, Cinemas\n" +
                $"WHERE Shows.CinemaID = Cinemas.CinemaID AND Movies.MovieID = {MovieID} AND Movies.MovieID = Shows.MovieID\n";
            return dbMan.ExecuteReader(query);
        }

        public static DataTable GetMovieName(int MovieID)
        {
            string query =
                "SELECT Movies.MovieName\n" +
                "FROM Movies\n" +
                $"WHERE Movies.MovieID = {MovieID}\n";
            return dbMan.ExecuteReader(query);
        }

        public static int GetMovieReviews(int MovieID)
        {
            string query =
                "SELECT AVG(MovieReviews.Rating) AS Rating\n" +
                "FROM MovieReviews\n" +
                $"WHERE MovieReviews.MovieID = {MovieID}\n" +
                "GROUP BY MovieReviews.MovieID\n";
            object Rating = dbMan.ExecuteScalar(query);
            if (Rating != null)
                return Convert.ToInt32(Rating);
            else
                return 0;

        }
        public static DataTable GetAllSeats(int CinemaID)
        {
            string query =
                "SELECT SeatNumber\n" +
                "FROM Seats\n" +
                $"WHERE CinemaID = {CinemaID}\n";

            return dbMan.ExecuteReader(query);
        }

        public static DataTable GetTakenShowSeats(int ShowID)
        {
            string query =
                "SELECT SeatNumber\n" +
                "FROM Bookings, BookingSeats, Seats\n" +
                $"WHERE Bookings.ShowID = {ShowID} AND Seats.CinemaID = BookingSeats.CinemaID AND Bookings.BookingID = BookingSeats.BookingID\n";
            return dbMan.ExecuteReader(query);
        }

        public static DataTable GetShowTimesFull(int MovieID)
        {
            string query =
                "SELECT Shows.*\n" +
                "FROM Shows, Movies\n" +
                $"WHERE Movies.MovieID = {MovieID} AND Movies.MovieID = Shows.MovieID AND Shows.Old = 0\n";
            return dbMan.ExecuteReader(query);
        }

        public static int GetLastBooking(int UserID)
        {
            string query =
                "SELECT MAX(BookingID) AS last\n" +
                "FROM Bookings\n" +
                $"WHERE Bookings.UserID = {UserID}\n";
            DataTable dt = dbMan.ExecuteReader(query);
            if (dt == null) return 0;
                return dt.Rows[0].Field<int>("last");
        }

        public static void InsertBooking(int UserID, int ShowID, List<int> SeatNumbers)
        {
            string Initialquery =
                "INSERT INTO Bookings (UserID, ShowID)\n" +
                $"VALUES ({UserID}, {ShowID})\n";

            dbMan.ExecuteNonQuery(Initialquery);

            int bookingID = Convert.ToInt32(dbMan.ExecuteScalar("SELECT @@IDENTITY"));
            int CinemaID = Convert.ToInt32(dbMan.ExecuteScalar($"SELECT Cinemas.CinemaID FROM Cinemas, Shows WHERE Shows.CinemaID = Cinemas.CinemaID AND Shows.ShowID = {ShowID}"));

            foreach(int Seat in SeatNumbers)
            {
                string query =
                    "INSERT INTO BookingSeats (BookingID, CinemaID, SeatID)\n" +
                    $"VALUES ({bookingID}, {CinemaID}, {Seat})\n";

            dbMan.ExecuteNonQuery(query);
            }

        }

        public static void UpdatePass(int UserID,string Password)
        {
            string query =
                "UPDATE Accounts\n" +
                $"SET Pass = '{Password}'\n" +
                $"WHERE UserID = {UserID}\n";
            dbMan.ExecuteNonQuery(query);
        }
        public static DataTable GetAllShows()
        {
            string query =
                "SELECT * FROM Shows";
            return dbMan.ExecuteReader(query);
        }

        //public static void InsertShow(string MovieName, string CinemaType, int Start)
        //{
        //    string query =     
        //}

    }
}
