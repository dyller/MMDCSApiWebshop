using SpaceTicket.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Infrastructure.FakeRepository
{
    public static class FAKEDB
    {
        public static IEnumerable<Ticket> ticket;
        public static IEnumerable<User> users;

        public static void InitData()
        {
            ticket = new List<Ticket>();
            users = new List<User>();
        }
    }
}
