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

        public int UserId { get; set; }
        [ForeignKey("UserId ")]
        public virtual User Users { get; set; }

        [Required(ErrorMessage ="No of travellers are required")]
        [Display(Name = "Travellers")]
        public int Travellers { get; set; }

        [Display(Name = "Total Fare")]
        public decimal Totalprice { get; set; }

        public bool Payment { get; set; }

    }
}
