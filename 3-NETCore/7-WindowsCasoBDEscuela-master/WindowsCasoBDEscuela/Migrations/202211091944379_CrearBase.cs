namespace WindowsCasoBDEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carrera",
                c => new
                    {
                        CarreraId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.CarreraId);
            
            CreateTable(
                "dbo.Plan",
                c => new
                    {
                        PlanId = c.Int(nullable: false, identity: true),
                        CarreraId = c.Int(nullable: false),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.PlanId)
                .ForeignKey("dbo.Carrera", t => t.CarreraId, cascadeDelete: true)
                .Index(t => t.CarreraId);
            
            CreateTable(
                "dbo.PLanilla",
                c => new
                    {
                        PlanillaId = c.Int(nullable: false, identity: true),
                        CarreraId = c.Int(nullable: false),
                        MateriaId = c.Int(nullable: false),
                        ProfesorId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PlanillaId)
                .ForeignKey("dbo.Carrera", t => t.CarreraId, cascadeDelete: true)
                .ForeignKey("dbo.Curso", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Profesor", t => t.ProfesorId, cascadeDelete: true)
                .ForeignKey("dbo.Materia", t => t.MateriaId, cascadeDelete: true)
                .Index(t => t.CarreraId)
                .Index(t => t.MateriaId)
                .Index(t => t.ProfesorId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Curso",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.CursoId);
            
            CreateTable(
                "dbo.Detalle",
                c => new
                    {
                        DetalleId = c.Int(nullable: false, identity: true),
                        PlanillaId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleId)
                .ForeignKey("dbo.Estado", t => t.EstadoId, cascadeDelete: true)
                .ForeignKey("dbo.PLanilla", t => t.PlanillaId, cascadeDelete: true)
                .Index(t => t.PlanillaId)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        EstadoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.EstadoId);
            
            CreateTable(
                "dbo.Evaluacion",
                c => new
                    {
                        EvaluacionId = c.Int(nullable: false, identity: true),
                        TipoId = c.Int(nullable: false),
                        EstudianteId = c.Int(nullable: false),
                        DetalleId = c.Int(nullable: false),
                        Nota = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EvaluacionId)
                .ForeignKey("dbo.Detalle", t => t.DetalleId, cascadeDelete: true)
                .ForeignKey("dbo.Estudiante", t => t.EstudianteId, cascadeDelete: true)
                .ForeignKey("dbo.Tipo", t => t.TipoId, cascadeDelete: true)
                .Index(t => t.TipoId)
                .Index(t => t.EstudianteId)
                .Index(t => t.DetalleId);
            
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        EstudianteId = c.Int(nullable: false, identity: true),
                        LocalidadId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Calle = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstudianteId)
                .ForeignKey("dbo.Localidad", t => t.LocalidadId, cascadeDelete: true)
                .Index(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        LocalidadId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Profesor",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        LocalidadId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.ProfesorId)
                .ForeignKey("dbo.Localidad", t => t.LocalidadId, cascadeDelete: false)
                .Index(t => t.LocalidadId);
            
            CreateTable(
                "dbo.Tipo",
                c => new
                    {
                        TipoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.TipoId);
            
            CreateTable(
                "dbo.Materia",
                c => new
                    {
                        MateriaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.MateriaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PLanilla", "MateriaId", "dbo.Materia");
            DropForeignKey("dbo.Detalle", "PlanillaId", "dbo.PLanilla");
            DropForeignKey("dbo.Evaluacion", "TipoId", "dbo.Tipo");
            DropForeignKey("dbo.PLanilla", "ProfesorId", "dbo.Profesor");
            DropForeignKey("dbo.Profesor", "LocalidadId", "dbo.Localidad");
            DropForeignKey("dbo.Estudiante", "LocalidadId", "dbo.Localidad");
            DropForeignKey("dbo.Evaluacion", "EstudianteId", "dbo.Estudiante");
            DropForeignKey("dbo.Evaluacion", "DetalleId", "dbo.Detalle");
            DropForeignKey("dbo.Detalle", "EstadoId", "dbo.Estado");
            DropForeignKey("dbo.PLanilla", "CursoId", "dbo.Curso");
            DropForeignKey("dbo.PLanilla", "CarreraId", "dbo.Carrera");
            DropForeignKey("dbo.Plan", "CarreraId", "dbo.Carrera");
            DropIndex("dbo.Profesor", new[] { "LocalidadId" });
            DropIndex("dbo.Estudiante", new[] { "LocalidadId" });
            DropIndex("dbo.Evaluacion", new[] { "DetalleId" });
            DropIndex("dbo.Evaluacion", new[] { "EstudianteId" });
            DropIndex("dbo.Evaluacion", new[] { "TipoId" });
            DropIndex("dbo.Detalle", new[] { "EstadoId" });
            DropIndex("dbo.Detalle", new[] { "PlanillaId" });
            DropIndex("dbo.PLanilla", new[] { "CursoId" });
            DropIndex("dbo.PLanilla", new[] { "ProfesorId" });
            DropIndex("dbo.PLanilla", new[] { "MateriaId" });
            DropIndex("dbo.PLanilla", new[] { "CarreraId" });
            DropIndex("dbo.Plan", new[] { "CarreraId" });
            DropTable("dbo.Materia");
            DropTable("dbo.Tipo");
            DropTable("dbo.Profesor");
            DropTable("dbo.Localidad");
            DropTable("dbo.Estudiante");
            DropTable("dbo.Evaluacion");
            DropTable("dbo.Estado");
            DropTable("dbo.Detalle");
            DropTable("dbo.Curso");
            DropTable("dbo.PLanilla");
            DropTable("dbo.Plan");
            DropTable("dbo.Carrera");
        }
    }
}
