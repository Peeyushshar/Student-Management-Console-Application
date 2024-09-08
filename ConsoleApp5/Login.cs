using BAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Login
    {
        private readonly UserService _userService;
        private MenuPage _menuPage;

        public Login()
        {
            _userService = new ();
        }
        public async Task UserLogin()
        {
            bool isValid = false;
            string? userEmail = string.Empty;

            while(!isValid)
            {
                Console.WriteLine("Please Enter Email: ");
                userEmail = Console.ReadLine();
                bool isValidEmail = await _userService.CheckEmail(userEmail);
                if (isValidEmail)
                {
                    isValid = true;
                }
            }

            isValid = false;

            while(!isValid)
            {
                Console.WriteLine("Please Enter Password: ");
                string? userPassword = Console.ReadLine();
                bool isValidPass = await _userService.CheckPassword(userEmail, userPassword);
                if (isValidPass)
                {
                    Console.WriteLine("Login Successfully!");

                    isValid = true;
                    Console.ReadKey();  
                    _menuPage = new ();
                    await _menuPage.MenuItem();
                }
            }
        }
    }
}
