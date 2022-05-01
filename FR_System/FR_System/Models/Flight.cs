using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace FR_System.Models
{
    [Table("TblFlight")]
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }

        [Required(ErrorMessage ="City Name Required")]
        [Display(Name = "From City")]
        public string FlightFrom { get; set; }

        [Required(ErrorMessage = "City Name Required")]
        [Display(Name = "To City")]
        public string FlightTo { get; set; }

        [Required(ErrorMessage = "Departure Date Required")]
        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]

        public System.DateTime FlightDDate { get; set; }

        [Required(ErrorMessage = "Departure Time Required")]
        [Display(Name = "Departure Time")]
        [StringLength(15)]
        public string DTime { get; set; }

        [Required(ErrorMessage = "Plane No Required"), Display(Name = "Plane No:")]
        public int PlaneID { get; set; }
        [ForeignKey("PlaneID")]
        public virtual Plane Planes { get; set; }

        [Required(ErrorMessage = "Price Required")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
