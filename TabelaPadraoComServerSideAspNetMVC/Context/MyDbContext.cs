using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TabelaPadraoComServerSideAspNetMVC.Models;

namespace TabelaPadraoComServerSideAspNetMVC.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            :base("defaultConnectionString")
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        public DbSet<EntityTest> EntitiesTest { get; set; }
    }
}