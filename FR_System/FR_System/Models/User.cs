using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR_System.Models
{
    [Table("TblUser")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Req")]
        [MaxLength(30, ErrorMessage = "Max 30 char req"), MinLength(4, ErrorMessage = "Min 4 char req")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Req")]
        [MaxLength(30, ErrorMessage = "Max 30 char req"), MinLength(4, ErrorMessage = "Min 4 char req")]
        public string LastName { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name Req")]
        [MaxLength(30, ErrorMessage = "Max 30 char req"), MinLength(4, ErrorMessage = "Min 4 char req")]
        public string UserName { get; set; }


        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender Required")]
        public string Gender { get; set; }

        [Required]
        [Range(18, 120, ErrorMessage = "min 18 years has book the flight")]
        public int Age { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address Req")]
        [MinLength(3, ErrorMessage = "Min 3 char req"), MaxLength(40, ErrorMessage = "Max 40 char req")]
        public string Address { get; set; }


        [Display(Name = "Phone No")]
        [Required(ErrorMessage = "Phone No Req"), RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Phone No is not valid")]
        [StringLength(11)]
        public string PhoneNo { get; set; }

        
        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "Email ID Req")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email invalid")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Req")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Password not matched")]
        public string CPassword { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }

    }
}