using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.Enums.GenderEnum;

namespace DAL.Entities
{
    public class Appointment
    {
        public class AppointmentsData
        {
            public int Id { get; set; }
            public int QueueNo { get; set; }
            public DateTime DateOfAppointment { get; set; }
            public string DoctorName { get; set; }
            public string PatientName { get; set; }
            public  Gender? Gender { get; set; }
            public string MobileNo { get; set; }

            public string Email {  get; set; }
            public int Fee { get; set; }
            public bool isDeleted { get; set; }
            


        }
    }
}
