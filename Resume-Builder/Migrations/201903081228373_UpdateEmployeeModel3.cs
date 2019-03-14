namespace Resume_Builder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeModel3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "EmployeeLanguage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "EmployeeLanguage", c => c.String());
        }
    }
}
