using Moq;
using SpaceTicket.Core.Entity;
using System;
using System.IO;
using TicketShopApp.Core.ApplicationService;
using TicketShopApp.Core.ApplicationService.Service;
using TicketShopApp.Core.DomainService;
using Xunit;

namespace UserServiceTest
{
    public class UserServiceTest
    {
        [Fact]
        public void NoEmailAddressException()
        {
            var UserRepo = new Mock<IUserRepository>();
            IUserService service =
                new UserService(UserRepo.Object);
            User user = new User()
            {
                Admin = false,
                Passsword = "1234",
                UserId = 1,
                Username= "Jacob"
                

            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateNewUser(user));
            Assert.Equal("You need to write your email", ex.Message);
        }

        [Fact]
        public void NoPasswordException()
        {
            var UserRepo = new Mock<IUserRepository>();
            IUserService service =
                new UserService(UserRepo.Object);
            User user = new User()
            {
                Admin = false,
                EmailAddress = "test@test.dk",
                UserId = 1,
                Username = "Jacob"


            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateNewUser(user));
            Assert.Equal("you need to have a password", ex.Message);
        }
        [Fact]
        public void NoUserNameException()
        {
            var UserRepo = new Mock<IUserRepository>();
            IUserService service =
                new UserService(UserRepo.Object);
            User user = new User()
            {
                Admin = false,
               EmailAddress= "test@test.dk", 
                Passsword = "1234",
                UserId = 1


            };
            Exception ex = Assert.Throws<InvalidDataException>(() =>
                service.CreateNewUser(user));
            Assert.Equal("You Need to type a username", ex.Message);
        }


    }
}
