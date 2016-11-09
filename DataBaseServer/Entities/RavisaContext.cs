using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataBaseServer.Entities {
    public class RavisaContext : DbContext {
        public RavisaContext () : base("name=Ravisa") {
            Database.SetInitializer<RavisaContext>(new CreateDatabaseIfNotExists<RavisaContext>());
            Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Empresa> Empresas { get; set; }
    }
}