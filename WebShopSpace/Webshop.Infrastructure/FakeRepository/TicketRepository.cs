using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceTicket.Core.Entity;
using TicketShopApp.Core.DomainService;

namespace Webshop.Infrastructure.FakeRepository
{
    public class TicketRepository : ITicketRepository
    {
        

        public Ticket CreateNewTicket(Ticket SpaceTicket)
        {
            var fakeList = FAKEDB.ticket.ToList();
            fakeList.Add(SpaceTicket);
            FAKEDB.ticket = fakeList;
           return SpaceTicket;
        }

        public void DeleteTicket(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ReadAllTicket()
        {
            return FAKEDB.ticket.ToList();
        }

        public Ticket ReadByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Ticket UpdateTicket(Ticket UpdateTicket)
        {
            throw new NotImplementedException();
        }
    }
}
