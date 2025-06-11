using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public  List<AppUser> GetAllUsers()
        {
            var users = new List<AppUser>();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string query = "SELECT Id, Username, Role,Name FROM Users";

                using var cmd = new SQLiteCommand(query, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new AppUser
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Username = reader["Username"].ToString(),
                        Role = reader["Role"].ToString()
                    });
                }

                return users;
            };
       
        }
        public AppUser AddUser(AppUser user)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string query = "Insert into Users(Name ,Username ,Password ,Role) values(@Name , @Username , @Password , @Role)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", user.Name);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Bike successfully added");

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                return user;
            }
         
        }

        public bool Login(Credentials credentials)
        {
            try
            {
                var user = new AppUser();   
                using (var conn = new SQLiteConnection(ConnectionString))
                {
                    conn.Open();

                    string query = "SELECT Username, Password  FROM Users WHERE Username = @Username";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@Username", credentials.Username);
                        cmd.Parameters.AddWithValue("@Password", credentials.Password);

                        SQLiteDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            user.Username = reader["Username"].ToString();
                            user.Password = reader["Password"].ToString();  
                        }
                    }
                    if (user.Password == credentials.Password) { 
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }
            catch (Exception ex) {
                return false;
            }
           
        }
    }
}
