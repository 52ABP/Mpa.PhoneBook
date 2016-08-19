namespace YoYoCMS.PhoneBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_Person : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PbPhone", "Phone_Id", "dbo.PbPhone");
            DropIndex("dbo.PbPhone", new[] { "Phone_Id" });
            DropColumn("dbo.PbPhone", "Phone_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PbPhone", "Phone_Id", c => c.Long());
            CreateIndex("dbo.PbPhone", "Phone_Id");
            AddForeignKey("dbo.PbPhone", "Phone_Id", "dbo.PbPhone", "Id");
        }
    }
}
