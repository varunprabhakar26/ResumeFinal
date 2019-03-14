namespace Resume_Builder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployeeModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeAddress", c => c.String());
            DropColumn("dbo.Employees", "Education");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Education", c => c.String());
            DropColumn("dbo.Employees", "EmployeeAddress");
        }
    }
}
