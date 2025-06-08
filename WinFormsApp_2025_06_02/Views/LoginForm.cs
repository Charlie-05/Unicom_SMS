using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_2025_06_02.Views;

namespace WinFormsApp_2025_06_02
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OnLogin(object sender, EventArgs e)
        {
            
            string username = userNameTxt.Text.Trim();
            string password = passwordTxt.Text;

            // Hardcoded credentials
            string validUsername = "admin";
            string validPassword = "12345";

            if (username == validUsername && password == validPassword)
            {
                // Success — open MainForm
                UserView userView = new UserView();
                userView.Show();
                this.Hide();
            } 
            else
            {
                // Invalid — show error
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Optionally clear fields
                userNameTxt.Clear();
                userNameTxt.Focus();
            }
        }
    }
}
