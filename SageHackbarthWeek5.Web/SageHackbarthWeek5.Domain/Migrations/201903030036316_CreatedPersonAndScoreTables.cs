namespace SageHackbarthWeek5.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedPersonAndScoreTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmplyeeId = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.EmplyeeId);
            
            CreateTable(
                "dbo.HighScores",
                c => new
                    {
                        HighScoreId = c.Guid(nullable: false),
                        PersonId = c.String(),
                        Score = c.String(),
                        DateAttained = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HighScoreId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.HighScores");
            DropTable("dbo.Employees");
        }
    }
}
