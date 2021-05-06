using Proyecto_final.Entidades;
using System.Data.Entity;

namespace Proyecto_final
{
    public class DataContext : DbContext
    {
        public DbSet <Student> Students { get; set; }
        public DbSet <Company> Companies { get; set; }
        public DbSet <Contact> Contacts { get; set; }

        public DataContext():base("name=miConexion")
        {
        }

    }
}
