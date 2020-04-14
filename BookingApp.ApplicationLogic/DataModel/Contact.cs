using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.ApplicationLogic.DataModel
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
