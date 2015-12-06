namespace SafeWater8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedlist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contaminants", "Source", c => c.String());
            DropColumn("dbo.Contaminants", "Severity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contaminants", "Severity", c => c.Int(nullable: false));
            DropColumn("dbo.Contaminants", "Source");
        }
    }
}
