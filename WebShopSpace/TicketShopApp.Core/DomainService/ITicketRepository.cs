using SpaceTicket.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketShopApp.Core.DomainService
{
   public interface ITicketRepository
    {
        Ticket CreateNewTicket(Ticket SpaceTicket);
        List<Ticket> ReadAllTicket();
        Ticket UpdateTicket(Ticket UpdateTicket);
        void DeleteTicket(int ID);
        Ticket ReadByID(int ID);
    }
}
