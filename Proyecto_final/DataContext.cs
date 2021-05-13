using Proyecto_final.Entidades;
using System;
using System.Data.Entity;

namespace Proyecto_final
{
    public class DataContext:DbContext
    {
        public DbSet <Student> Students { get; set; }
        public DbSet <Coach> Coaches { get; set; }
        public DbSet <Adviser> Advisers { get; set; }
        public DbSet <Company>  Companies{ get; set; }
        public DbSet <Contact>  Contacts{ get; set; }
        public DbSet <Major>  Majors { get; set; }
        public DbSet <Coordinator> Coordinators { get; set; }
        public DataContext():base("name=miConexion")
        {
        }
    }
}
