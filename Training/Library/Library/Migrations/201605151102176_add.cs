namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "Title", c => c.String());
        }
    }
}
