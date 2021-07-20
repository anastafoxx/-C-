using System;
using System.Data.Entity;

namespace Window25
{
    class AppContext : DbContext
    { public DbSet<User> Users { get; set; }
        public AppContext() : base("DefaultConnection")
        {

        }
    }
}
