using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.DTOS
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserDto(int id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
        }

        public UserDto()
        {
        }
    }
}
