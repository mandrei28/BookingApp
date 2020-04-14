using BookingApp.ApplicationLogic.Abstractions;
using BookingApp.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.DataAccess
{
    public class BarbershopRepository : BaseRepository<Barbershop>, IBarbershopRepository
    {
        public BarbershopRepository(BookingAppDbContext dbContext) : base(dbContext)
        {
        }
        public IEnumerable<Guid> GetIds()
        {
            var ids = dbContext.Barbershops.Select(b => b.Id);
            return ids;
        }
        public Barbershop GetBarbershopById(Guid id)
        {
            var barbershop = dbContext.Barbershops.Where(b => b.Id == id).FirstOrDefault();
            return barbershop;
        }
    }
}
