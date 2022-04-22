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
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Req")]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Last Name Req")]
        public string Gender { get; set; }

        [Required]
        [Range(18, 120, ErrorMessage = "min 18 years has book the flight")]
        public int Age { get; set; }

        [Display(Name = "Phone No")]
        [Required(ErrorMessage = "Phone No Req"), RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Phone No is not valid")]
        [StringLength(11)]
        public string PhoneNo { get; set; }

        [Display(Name = "NIC No")]
        [Required(ErrorMessage = "NIC No Req"), RegularExpression(@"^([0-9]{13})$", ErrorMessage = "NIC No is not valid")]
        [StringLength(13)]
        public string NICNo { get; set; }

        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "Email ID Req")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Req")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password not matched")]
        public string CPassword { get; set; }


    }
}