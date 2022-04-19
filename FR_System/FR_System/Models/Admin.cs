using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR_System.Models
{
    [Table("TblAdmin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        [Display(Name = "Admin Name")]

        public string AdminName { get; set; }
        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}
