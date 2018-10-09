using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Infrastructure
{
  public   class DBInit
    {
        public static void SeedDB(WebShopSpaceContext ctx)
        {
            ctx.Database.EnsureCreated();
            ctx.SaveChanges();

        }
    }
}
