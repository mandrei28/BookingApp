using BookingApp.ApplicationLogic.Abstractions;
using BookingApp.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.DataAccess
{
    public class AdministratorRepository : BaseRepository<Administrator>, IAdministratorRepository
    {
        public AdministratorRepository(BookingAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
