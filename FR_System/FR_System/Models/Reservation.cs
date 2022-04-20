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

    }
}
