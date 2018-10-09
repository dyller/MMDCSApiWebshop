using SpaceTicket.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicketShopApp.Core.ApplicationService
{
   public  interface IUserService
    {
        
        User CreateNewUser(User newUser);
        List<User> ReadAllUser();
        User FindUserByName(User user);
        User FindUserByID(int ID);
        User UpdateUser(User UpdateUser);
        void DeleteUser(int UserId);
    }
}
