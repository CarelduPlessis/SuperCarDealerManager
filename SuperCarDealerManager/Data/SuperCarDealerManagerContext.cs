using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperCarDealerManager.Models;

namespace SuperCarDealerManager.Data
{
    public class SuperCarDealerManagerContext : DbContext
    {
        public SuperCarDealerManagerContext (DbContextOptions<SuperCarDealerManagerContext> options)
            : base(options)
        {
        }

        public DbSet<SuperCarDealerManager.Models.Supplier> Supplier { get; set; }

        public DbSet<SuperCarDealerManager.Models.Car> Car { get; set; }

        public DbSet<SuperCarDealerManager.Models.Customer> Customer { get; set; }

        public DbSet<SuperCarDealerManager.Models.Store> Store { get; set; }
    }
}
