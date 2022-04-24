using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR_System.Models
{
    [Table("TblReservation")]
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        public int FlightId { get; set; }
        [ForeignKey("FlightId ")]
        public virtual Flight Flights { get; set; }

        [Required(ErrorMessage = "City Name Required")]
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
        public int PlaneId { get; set; }
        [ForeignKey("PlaneId")]
        public virtual Plane Planes { get; set; }

        [Required(ErrorMessage = "Price Required")]
        [Display(Name = "Price")]
        public decimal price { get; set; }








    }
}
