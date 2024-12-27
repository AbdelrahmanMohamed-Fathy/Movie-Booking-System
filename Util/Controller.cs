using System;
using System.Data;
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
        public static int DeleteHelpTicket(int TicketID)
        {
            string query = $"DELETE FROM HelpTickets WHERE HelpTicketID ={TicketID};";
            return dbMan.ExecuteNonQuery(query);
        }

        public static int InsertAccount(string Fname, string Lname, string email, string pass, int PhoneNumber, string authority)
        {
            string query =
                "INSERT INTO Accounts (Fname, Lname, Email, Pass, PhoneNumber, Authority)\n" +
                $"Values ('{Fname}', '{Lname}', '{email}', '{pass}', {PhoneNumber}, '{authority}')";
            return dbMan.ExecuteNonQuery(query);
        }

        public static userMode CheckUser(string Email,string Password, out int ID)
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

        public static int SubmitTicket(int UserID,string Header, string Content)
        {
            string query =
                "INSERT INTO HelpTickets (UserID,Header,Content)\n" +
                $"VALUES ({UserID},'{Header}','{Content}')\n";
            return dbMan.ExecuteNonQuery(query);
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
                "SELECT M.MovieID, M.MovieName, M.MovieDescription, M.MoviePicturePath, AVG(R.Rating) AS Rating\n" +
                "FROM\n" +
                    "(\n" +
                    "SELECT DISTINCT Movies.*\n" +
                    "FROM Shows, Movies\n" +
                    "WHERE Shows.MovieID = Movies.MovieID) M, MovieReviews R\n" +
                "WHERE R.MovieID = M.MovieID\n" +
                "GROUP BY M.MovieID , M.MovieName, M.MovieDescription, M.MoviePicturePath\n";
            return dbMan.ExecuteReader(query);
        }



    }
}
