using System.Numerics;

namespace proje.Models
{
    public class Clinic
    {
        public int ClinicId { get; set; }
        public string ClinicName { get; set; }
        public string Location { get; set; }
        // Diğer ilgili özellikler

       public List<Department> Departments { get; set; }
    }
}
