using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR_System.Models
{
    public class Plane
    {
        [Key]
        public int PlaneID { get; set; }
        [Display(Name = "Plane Name")]

        public string PlaneName { get; set; }

        [Required]
        [Display(Name = "Seating Capacity")]
        public int SeatingCapacity { get; set; }

        [Required]

        public float Price { get; set; }
    }
}
