using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BAL.Validations
{
    public class AppointmentsDataValidation
    {
        public static bool IsQueueNoValid(int queueNo)
        {
            if(queueNo ==' ')
            {
                return false;
            }
            return true;
        }

        public static bool IsDateValid(DateTime date)
        {
            DateTime currentDate = DateTime.Now.Date;
            
            TimeSpan difference = date - currentDate;

            if (difference <= TimeSpan.FromDays(7))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDoctorNameValid(string? doctorName)
        {
            if(doctorName == null) 
            { return false; } 
            else if(doctorName.Length >=2 && doctorName.Length <=50) { return true; }
            return true;
        }
        public static bool IsPatientNameValid(string? doctorName)
        {
            if (doctorName == null)
            { return false; }
            else if (doctorName.Length >= 2 && doctorName.Length <= 50) { return true; }
            return true;
        }

        public static bool IsGenderValid(string? gender)
        {
            if (gender == null) { return false; }
            if (gender == "M" || gender == "F")
            {
                return true;
            }
            return false;
        }

        public static bool IsMobileNoValid(string? mobileNo)
        {
            string pattern = @"^\+91[1-9][0-9]{9}$";

            return Regex.IsMatch(mobileNo, pattern);
        }

        public static bool IsEmailValid(string? email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            return Regex.IsMatch(email, pattern);
        }
    }
}
