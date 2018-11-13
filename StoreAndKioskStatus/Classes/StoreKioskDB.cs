using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StoreAndKioskStatus.Classes
{
    public class StoreKioskDB : DbContext
    {
        public StoreKioskDB() : base("StoreKioskDB")
        {

        }
        public DbSet<Store> Store { get; set; }
        public DbSet<Kiosk> Kiosk { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
