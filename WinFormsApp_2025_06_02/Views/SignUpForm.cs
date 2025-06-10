using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_2025_06_02.Controllers;
using WinFormsApp_2025_06_02.Models;
using WinFormsApp_2025_06_02.Views;

namespace WinFormsApp_2025_06_02
{
    public partial class SignUpForm : Form
    {
        private readonly UserController _userController;
        public SignUpForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserView userView = new UserView();
            userView.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppUser user = new AppUser()
            {
                Name = textBox1.Text,
                Username = textBox2.Text.Trim(),
                Password = textBox3.Text,
                Role = comboBox1.Text,
            };
            
           var data =  _userController.AddUser(user);

        }
    }
}
