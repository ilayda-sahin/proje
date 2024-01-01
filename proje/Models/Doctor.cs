using System.ComponentModel.DataAnnotations.Schema;

namespace proje.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Specialization { get; set; }
        public Department department { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
