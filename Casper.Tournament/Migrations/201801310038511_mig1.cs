namespace Casper.Tournament.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Team_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teams", t => t.Team_ID)
                .Index(t => t.Team_ID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tournament_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_ID)
                .Index(t => t.Tournament_ID);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        NumberOfTeams = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Tournament_ID", "dbo.Tournaments");
            DropForeignKey("dbo.Players", "Team_ID", "dbo.Teams");
            DropIndex("dbo.Teams", new[] { "Tournament_ID" });
            DropIndex("dbo.Players", new[] { "Team_ID" });
            DropTable("dbo.Tournaments");
            DropTable("dbo.Teams");
            DropTable("dbo.Players");
        }
    }
}
