namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Authordiscr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "authorDiscription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "authorDiscription");
        }
    }
}
