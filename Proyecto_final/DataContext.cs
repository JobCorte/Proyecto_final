using Proyecto_final.Entidades;
using System;
using System.Data.Entity;

namespace Proyecto_final
{
    public class DataContext : DbContext
    {
        public DbSet <Student> Students { get; set; }
        public DbSet <Company> Companies { get; set; }
        public DbSet <Contact> Contacts { get; set; }
        public DbSet <Contact> Coordinator { get; set; }
        public DbSet <Contact> Major { get; set; }

        public DataContext():base("name=miConexion")
        {
        }

        internal object Entry<T>(object coordinator)
        {
            throw new NotImplementedException();
        }
    }
}
