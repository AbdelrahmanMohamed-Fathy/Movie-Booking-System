using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Movie_Booking_System.Util
{
    public class Controller
    {
        static DBManager dbMan = new DBManager();

        static public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        static public DataTable showallMovies()
        {
            string query = $"SELECT * FROM Movies";
            return dbMan.ExecuteReader(query);
        }

        static public int InsertAccount(string Fname, string Lname, string email, string pass, int PhoneNumber, userMode authority)
        {
            string query =
                "INSERT INTO Accounts (Fname, Lname, Email, Pass, PhoneNumber, Authority)\n" +
                $"Values ('{Fname}', '{Lname}', '{email}', '{pass}', {PhoneNumber}, '{authority}')";
            return dbMan.ExecuteNonQuery(query);
        }

        static public userMode FetchUser(string Email,string Password)
        {
            string query =
                "SELECT Authority\n" +
                "FROM Accounts\n" +
                $"WHERE Email='{Email}' AND Pass='{Password}'";

            object ResultObject = dbMan.ExecuteScalar(query);
            string Result;
            if (ResultObject != null)
                Result = ResultObject.ToString();
            else
                Result = null;

            return HelperFunctions.ParseAuthorityToEnum(Result);
        }

    }
}
