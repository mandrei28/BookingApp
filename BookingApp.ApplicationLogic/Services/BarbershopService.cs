using BookingApp.ApplicationLogic.Abstractions;
using BookingApp.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookingApp.ApplicationLogic.Services
{
    public class BarbershopService
    {
        private readonly IBarbershopRepository barbershopRepository;

        public BarbershopService(IBarbershopRepository barbershopRepository)
        {
            this.barbershopRepository = barbershopRepository;
        }
        public void AddBarbershop(Barbershop barbershop)
        {
            this.barbershopRepository.Add(barbershop);
        }
        public IEnumerable<Barbershop> GetAllBarbershops()
        {
            return this.barbershopRepository.GetAll();
        }
        public IEnumerable<Guid> GetAllBarbershopIds()
        {
            return this.barbershopRepository.GetIds();
        }
        public bool DeleteBarbershop(Guid id)
        {
            var barbershop = this.barbershopRepository.GetBarbershopById(id);
            return this.barbershopRepository.Delete(barbershop);
        }
        public Barbershop GetBarbershopById(Guid id)
        {
            return this.barbershopRepository.GetBarbershopById(id);
        }
        public Barbershop UpdateBarbershop(Barbershop barbershop)
        {
            var barbershopToUpdate = this.barbershopRepository.GetBarbershopById(barbershop.Id);
            if (!string.IsNullOrEmpty(barbershop.Name))
                barbershopToUpdate.Name = barbershop.Name;
            if (!string.IsNullOrEmpty(barbershop.ImgPath))
                barbershopToUpdate.ImgPath = barbershop.ImgPath;
            return this.barbershopRepository.Update(barbershopToUpdate);
        }
    }
}
