using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatingSystem
{
    public partial class Anmelden : Form
    {
        public string username;

        
        public Anmelden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Aufruf der Methode mit zwei Parametern (Name und Passwort)
            bool istKontoGültig = DBcontroller.AccountChecker("Benutzername", "Passwort");

          
        }

        private void Exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Anmelden_Load(object sender, EventArgs e)
        {

        }
    }
}
