using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SpaceTicket.Core.Entity;
using TicketShopApp.Core.DomainService;

namespace TicketShopApp.Core.ApplicationService.Service
{
    public class TicketService : ITicketService
    {
        readonly ITicketRepository _TicketRepository;

        public TicketService(ITicketRepository TicketRepository)
        {
            _TicketRepository = TicketRepository;
        }

        public Ticket CreateNewTicket(Ticket SpaceTicket)
        {
            if (SpaceTicket.Price <= 0)
            {
                throw new InvalidDataException("The price need to be higher than 0");
            }
            if (SpaceTicket.Description == null)
            {
                throw new InvalidDataException("You need to write some kind of description");
            }
            if (SpaceTicket.Distance <= 0)
            {
                throw new InvalidDataException("The distance should be higher than 0");
            }
            if (SpaceTicket.HowManyTicket <= 0)
            {
                throw new InvalidDataException("Should be more than 0 ticket avaible");
            }
            if (SpaceTicket.planet ==null)
            {
                throw new InvalidDataException("You need to choose to which planet");
            }

            return _TicketRepository.CreateNewTicket(SpaceTicket) ;
        }

        public void DeleteTicket(int ID)
        {
            _TicketRepository.DeleteTicket(ID);
        }

        public List<Ticket> ReadAllTicket()
        {
            return _TicketRepository.ReadAllTicket();
        }

        public Ticket ReadByID(int ID)
        {
            return _TicketRepository.ReadByID(ID);
        }

        public Ticket UpdateTicket(Ticket UpdateTicket)
        {
            if (UpdateTicket.Price <= 0)
            {
                throw new InvalidDataException("The price need to be higher than 0");
            }
            if (UpdateTicket.Description == null)
            {
                throw new InvalidDataException("You need to write some kind of description");
            }
            if (UpdateTicket.Distance <= 0)
            {
                throw new InvalidDataException("The distance should be higher than 0");
            }
            if (UpdateTicket.HowManyTicket <= 0)
            {
                throw new InvalidDataException("Should be more than 0 ticket avaible");
            }
            if (UpdateTicket.planet == null)
            {
                throw new InvalidDataException("You need to choose to which planet");
            }
            if (UpdateTicket.TicketLeft < 0)
            {
                throw new InvalidDataException("Ticket number left need to be 0 or higher");
            }
            return null;
        }
    }
}
