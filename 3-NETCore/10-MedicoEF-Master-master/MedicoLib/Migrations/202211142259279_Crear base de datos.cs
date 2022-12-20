namespace MedicoLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Crearbasededatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Especialidad",
                c => new
                    {
                        EspecialidadId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.EspecialidadId);
            
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        MedicoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 20, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 20, unicode: false),
                        Matricula = c.String(nullable: false, maxLength: 4, fixedLength: true, unicode: false),
                        idEspecialidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicoId)
                .ForeignKey("dbo.Especialidad", t => t.idEspecialidad, cascadeDelete: true)
                .Index(t => t.idEspecialidad);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medico", "idEspecialidad", "dbo.Especialidad");
            DropIndex("dbo.Medico", new[] { "idEspecialidad" });
            DropTable("dbo.Medico");
            DropTable("dbo.Especialidad");
        }
    }
}
