using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game02
{
    internal static class Program
    {
        private static string _username;
        private static int _userID;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _username = GetUsernameFromUser();
            Application.Run(new MainMenu(_username));
        }
        private static string GetUsernameFromUser()
        {
            Console.Write("Please enter your username: ");
            return Console.ReadLine();
        }
    }
}
