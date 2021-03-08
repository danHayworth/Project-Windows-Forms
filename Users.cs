using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Users(int id, string username, string password, string email)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }
    }
}
