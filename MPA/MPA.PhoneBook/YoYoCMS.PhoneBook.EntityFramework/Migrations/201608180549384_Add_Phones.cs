namespace YoYoCMS.PhoneBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Phones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PbPhone",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        Type = c.Byte(nullable: false),
                        Number = c.String(nullable: false, maxLength: 16),
                        CreationTime = c.DateTime(nullable: false),
                        CreatorUserId = c.Long(),
                        Phone_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Basic.Person", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.PbPhone", t => t.Phone_Id)
                .Index(t => t.PersonId)
                .Index(t => t.Phone_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PbPhone", "Phone_Id", "dbo.PbPhone");
            DropForeignKey("dbo.PbPhone", "PersonId", "Basic.Person");
            DropIndex("dbo.PbPhone", new[] { "Phone_Id" });
            DropIndex("dbo.PbPhone", new[] { "PersonId" });
            DropTable("dbo.PbPhone");
        }
    }
}
