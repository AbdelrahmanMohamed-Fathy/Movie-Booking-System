using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Movie_Booking_System.Util
{
    public class Controller
    {
        static DBManager dbMan = new DBManager();
        public Controller()
        {
        }
        static public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable showallMovies()
        {
            string query = $"SELECT * FROM Movies";
            return dbMan.ExecuteReader(query);

        }
        public int InsertAccount(string Fname, string Lname, string email, string pass, int PhoneNumber, userMode authority)
        {
            //
            string query = "INSERT INTO Accounts (Fname, Lname, Email, Pass, PhoneNumber, Authority)" +
                            "Values ('" + Fname + "','" + Lname + "','" + email + "','" + pass + "'," + PhoneNumber + ",'" + authority + "');";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
