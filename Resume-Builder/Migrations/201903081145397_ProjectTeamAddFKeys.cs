namespace Resume_Builder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectTeamAddFKeys : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProjectTeams", "EmployeeId", c => c.Int(nullable: false));
            AddColumn("dbo.ProjectTeams", "ProjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProjectTeams", "EmployeeId");
            CreateIndex("dbo.ProjectTeams", "ProjectId");
            AddForeignKey("dbo.ProjectTeams", "EmployeeId", "dbo.Employees", "EmployeeId", cascadeDelete: true);
            AddForeignKey("dbo.ProjectTeams", "ProjectId", "dbo.Projects", "ProjectId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectTeams", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ProjectTeams", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.ProjectTeams", new[] { "ProjectId" });
            DropIndex("dbo.ProjectTeams", new[] { "EmployeeId" });
            DropColumn("dbo.ProjectTeams", "ProjectId");
            DropColumn("dbo.ProjectTeams", "EmployeeId");
        }
    }
}
