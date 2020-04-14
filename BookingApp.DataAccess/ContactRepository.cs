using BookingApp.ApplicationLogic.Abstractions;
using BookingApp.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.DataAccess
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(BookingAppDbContext dbContext) : base(dbContext)
        {
        }
        public IEnumerable<Guid> GetIds()
        {
            var ids = dbContext.ContactMessages.Select(c => c.Id);
            return ids;
        }
        public Contact GetContactById(Guid id)
        {
            var contact = dbContext.ContactMessages.Where(c => c.Id == id).FirstOrDefault();
            return contact;
        }
    }
}
