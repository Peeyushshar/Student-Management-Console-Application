using static Common.Enums.MenuEnums;

namespace ConsoleApp5
{
    public class MenuPage
    {
        private MainPage? _mainPage;
        public async Task MenuItem()
        {
            bool isExist = false;
            while(!isExist)
            {
                Console.Clear();
                Console.WriteLine(@"What do you want to do?
                1 BookAppointment
                2 View All Appointments
                3 Cancel Appointment
                4 View Daily Cash
                5 Exit");
                int userInput;
                int.TryParse(Console.ReadLine(), out userInput);

                switch (userInput)
                {
                    case (int)MenuType.BookAppointment:
                        break;
                    case (int)MenuType.ViewAllAppointments: break;
                    case (int)MenuType.CancelAppointment: break;
                    case (int)MenuType.ViewDailyCash: break;
                    case (int)MenuType.Exit:
                        _mainPage = new ();
                        await _mainPage.MainProgram();
                        break;
                    default:
                        Console.WriteLine("Unexpected Input!");
                        break;
                }
            }
        }
    }
}
