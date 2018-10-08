using Moq;
using SpaceTicket.Core.Entity;
using System;
using System.IO;
using TicketShopApp.Core.ApplicationService;
using TicketShopApp.Core.ApplicationService.Service;
using TicketShopApp.Core.DomainService;
using Xunit;

namespace TicketServiceTest
{
    public class UnitTest1
    {
        [Fact]
        public void PriceLessThan0Eception()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Price = 0,
                Description = "this is sparta",
                Distance = 55,
                HowManyTicket = 10,
                planet = "mars",
                TicketLeft = 3
                
            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateNewTicket(ticket));
            Assert.Equal("The price need to be higher than 0", ex.Message);
        }

        [Fact]
        public void PriceNullEception()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Description = "this is sparta",
                Distance = 55,
                HowManyTicket = 10,
                planet = "mars",
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateNewTicket(ticket));
            Assert.Equal("The price need to be higher than 0", ex.Message);
        }

        [Fact]
        public void DescriptionEmptyException()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Price = 100,
                Distance = 55,
                HowManyTicket = 10,
                planet = "mars",
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateNewTicket(ticket));
            Assert.Equal("You need to write some kind of description", ex.Message);
        }

        [Fact]
        public void DistanceToSmallException()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Price = 10,
                Description = "this is sparta",
                HowManyTicket = 10,
                planet = "mars",
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateNewTicket(ticket));
            Assert.Equal("The distance should be higher than 0", ex.Message);
        }
        

        [Fact]
        public void HowManyTicketException()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Price = 10,
                Description = "this is sparta",
                Distance = 55,
                HowManyTicket = 0,
                planet = "mars",
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateNewTicket(ticket));
            Assert.Equal("Should be more than 0 ticket avaible", ex.Message);
        }

        [Fact]
        public void NoPlanetEXception()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                
                Price = 10,
                Description = "this is sparta",
                Distance = 55,
                HowManyTicket = 10,
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateNewTicket(ticket));
            Assert.Equal("You need to choose to which planet", ex.Message);
        }

        [Fact]
        public void UpdateMinusTicket()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                planet = "Mars",
                Price = 10,
                Description = "this is sparta",
                Distance = 55,
                HowManyTicket = 10,
                TicketLeft = -1

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.UpdateTicket(ticket));
            Assert.Equal("Ticket number left need to be 0 or higher", ex.Message);
        }
        [Fact]
        public void PriceLessThan0EceptionUpdate()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Price = 0,
                Description = "this is sparta",
                Distance = 55,
                HowManyTicket = 10,
                planet = "mars",
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.UpdateTicket(ticket));
            Assert.Equal("The price need to be higher than 0", ex.Message);
        }

        [Fact]
        public void PriceNullEceptionUpdate()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Description = "this is sparta",
                Distance = 55,
                HowManyTicket = 10,
                planet = "mars",
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.UpdateTicket(ticket));
            Assert.Equal("The price need to be higher than 0", ex.Message);
        }

        [Fact]
        public void DescriptionEmptyExceptionUpdate()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Price = 100,
                Distance = 55,
                HowManyTicket = 10,
                planet = "mars",
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.UpdateTicket(ticket));
            Assert.Equal("You need to write some kind of description", ex.Message);
        }

        [Fact]
        public void DistanceToSmallExceptionUpdate()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Price = 10,
                Description = "this is sparta",
                HowManyTicket = 10,
                planet = "mars",
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.UpdateTicket(ticket));
            Assert.Equal("The distance should be higher than 0", ex.Message);
        }


        [Fact]
        public void HowManyTicketExceptionUpdate()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {
                Price = 10,
                Description = "this is sparta",
                Distance = 55,
                HowManyTicket = 0,
                planet = "mars",
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.UpdateTicket(ticket));
            Assert.Equal("Should be more than 0 ticket avaible", ex.Message);
        }

        [Fact]
        public void NoPlanetEXceptionUpdate()
        {
            var TicketRepo = new Mock<ITicketRepository>();
            ITicketService service =
                new TicketService(TicketRepo.Object);
            Ticket ticket = new Ticket()
            {

                Price = 10,
                Description = "this is sparta",
                Distance = 55,
                HowManyTicket = 10,
                TicketLeft = 3

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.UpdateTicket(ticket));
            Assert.Equal("You need to choose to which planet", ex.Message);
        }


    }
}
