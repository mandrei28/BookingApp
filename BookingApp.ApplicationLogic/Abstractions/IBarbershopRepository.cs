using BookingApp.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.ApplicationLogic.Abstractions
{
    public interface IBarbershopRepository : IRepository<Barbershop>
    {
        public IEnumerable<Guid> GetIds();
        public Barbershop GetBarbershopById(Guid id);
    }
}
