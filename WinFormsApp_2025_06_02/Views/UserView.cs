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
        private UserController userController;
        private List<AppUser> Users;
        public UserView()
        {
            InitializeComponent();
            LoadUsers();
            userController = new UserController();
        }

        private void LoadUsers()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = Users;
        }
        //private List<AppUser> Users = new List<AppUser>
        //{
        //    new AppUser { Id = 1, Username = "admin", Role = UserRole.Admin },
        //    new AppUser { Id = 2, Username = "john", Role = UserRole.Staff }
        //};

        public List<AppUser> GetAllUsers()
        {
            return Users;
        }
    }
}
