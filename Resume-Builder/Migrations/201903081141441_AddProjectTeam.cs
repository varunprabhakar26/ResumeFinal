namespace Resume_Builder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectTeam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProjectTeams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                        EmployeeTech = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProjectTeams");
        }
    }
}
