using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Enums.LoginEnum;

namespace ConsoleApp5
{
    public class  MainPage
    {
        private readonly Login _login;

        public MainPage()
        {
            _login = new ();
        }
        public async Task MainProgram()
        {
            bool isExist = false;  
            while(!isExist)
            {
                Console.Clear();
                Console.WriteLine(@"================Welcome to OPD Management===============");
                Console.WriteLine(@"Please Choose Any One: 
                 1 Login
                 2 Exit");
                int userInput;
                int.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case (int)Option.Login:
                        await _login.UserLogin();
                        break;
                    case (int)Option.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Unexpected Input");
                        Console.ReadKey();
                        break;
                }
            }

        }     
    }
}
