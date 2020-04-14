using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookingApp.ApplicationLogic.DataModel
{
    public class BarbershopReservation
    {
        public Guid Id { get; set; }
        public Barbershop Barbershop { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string StartHour { get; set; }
    }
}
