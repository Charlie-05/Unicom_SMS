using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_2025_06_02.Data;
using WinFormsApp_2025_06_02.Models;

namespace WinFormsApp_2025_06_02.Controllers
{
    public class UserController
    {
        public static string ConnectionString => DBInitializer.ConnectionString;

        public static List<AppUser> GetAllUsers()
        {
            var users = new List<AppUser>();

            using var conn = new SQLiteConnection(ConnectionString);
            conn.Open();

            string query = "SELECT Id, Username, Role FROM Users";

            using var cmd = new SQLiteCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new AppUser
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Username = reader["Username"].ToString()
                    //  Role = reader["Role"].ToString()
                });
            }

            return users;
        }
    }
}
