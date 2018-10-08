using System;

namespace SpaceTicket.Core.Entity
{
    class SpaceTicket
    {
        public double TicketPrice { get; set; }
        public DateTime TravelDate { get; set; }
        public DateTime TravelTime { get; set; }
        public double TravelDistance { get; set; }
        public String PictureURL { get; set; }
        public int TicketLeft { get; set; }
        public int TotalTicket { get; set; }


    }
}
