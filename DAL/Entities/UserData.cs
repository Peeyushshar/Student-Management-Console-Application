using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class UserData
    {
        public class Users(int id, string email, string password)
        {
            public int Id { get; set; } = id;
            public string Email { get; set; } = email;
            public string Password { get; set; } = password;
        }
    }
}
