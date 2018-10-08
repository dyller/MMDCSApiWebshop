using System;

namespace SpaceTicket.Core.Entity
{
  public  class Ticket
    {
        public int TicketID { get; set; }
        public double TicketPrice { get; set; }
        public DateTime TravelDate { get; set; }
        public DateTime TravelTime { get; set; }
        public double TravelDistance { get; set; }
        public String PictureURL { get; set; }
        public int TicketLeft { get; set; }
        public int TotalTicket { get; set; }


    }
}
