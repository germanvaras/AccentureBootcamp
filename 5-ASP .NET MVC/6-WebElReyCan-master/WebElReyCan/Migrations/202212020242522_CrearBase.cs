namespace WebElReyCan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        TurnoId = c.Int(nullable: false, identity: true),
                        NombreMascota = c.String(nullable: false, maxLength: 50, unicode: false),
                        Raza = c.String(maxLength: 50, unicode: false),
                        Edad = c.Int(nullable: false),
                        NombreDueño = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaIngreso = c.DateTime(nullable: false),
                        Celular = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.TurnoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Turno");
        }
    }
}
