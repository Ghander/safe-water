namespace SafeWater8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roles : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Addresses", "StreetAddress");
            DropColumn("dbo.Addresses", "City");
            DropColumn("dbo.Addresses", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Addresses", "State", c => c.String());
            AddColumn("dbo.Addresses", "City", c => c.String());
            AddColumn("dbo.Addresses", "StreetAddress", c => c.String());
        }
    }
}
