
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTicket.Core.Entity
{
  public   class Ticket
    {
        public int TicketId { get; set; }
        public Double Distance { get; set; }
        public Double Price { get; set; }
        public int TicketLeft { get; set; }
        public int HowManyTicket { get; set; }
        public String planet { get; set; }
        public String Description { get; set; }
    }
}
