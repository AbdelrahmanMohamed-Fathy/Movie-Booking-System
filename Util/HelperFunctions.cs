using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Booking_System.Util
{
    internal class HelperFunctions
    {
        public static userMode ParseAuthorityToEnum(string Authority)
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

        public static string ParseEnumToAuthority(userMode Authority)
        {
            switch (Authority)
            {
                case userMode.Admin:
                    return "Admin";
                case userMode.Employee:
                    return "Employee";
                case userMode.User:
                    return "Client";
                default:
                    return null;
            }
        }
    }
}
