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
            
            Anmelden loginForm = new Anmelden();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Wenn Login erfolgreich war
                Chat chat = new Chat(loginForm.username);
                Application.Run(chat);
            }
            Anmelden F1 = new Anmelden();
            string name = F1.username;
            Chat F2 = new Chat(name);


        }
    }
}
