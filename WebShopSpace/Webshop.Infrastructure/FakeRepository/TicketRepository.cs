using System;
using System.Collections.Generic;
using System.Text;
using SpaceTicket.Core.Entity;
using TicketShopApp.Core.DomainService;

namespace Webshop.Infrastructure.FakeRepository
{
    public class TicketRepository : ITicketRepository
    {
        public Ticket CreateNewTicket(Ticket SpaceTicket)
        {
            throw new NotImplementedException();
        }

        public void DeleteTicket(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Ticket> ReadAllTicket()
        {
            List<Ticket> testRead = new List<Ticket>();
            testRead.Add(new Ticket()
            {

                Description = "hey",
                Distance = 55,
                HowManyTicket = 22,
                planet = "mars",
                Price = 55,
                TicketId = 2,
                TicketLeft = 1

            });
            return testRead;
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
