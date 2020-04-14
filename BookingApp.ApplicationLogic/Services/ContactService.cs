using BookingApp.ApplicationLogic.Abstractions;
using BookingApp.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.ApplicationLogic.Services
{
    public class ContactService
    {
        private readonly IContactRepository contactRepository;
        public ContactService(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }
        public void AddMessage(Contact contact)
        {
            this.contactRepository.Add(contact);
        }
        public IEnumerable<Contact> GetAllMessages()
        {
            return this.contactRepository.GetAll();
        }
        public IEnumerable<Guid> GetAllMessagesIds()
        {
            return this.contactRepository.GetIds();
        }
        public bool DeleteMessage(Guid id)
        {
            var contact = this.contactRepository.GetContactById(id);
            return this.contactRepository.Delete(contact);
        }
    }
}
