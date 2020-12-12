using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalPorga.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConection")
        {

        }

        public System.Data.Entity.DbSet<FinalPorga.Models.OP> OPs { get; set; }
    }
}