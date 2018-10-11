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
        User FindUserByName(String user);
        User UpdateUser(String UpdateUser);
        void DeleteUser(int UserId);
        User UpdateUser(User updateUser);
    }
}
