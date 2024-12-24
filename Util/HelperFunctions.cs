using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Booking_System.Util
{
    internal class HelperFunctions
    {
        public static userMode ParseAuthority(string Authority)
        {
            switch (Authority)
            {
                case "Admin":
                    return userMode.Admin;
                case "Employee":
                    return userMode.Employee;
                case "Client":
                    return userMode.User;
                default:
                    return userMode.Guest;
            }
        }
    }
}
