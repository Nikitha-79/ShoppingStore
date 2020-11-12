namespace ShoppingStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLoginTable1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logins", "MobileNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logins", "MobileNo", c => c.Int(nullable: false));
        }
    }
}
