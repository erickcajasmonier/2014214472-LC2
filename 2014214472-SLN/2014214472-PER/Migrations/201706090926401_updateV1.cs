namespace _2014214472_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        CarroId = c.Int(nullable: false, identity: true),
                        NumSerieMotor = c.String(nullable: false),
                        NumSerieChasis = c.String(nullable: false),
                        PropietarioId = c.Int(nullable: false),
                        ParabrisasId = c.Int(nullable: false),
                        VolanteId = c.Int(nullable: false),
                        TipoCarro = c.Int(nullable: false),
                        AsientoId = c.Int(nullable: false),
                        LlantaId = c.Int(nullable: false),
                        EnsambladoraId = c.Int(nullable: false),
                        TipoAuto = c.Int(),
                        TipoBus = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Asientos", t => t.AsientoId, cascadeDelete: true)
                .ForeignKey("dbo.Ensambladora", t => t.EnsambladoraId, cascadeDelete: true)
                .ForeignKey("dbo.Llantas", t => t.LlantaId, cascadeDelete: true)
                .ForeignKey("dbo.Parabrisas", t => t.ParabrisasId, cascadeDelete: true)
                .ForeignKey("dbo.Propietarios", t => t.PropietarioId, cascadeDelete: true)
                .ForeignKey("dbo.Volantes", t => t.VolanteId, cascadeDelete: true)
                .Index(t => t.PropietarioId)
                .Index(t => t.ParabrisasId)
                .Index(t => t.VolanteId)
                .Index(t => t.AsientoId)
                .Index(t => t.LlantaId)
                .Index(t => t.EnsambladoraId);
            
            CreateTable(
                "dbo.Asientos",
                c => new
                    {
                        AsientoId = c.Int(nullable: false, identity: true),
                        NumSerieAsiento = c.String(nullable: false, maxLength: 10),
                        CinturonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AsientoId)
                .ForeignKey("dbo.Cinturones", t => t.CinturonId, cascadeDelete: true)
                .Index(t => t.CinturonId);
            
            CreateTable(
                "dbo.Cinturones",
                c => new
                    {
                        CinturonId = c.Int(nullable: false, identity: true),
                        NumSerieCinturon = c.String(nullable: false, maxLength: 10),
                        Metraje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinturonId);
            
            CreateTable(
                "dbo.Ensambladora",
                c => new
                    {
                        EnsambladoraId = c.Int(nullable: false, identity: true),
                        _Ensambladora = c.String(),
                        TipoCarro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnsambladoraId);
            
            CreateTable(
                "dbo.Llantas",
                c => new
                    {
                        LlantaId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.LlantaId);
            
            CreateTable(
                "dbo.Parabrisas",
                c => new
                    {
                        ParabrisasId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.ParabrisasId);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        PropietarioId = c.Int(nullable: false, identity: true),
                        DNI = c.String(nullable: false, maxLength: 8),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        LicenciaConducir = c.String(nullable: false, maxLength: 9),
                    })
                .PrimaryKey(t => t.PropietarioId);
            
            CreateTable(
                "dbo.Volantes",
                c => new
                    {
                        VolanteId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.VolanteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carros", "VolanteId", "dbo.Volantes");
            DropForeignKey("dbo.Carros", "PropietarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Carros", "ParabrisasId", "dbo.Parabrisas");
            DropForeignKey("dbo.Carros", "LlantaId", "dbo.Llantas");
            DropForeignKey("dbo.Carros", "EnsambladoraId", "dbo.Ensambladora");
            DropForeignKey("dbo.Carros", "AsientoId", "dbo.Asientos");
            DropForeignKey("dbo.Asientos", "CinturonId", "dbo.Cinturones");
            DropIndex("dbo.Asientos", new[] { "CinturonId" });
            DropIndex("dbo.Carros", new[] { "EnsambladoraId" });
            DropIndex("dbo.Carros", new[] { "LlantaId" });
            DropIndex("dbo.Carros", new[] { "AsientoId" });
            DropIndex("dbo.Carros", new[] { "VolanteId" });
            DropIndex("dbo.Carros", new[] { "ParabrisasId" });
            DropIndex("dbo.Carros", new[] { "PropietarioId" });
            DropTable("dbo.Volantes");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Parabrisas");
            DropTable("dbo.Llantas");
            DropTable("dbo.Ensambladora");
            DropTable("dbo.Cinturones");
            DropTable("dbo.Asientos");
            DropTable("dbo.Carros");
        }
    }
}
