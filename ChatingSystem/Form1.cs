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
        public string password;

        
        public Anmelden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;

            bool isValid = DBcontroller.AccountChecker(username, password);

            if (isValid)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Der Benutzer existiert nicht");
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
          
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
