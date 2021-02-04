using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PryUserSaucedoLESP.Models
{
    public class DataContext:DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PryUserSaucedoLESP.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<PryUserSaucedoLESP.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<PryUserSaucedoLESP.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<PryUserSaucedoLESP.Models.Geography> Geographies { get; set; }
    }


}