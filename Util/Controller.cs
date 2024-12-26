using System;
using System.Data;
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

        public static int InsertNewOrder(string UserID)  // ahmad
        {
            string query =
                "INSERT INTO AllOrders (UserID)\n" +
                $"Values ({UserID})";
            return dbMan.ExecuteNonQuery(query);
        }

        public static int GetNewOrderID(string UserID)  // ahmad
        {
            string query = $@"
        SELECT ISNULL(MAX(OrderID),0)
        FROM AllOrders
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

        public static int InsertFoodOrder(string DoodID, string OrderCount, string Fulfilled,String OrderID)  // ahmad
        {
            string query =
                "INSERT INTO Orders_Details (FoodID, OrderCount, Fulfilled, OrderID)\n" +
                $"Values ({DoodID}, {OrderCount}, {Fulfilled}, {OrderID})";
            return dbMan.ExecuteNonQuery(query);
        }


        public static int DeleteOrders(string OrderID)  // ahmad
        {
            string query;
            if (OrderID == "")
            {
                query =
                "Delete Orders_Details\n" +
                $"Where OrderID = " + OrderID;
            }
            else
            {
                query =
                    "Delete Orders_Details\n";
            }
            return dbMan.ExecuteNonQuery(query);
        }

        public static DataTable GetOrders()     // ahmad
        {
            string query =
                "SELECT Orders_Details.OrderID, Orders_Details.FoodID, FoodItems.FoodName, Orders_Details.OrderCount, FoodItems.Price, Orders_Details.Fulfilled, AllOrders.UserID \n" +
                "FROM Orders_Details, FoodItems, AllOrders\n" +
                "WHERE AllOrders.OrderID = Orders_Details.OrderID and Orders_Details.FoodID = FoodItems.FoodID\n Order by Orders_Details.OrderID";

            return dbMan.ExecuteReader(query);
        }

        public static int UpdateOrder(int OrderID)   // ahmad
        {
            string query =
                "UPDATE Orders_Details\n" +
                "SET Fulfilled = 1\n" +
                $"WHERE OrderID = {OrderID}\n";
            return dbMan.ExecuteNonQuery(query);
        }

        public static int GetAllOrdersCountFromFood(int FoodID)   // Ahmad
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

        public static int InsertAccount(string Fname, string Lname, string email, string pass, int PhoneNumber, userMode authority)
        {
            string query =
                "INSERT INTO Accounts (Fname, Lname, Email, Pass, PhoneNumber, Authority)\n" +
                $"Values ('{Fname}', '{Lname}', '{email}', '{pass}', {PhoneNumber}, '{authority}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public static userMode FetchUser(string Email, string Password, out int ID)
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

        public static DataTable GetTickets()
        {
            string query =
                "SELECT HelpTicketID, Header, Fname, Lname\n" +
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

        public static DataTable GetTicket(int TicketID, bool unSeenOnly = true)
        {

            string query;
            if (unSeenOnly)
                query =
                    "SELECT HelpTickets.*, Fname, Lname\n" +
                    "FROM HelpTickets, Accounts\n" +
                    $"WHERE HelpTickets.UserID = Accounts.UserID AND HelpTickets.HelpTicketID = {TicketID}\n";
            else
                query =
                    "SELECT HelpTickets.*, Fname, Lname\n" +
                    "FROM HelpTickets, Accounts\n" +
                    $"WHERE HelpTickets.UserID = Accounts.UserID AND HelpTickets.HelpTicketID = {TicketID}\n";

            return dbMan.ExecuteReader(query);
        }

        public static void MarkTicket(int TicketID)
        {
            string query =
                "UPDATE HelpTickets(Seen)\n" +
                "SET 1\n" +
                $"WHERE HelpTicketID = {TicketID}\n";
        }
    }
}
