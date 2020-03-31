using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class ReservationModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int reservationId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string StartHour { get; set; }
        public int restaurantId { get; set; }
        public virtual RestaurantModel restaurant { get; set; }
    }
}
