namespace proje.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int UserId { get; set; } // Kullanıcı ile ilişki
        public int DoctorId { get; set; } // Doktor ile ilişki
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
        // Diğer ilgili özellikler
        public List<User> Users { get; set; }
        public Doctor doctor { get; set; }
    }
}
