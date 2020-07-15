using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DnovaxContext : DbContext
    {

        public DnovaxContext() : base("DNovaxEnterprise")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
