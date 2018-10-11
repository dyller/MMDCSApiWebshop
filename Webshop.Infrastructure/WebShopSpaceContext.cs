using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SpaceTicket.Core.Entity;

namespace Webshop.Infrastructure
{
   public  class WebShopSpaceContext: DbContext
    {
        public WebShopSpaceContext(DbContextOptions<WebShopSpaceContext> opt) : base(opt)
        {

        }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User> Kage { get; set; }
    }


}

