namespace Libreria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clasificacion",
                c => new
                    {
                        ClasificacionId = c.Int(nullable: false, identity: true),
                        Tipo = c.String(nullable: false, maxLength: 15, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.ClasificacionId);
            
            CreateTable(
                "dbo.Generoes",
                c => new
                    {
                        GeneroId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.GeneroId);
            
            CreateTable(
                "dbo.Pelicula",
                c => new
                    {
                        PeliculaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 25, unicode: false),
                        FechaEstrena = c.DateTime(nullable: false),
                        CantidadMinutos = c.Int(nullable: false),
                        Idioma = c.String(nullable: false, maxLength: 25, unicode: false),
                        Sinopsis = c.String(nullable: false, maxLength: 50, unicode: false),
                        ClasificacionId = c.Int(nullable: false),
                        GeneroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PeliculaId)
                .ForeignKey("dbo.Clasificacion", t => t.ClasificacionId, cascadeDelete: true)
                .ForeignKey("dbo.Generoes", t => t.GeneroId, cascadeDelete: true)
                .Index(t => t.ClasificacionId)
                .Index(t => t.GeneroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pelicula", "GeneroId", "dbo.Generoes");
            DropForeignKey("dbo.Pelicula", "ClasificacionId", "dbo.Clasificacion");
            DropIndex("dbo.Pelicula", new[] { "GeneroId" });
            DropIndex("dbo.Pelicula", new[] { "ClasificacionId" });
            DropTable("dbo.Pelicula");
            DropTable("dbo.Generoes");
            DropTable("dbo.Clasificacion");
        }
    }
}
