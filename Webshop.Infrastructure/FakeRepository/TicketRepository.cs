using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SpaceTicket.Core.Entity;
using TicketShopApp.Core.DomainService;

namespace Webshop.Infrastructure.FakeRepository
{
    public class TicketRepository : ITicketRepository
    {
        readonly WebShopSpaceContext _WSSC;

        public TicketRepository(WebShopSpaceContext WSSC)
        {
            _WSSC = WSSC;
        }

        public Ticket CreateNewTicket(Ticket SpaceTicket)
        {
            var ticket = _WSSC.Ticket.Add(SpaceTicket).Entity;
            _WSSC.SaveChanges();
            return ticket;
        }

        public void DeleteTicket(int ID)
        {
            var removed = _WSSC.Remove(new Ticket { TicketId = ID }).Entity;
            _WSSC.SaveChanges();

        }

        public List<Ticket> ReadAllTicket()
        {
            return _WSSC.Ticket.ToList();
        }

        public Ticket ReadByID(int ID)
        {
            return _WSSC.Ticket
                .FirstOrDefault(o => o.TicketId == ID);
        }

        public Ticket UpdateTicket(Ticket UpdateTicket)
        {
            _WSSC.Attach(UpdateTicket).State = EntityState.Modified;
            _WSSC.SaveChanges();

            return UpdateTicket;
        }
    }
}
