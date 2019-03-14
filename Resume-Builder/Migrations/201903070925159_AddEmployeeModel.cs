namespace Resume_Builder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeEmail = c.String(),
                        EmployeePhone = c.String(),
                        EmployeeDOB = c.DateTime(nullable: false),
                        EmployeeLanguage = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
