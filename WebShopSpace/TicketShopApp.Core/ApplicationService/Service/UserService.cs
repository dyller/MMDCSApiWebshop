using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SpaceTicket.Core.Entity;
using TicketShopApp.Core.DomainService;

namespace TicketShopApp.Core.ApplicationService.Service
{
   public  class UserService : IUserService
    {
        readonly IUserRepository _UserRepository;

        public UserService(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public User CreateNewUser(User newUser)
        {
           
            if (newUser.EmailAddress == null)
            { throw new InvalidDataException("You need to write your email"); }
            if (newUser.Passsword == null)
            { throw new InvalidDataException("you need to have a password"); }
            if (newUser.Username == null)
            { throw new InvalidDataException("You Need to type a username"); }
            return _UserRepository.CreateNewUser(newUser); 
        }

        public void DeleteUser(int UserId)
        {
            _UserRepository.DeleteUser(UserId); ;
        }

        public User FindUserByID(int ID)
        {
            return _UserRepository.FindUserByID(ID);
        }

        public User FindUserByName(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> ReadAllUser()
        {
            return _UserRepository.ReadAllUser();
        }

        public User UpdateUser(User UpdateUser)
        {
            throw new NotImplementedException();
        }
    }
}
