namespace Resume_Builder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Project : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ProjectTitle = c.String(),
                        ProjectDescription = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
        }
    }
}
