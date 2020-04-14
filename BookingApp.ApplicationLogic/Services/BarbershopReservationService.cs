using BookingApp.ApplicationLogic.Abstractions;
using BookingApp.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApp.ApplicationLogic.Services
{
    public class BarbershopReservationService
    {
        private readonly IBarbershopReservationRepository barbershopReservationRepository;
        public BarbershopReservationService(IBarbershopReservationRepository barbershopReservationRepository)
        {
            this.barbershopReservationRepository = barbershopReservationRepository;
        }
        public void AddReservation(BarbershopReservation barbershopReservation)
        {
            this.barbershopReservationRepository.Add(barbershopReservation);
        }

    }
}
