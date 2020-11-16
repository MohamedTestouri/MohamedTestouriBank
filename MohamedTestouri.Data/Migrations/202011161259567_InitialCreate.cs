namespace MohamedTestouri.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agences",
                c => new
                    {
                        AgenceId = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        NombreEmploye = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AgenceId);
            
            CreateTable(
                "dbo.Comptes",
                c => new
                    {
                        CompteId = c.Int(nullable: false, identity: true),
                        RIB = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        CarteBancaire = c.Int(),
                        Agence_CompteId = c.Int(),
                        Agences_AgenceId = c.Int(),
                        Client_UserId = c.Int(),
                    })
                .PrimaryKey(t => t.CompteId)
                .ForeignKey("dbo.Comptes", t => t.Agence_CompteId)
                .ForeignKey("dbo.Agences", t => t.Agences_AgenceId)
                .ForeignKey("dbo.Client", t => t.Client_UserId)
                .Index(t => t.Agence_CompteId)
                .Index(t => t.Agences_AgenceId)
                .Index(t => t.Client_UserId);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Nom = c.String(),
                        Prenom = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Credits",
                c => new
                    {
                        CreditId = c.Int(nullable: false, identity: true),
                        Somme = c.Single(nullable: false),
                        DateCredit = c.DateTime(nullable: false),
                        TauxInteret = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.CreditId);
            
            CreateTable(
                "dbo.CreditComptes",
                c => new
                    {
                        Credit_CreditId = c.Int(nullable: false),
                        Compte_CompteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Credit_CreditId, t.Compte_CompteId })
                .ForeignKey("dbo.Credits", t => t.Credit_CreditId, cascadeDelete: true)
                .ForeignKey("dbo.Comptes", t => t.Compte_CompteId, cascadeDelete: true)
                .Index(t => t.Credit_CreditId)
                .Index(t => t.Compte_CompteId);
            
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Nom = c.String(),
                        Prenom = c.String(),
                        ClientId = c.Int(nullable: false),
                        Adresse_Ville = c.String(),
                        Adresse_rue = c.String(),
                        Adresse_CodePostale = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.ChefAgence",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Matricule = c.Int(nullable: false),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CreditComptes", "Compte_CompteId", "dbo.Comptes");
            DropForeignKey("dbo.CreditComptes", "Credit_CreditId", "dbo.Credits");
            DropForeignKey("dbo.Comptes", "Client_UserId", "dbo.Client");
            DropForeignKey("dbo.Comptes", "Agences_AgenceId", "dbo.Agences");
            DropForeignKey("dbo.Comptes", "Agence_CompteId", "dbo.Comptes");
            DropIndex("dbo.CreditComptes", new[] { "Compte_CompteId" });
            DropIndex("dbo.CreditComptes", new[] { "Credit_CreditId" });
            DropIndex("dbo.Comptes", new[] { "Client_UserId" });
            DropIndex("dbo.Comptes", new[] { "Agences_AgenceId" });
            DropIndex("dbo.Comptes", new[] { "Agence_CompteId" });
            DropTable("dbo.ChefAgence");
            DropTable("dbo.Client");
            DropTable("dbo.CreditComptes");
            DropTable("dbo.Credits");
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.Comptes");
            DropTable("dbo.Agences");
        }
    }
}
