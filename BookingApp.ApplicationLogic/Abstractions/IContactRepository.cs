using BookingApp.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.ApplicationLogic.Abstractions
{
    public interface IContactRepository : IRepository<Contact>
    {
        public IEnumerable<Guid> GetIds();
        public Contact GetContactById(Guid id);
    }
}
