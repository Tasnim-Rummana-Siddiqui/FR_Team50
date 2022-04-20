using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR_System.Models
{
    [Table("TblAdmin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Admin Name Required")]
        [Display(Name = "Admin Name")]
        [MinLength(3, ErrorMessage = "Min 3 char req"), MaxLength(20, ErrorMessage = "Max 20 char req")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(5, ErrorMessage = "Password can be of minimum 3 length"), MaxLength(10, ErrorMessage = "Password can be of minimum 3 length")]
        public string Password { get; set; }
    }
}
