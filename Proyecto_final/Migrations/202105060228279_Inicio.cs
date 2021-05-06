namespace Proyecto_final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        birthdate = c.String(nullable: false, maxLength: 30),
                        phonenumber = c.String(nullable: false, maxLength: 30),
                        cellphonenumber = c.String(nullable: false, maxLength: 30),
                        email = c.String(nullable: false, maxLength: 30),
                        Photo = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
