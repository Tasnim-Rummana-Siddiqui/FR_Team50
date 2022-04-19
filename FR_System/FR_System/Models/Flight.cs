using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FR_System.Models
{
    [Table("TblFlightBook")]
    public class Flight
    {
        [Key]
        public int bid { get; set; }

        [Required]
        [Display(Name = "From City")]
        public string From { get; set; }

        [Required]
        [Display(Name = "To City")]
        public string To { get; set; }

        [Display(Name = "Departure Date")]
        [DataType(DataType.Date)]

        public DateTime DDate { get; set; }

        [Display(Name = "Departure Time")]
        [StringLength(15)]

        public string DTime { get; set; }


        public int Planeid { get; set; }
        public virtual AeroPlaneInfo PlaneInfo { get; set; }

        [Display(Name = "Seat Type")]
        [StringLength(25)]
        public string SeatType { get; set; }
    }
}
