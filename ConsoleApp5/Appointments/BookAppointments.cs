using BAL.Validations;

namespace ConsoleApp5.Appointments
{
    public class BookAppointments
    {
        public async Task BookAppointment()
        {
            bool isValid = false;

            int queueNo;
            int.TryParse(Console.ReadLine(), out queueNo);
            DateTime dateOfAppointment;
            string? doctorName = string.Empty;
            string? patientName = string.Empty;
            string? gender = string.Empty;
            string? mobileNo = string.Empty;
            string? email = string.Empty;
            int fee = 500;
            int.TryParse(Console.ReadLine(), out  fee);
            bool isDeleted = false;

            while (!isValid)
            {
                Console.WriteLine("Please Enter the QueueNo: ");
                queueNo = Convert.ToInt32(Console.ReadLine());
                bool isValidQueueNo = AppointmentsDataValidation.IsQueueNoValid(queueNo);
                if (isValidQueueNo)
                {
                    isValid = true;
                }
            }

            isValid = false;
            while(!isValid) {
                Console.WriteLine("Enter Date of appointment:  ");
                dateOfAppointment = Convert.ToDateTime(Console.ReadLine());
                bool isValidDate = AppointmentsDataValidation.IsDateValid(dateOfAppointment);
                if(isValidDate)
                {
                    isValid = true;
                }
            }

            isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Enter Doctor Name: ");
                doctorName = Console.ReadLine();
                bool isValidDoctorName = AppointmentsDataValidation.IsDoctorNameValid(doctorName);
                if (isValidDoctorName)
                {
                    isValid = true;
                }
               
            }

            isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Enter Patient Name: ");
                patientName = Console.ReadLine();
                bool isValidPatientName = AppointmentsDataValidation.IsPatientNameValid(patientName);
                if (isValidPatientName)
                {
                    isValid = true;
                }
            }

            isValid = false;
            while (!isValid)
            {
                Console.WriteLine(@"Choose your gender: (M/F) ");
                gender = Console.ReadLine();
                bool isValidGender = AppointmentsDataValidation.IsGenderValid(gender);
                if (isValidGender)
                {
                    isValid = true;
                }
            }

            isValid = false;
            while(!isValid)
            {
                Console.WriteLine("Enter Mobile No: ");
                mobileNo = Console.ReadLine();
                bool isValidMobileNo = AppointmentsDataValidation.IsMobileNoValid(mobileNo);
                if (isValidMobileNo)
                {
                    isValid = true;
                }
            }
            isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Enter your mail id: ");
                email = Console.ReadLine();
                bool isValidEmail = AppointmentsDataValidation.IsEmailValid(email);
                if(isValidEmail)
                {
                    isValid = true;
                }
            }
            isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Fee Charges: 500 ");
                isValid = true;
            }

            isValid = false;
            while (!isValid)
            {
                Console.Write("Is the record deleted? (true/false): ");
                string isDeletedInput = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(isDeletedInput) && bool.TryParse(isDeletedInput, out bool parsedIsDeleted))
                {
                    isDeleted = parsedIsDeleted;
                }
            }

            var 
        }
    }
}
