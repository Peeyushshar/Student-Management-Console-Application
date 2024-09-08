using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using static DAL.Entities.Appointment;
using static DAL.Entities.UserData;

namespace DAL.ApplicationDBContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<AppointmentsData> AppointmentsData{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Peeyush-7QQ2TEN;Initial Catalog=HospitalDB;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id);
                entity.Property(c => c.Email);
                entity.Property(c => c.Password);
            });
            modelBuilder.Entity<AppointmentsData>(entity =>
            {
                entity.ToTable("AppointmentsData");
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Id);
                entity.Property(c => c.QueueNo);
                entity.Property(c => c.DateOfAppointment);
                entity.Property(c => c.DoctorName);
                entity.Property(c => c.PatientName);
                entity.Property(c => c.Gender);
                entity.Property(c => c.MobileNo);
                entity.Property(c => c.Email);
                entity.Property(c => c.Fee);
                entity.Property(c => c.isDeleted);
            });


        }
    }
}
