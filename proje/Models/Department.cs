using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proje.Models
{
    public class Department
    {
        [Key]
        public  int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
       
       
        public Clinic clinic { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
