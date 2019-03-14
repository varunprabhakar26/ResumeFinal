namespace Resume_Builder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeDesignation", c => c.String());
            AddColumn("dbo.Employees", "EmployeeSkill", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployeeSkill");
            DropColumn("dbo.Employees", "EmployeeDesignation");
        }
    }
}
