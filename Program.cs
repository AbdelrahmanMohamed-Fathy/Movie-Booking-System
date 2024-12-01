using System;
using System.IO;
using System.Windows.Forms;

namespace Movie_Booking_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Loading Connection String
            string root = Directory.GetCurrentDirectory();
            DotEnv.Load(Path.Combine(root, "..\\..\\.env"));

            Application.Run(new Form1());
        }
    }
}
