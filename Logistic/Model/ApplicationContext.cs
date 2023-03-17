using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Logistic.Model
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Agent>?Agents { get; set; }

        public ApplicationContext() : base("DefaultConnection") { }
        //public ApplicationContext() : base("DefaultConnection") { }
    }
}
