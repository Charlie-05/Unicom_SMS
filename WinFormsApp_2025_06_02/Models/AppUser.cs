using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_2025_06_02.Models
{
    public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Username { get; set; }    
        public string? Role {  get; set; }
        public string? Password {  get; set; }
    }

    public enum UserRole
    {
        Admin = 1,
        Staff = 2,
        Lecturer= 3,
        Student = 4,
    }

    public class RoleOptions
    {
        public int RoleId {  get; set; }
        public UserRole RoleName { get; set; }   
    }

    public class Credentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
