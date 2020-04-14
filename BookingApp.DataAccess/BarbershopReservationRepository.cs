using BookingApp.ApplicationLogic.Abstractions;
using BookingApp.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.DataAccess
{
    public class BarbershopReservationRepository : BaseRepository<BarbershopReservation>, IBarbershopReservationRepository
    {
        public BarbershopReservationRepository(BookingAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
