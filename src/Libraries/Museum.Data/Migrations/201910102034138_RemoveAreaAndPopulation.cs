namespace Museum.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAreaAndPopulation : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Region", "SurfaceArea");
            DropColumn("dbo.Region", "Population");
            DropColumn("dbo.City", "SurfaceArea");
            DropColumn("dbo.City", "Population");
        }
        
        public override void Down()
        {
            AddColumn("dbo.City", "Population", c => c.Int());
            AddColumn("dbo.City", "SurfaceArea", c => c.Single());
            AddColumn("dbo.Region", "Population", c => c.Int(nullable: false));
            AddColumn("dbo.Region", "SurfaceArea", c => c.Single(nullable: false));
        }
    }
}
