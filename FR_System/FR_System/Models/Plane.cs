using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FR_System.Models
{
    [Table("TblPlane")]
    public class Plane
    {
        [Key]
        public int PlaneID { get; set; }

        [Required(ErrorMessage = "Plane Name Required")]
        [Display(Name = "Plane Name")]
        [MinLength(3, ErrorMessage = "Min 3 char req"), MaxLength(20, ErrorMessage = "Max 20 char req")]
        public string PlaneName { get; set; }

        [Required(ErrorMessage = "Capacity Required")]
        [Display(Name = "Seating Capacity")]
        public int Seats { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
