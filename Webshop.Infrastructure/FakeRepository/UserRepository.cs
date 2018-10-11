using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SpaceTicket.Core.Entity;
using TicketShopApp.Core.DomainService;

namespace Webshop.Infrastructure.FakeRepository
{
    public class UserRepository : IUserRepository
    {
        readonly WebShopSpaceContext _WSSC;

        public UserRepository(WebShopSpaceContext WSSC)
        {
            _WSSC = WSSC;
        }
        public User CreateNewUser(User newUser)
        {
            var user = _WSSC.Users.Add(newUser).Entity;
            _WSSC.SaveChanges();
            return user;
        }

        public void DeleteUser(int UserId)
        {
            var removed = _WSSC.Remove(new User { UserId = UserId }).Entity;
            _WSSC.SaveChanges();
        }

        public User FindUserByID(int ID)
        {
            return _WSSC.Users
               .FirstOrDefault(o => o.UserId == ID);
        }

        public User FindUserByName(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> ReadAllUser()
        {
            return _WSSC.Users.ToList();
        }

        public User UpdateUser(User UpdateUser)
        {
            _WSSC.Attach(UpdateUser).State = EntityState.Modified;
            _WSSC.SaveChanges();

            return UpdateUser;
        }
    }
}
