using SpaceTicket.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketShopApp.Core.DomainService
{
   public  interface IUserRepository
    {

        User CreateNewUser(User newUser);
        List<User> ReadAllUser();
        User FindUserByID(int ID);
        User FindUserByName(User user);
        User UpdateUser(User UpdateUser);
        void DeleteUser(int UserId);
    }
}
