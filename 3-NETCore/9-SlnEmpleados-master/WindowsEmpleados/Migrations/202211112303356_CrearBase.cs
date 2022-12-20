namespace WindowsEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 2, unicode: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 2, unicode: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Legajo = c.Int(nullable: false),
                        IdDepartamento = c.String(maxLength: 2, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.IdDepartamento)
                .Index(t => t.IdDepartamento);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Empleado", "IdDepartamento", "dbo.Departamento");
            DropIndex("dbo.Empleado", new[] { "IdDepartamento" });
            DropTable("dbo.Empleado");
            DropTable("dbo.Departamento");
        }
    }
}
