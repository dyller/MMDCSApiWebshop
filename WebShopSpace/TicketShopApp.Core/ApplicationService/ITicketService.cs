using System;
using System.Collections.Generic;
using System.Text;
using SpaceTicket.Core.Entity;

namespace TicketShopApp.Core.ApplicationService
{
    interface ITicketService
    {
        
        Ticket CreateNewTicket(Ticket SpaceTicket);
        List<Ticket> ReadAllTicket();
        Ticket UpdateTicket(Ticket UpdateTicket);
        void DeleteTicket(int ID);
        Ticket ReadByID(int ID);
    }
}
