using System.ComponentModel.DataAnnotations;

namespace proje.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string Kullanici { get; set; }
    }
}
