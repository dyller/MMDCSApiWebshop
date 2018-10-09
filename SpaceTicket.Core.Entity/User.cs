using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTicket.Core.Entity
{
   public class User
    {
        public int UserId { get; set; }
        public Boolean Admin { get; set; }
        public String Username { get; set; }
        public String Passsword { get; set; }
        public String EmailAddress { get; set; }
    }
}
