using System;
using System.Data;

namespace Movie_Booking_System
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
    }
}
