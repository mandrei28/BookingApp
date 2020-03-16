using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApp.Models
{
    public class Reservation
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime Date { get; set; }
        string StartHour { get; set; }
        public Reservation()
        {
            this.Date = DateTime.Today;
        }
    }
}
