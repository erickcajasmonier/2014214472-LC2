namespace _2014214472_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asientos",
                c => new
                    {
                        AsientoId = c.Int(nullable: false, identity: true),
                        CinturonId = c.Int(nullable: false),
                        NumSerie = c.String(),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AsientoId)
                .ForeignKey("dbo.Carros", t => t.CarroId, cascadeDelete: true)
                .Index(t => t.CarroId);
            
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        CarroId = c.Int(nullable: false, identity: true),
                        VolanteId = c.Int(nullable: false),
                        PropietarioId = c.Int(nullable: false),
                        TipoCarro = c.Int(nullable: false),
                        EnsambladoraId = c.Int(nullable: false),
                        NumSerieChasis = c.String(nullable: false),
                        TipoAuto = c.Int(),
                        TipoBus = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Ensambladoras", t => t.EnsambladoraId, cascadeDelete: true)
                .ForeignKey("dbo.Propietarios", t => t.PropietarioId, cascadeDelete: true)
                .Index(t => t.PropietarioId)
                .Index(t => t.EnsambladoraId);
            
            CreateTable(
                "dbo.Ensambladoras",
                c => new
                    {
                        EnsambladoraId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EnsambladoraId);
            
            CreateTable(
                "dbo.Llantas",
                c => new
                    {
                        LlantaId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LlantaId)
                .ForeignKey("dbo.Carros", t => t.CarroId, cascadeDelete: true)
                .Index(t => t.CarroId);
            
            CreateTable(
                "dbo.Parabrisas",
                c => new
                    {
                        ParabrisasId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ParabrisasId)
                .ForeignKey("dbo.Carros", t => t.CarroId, cascadeDelete: true)
                .Index(t => t.CarroId);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        PropietarioId = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        LicenciaConducir = c.String(),
                    })
                .PrimaryKey(t => t.PropietarioId);
            
            CreateTable(
                "dbo.Volantes",
                c => new
                    {
                        VolanteId = c.Int(nullable: false),
                        NumSerie = c.String(),
                        CarroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VolanteId)
                .ForeignKey("dbo.Carros", t => t.VolanteId)
                .Index(t => t.VolanteId);
            
            CreateTable(
                "dbo.Cinturones",
                c => new
                    {
                        CinturonId = c.Int(nullable: false),
                        NumSerie = c.String(),
                        Metraje = c.Int(nullable: false),
                        AsientoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinturonId)
                .ForeignKey("dbo.Asientos", t => t.CinturonId)
                .Index(t => t.CinturonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cinturones", "CinturonId", "dbo.Asientos");
            DropForeignKey("dbo.Volantes", "VolanteId", "dbo.Carros");
            DropForeignKey("dbo.Carros", "PropietarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Parabrisas", "CarroId", "dbo.Carros");
            DropForeignKey("dbo.Llantas", "CarroId", "dbo.Carros");
            DropForeignKey("dbo.Carros", "EnsambladoraId", "dbo.Ensambladoras");
            DropForeignKey("dbo.Asientos", "CarroId", "dbo.Carros");
            DropIndex("dbo.Cinturones", new[] { "CinturonId" });
            DropIndex("dbo.Volantes", new[] { "VolanteId" });
            DropIndex("dbo.Parabrisas", new[] { "CarroId" });
            DropIndex("dbo.Llantas", new[] { "CarroId" });
            DropIndex("dbo.Carros", new[] { "EnsambladoraId" });
            DropIndex("dbo.Carros", new[] { "PropietarioId" });
            DropIndex("dbo.Asientos", new[] { "CarroId" });
            DropTable("dbo.Cinturones");
            DropTable("dbo.Volantes");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Parabrisas");
            DropTable("dbo.Llantas");
            DropTable("dbo.Ensambladoras");
            DropTable("dbo.Carros");
            DropTable("dbo.Asientos");
        }
    }
}
