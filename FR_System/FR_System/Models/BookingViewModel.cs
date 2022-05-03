using System.ComponentModel.DataAnnotations;

namespace FR_System.Models
{
    public class BookingViewModel
    {
        public Flight flights { get; set; }

        public int FlightId { get; set; }

        [Required(ErrorMessage = "No of travellers are required")]
        [Display(Name = "Travellers")]
        public int Travellers { get; set; }

        [Display(Name = "Total Fare")]
        public decimal Totalprice { get; set; }
    }
    public class TicketViewModel
    {
        public Flight flights { get; set; }
        public Reservation reservations { get; set; }
        public int userid { get; set; }
    }
}
