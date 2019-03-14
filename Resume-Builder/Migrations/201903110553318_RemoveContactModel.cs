namespace Resume_Builder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveContactModel : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Contacts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        BId = c.Int(nullable: false, identity: true),
                        bname = c.String(),
                        bemail = c.String(),
                        bmobile = c.String(),
                        bsubject = c.String(),
                        bmessage = c.String(),
                    })
                .PrimaryKey(t => t.BId);
            
        }
    }
}
