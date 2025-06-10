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

namespace WinFormsApp_2025_06_02.Views
{
    public partial class UserView : Form
    {
        private readonly UserController _userController;
        private List<AppUser> _users;
        //  private List<AppUser> Users;
        public UserView()
        {
            InitializeComponent();
            _userController = new UserController();
            LoadUsers();
            
        }

        private void LoadUsers()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = this.GetAllUsers();
           
        }
        //private List<AppUser> Users = new List<AppUser>
        //{
        //    new AppUser { Id = 1, Username = "admin", Role = UserRole.Admin },
        //    new AppUser { Id = 2, Username = "john", Role = UserRole.Staff }
        //};

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();

            signUpForm.Show();
            this.Hide();
        }

        //public AppUser AddUser()
        //{
        //    var data = _userController.AddUser()
        //}

        public List<AppUser> GetAllUsers()
        {
            var data = _userController.GetAllUsers();
            return data;
        }
    }
}
