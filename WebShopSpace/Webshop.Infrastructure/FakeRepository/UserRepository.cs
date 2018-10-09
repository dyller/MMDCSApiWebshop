using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceTicket.Core.Entity;
using TicketShopApp.Core.DomainService;

namespace Webshop.Infrastructure.FakeRepository
{
    public class UserRepository : IUserRepository
    {
        public User CreateNewUser(User newUser)
        {
            var fakeList = FAKEDB.users.ToList();
            fakeList.Add(newUser);
            FAKEDB.users = fakeList;
            return newUser;
        }

        public void DeleteUser(int UserId)
        {
            var fakeList = FAKEDB.users.ToList();
            foreach (var item in FAKEDB.users)
            {
                if (item.UserId == UserId)
                {
                    fakeList.Remove(item);
                    FAKEDB.users = fakeList;
                    break;
                }
            }
        }

        public User FindUserByID(int ID)
        {
            foreach (var item in FAKEDB.users)
            {
                if (item.UserId == ID)
                {
                    return item;
                }

            }
            return null;
        }

        public User FindUserByName(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> ReadAllUser()
        {
            return FAKEDB.users.ToList(); 
        }

        public User UpdateUser(User UpdateUser)
        {
            throw new NotImplementedException();
        }
    }
}
