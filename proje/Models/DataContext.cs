using Microsoft.EntityFrameworkCore;

namespace proje.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=KADIRBURAKONCUL\\SQLEXPRESS; database=loginDB; integrated security=true;TrustServerCertificate=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Department> Departments { get; set; }



    }
}

