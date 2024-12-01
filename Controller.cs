using System;
using System.Data;

namespace Movie_Booking_System
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        //SQL Queries to be added here, just like back in ~nam~ labs
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
