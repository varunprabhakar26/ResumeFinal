namespace Resume_Builder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Education", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Education");
        }
    }
}
