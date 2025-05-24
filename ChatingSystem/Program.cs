using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatingSystem
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
            string username;
            Anmelden loginForm = new Anmelden();
            Application.Run(loginForm);
            username = loginForm.username;
            Chat chat = new Chat(username);
            Application.Run(chat);



        }
    }
}
