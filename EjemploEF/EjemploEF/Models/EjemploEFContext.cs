using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EjemploEF.Models
{
    public class EjemploEFContext : DbContext
    {
        public EjemploEFContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<EjemploEF.Models.City> Cities { get; set; }
    }
}