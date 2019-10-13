namespace Museum.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SimplifyModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Area", "CityId", "dbo.City");
            DropForeignKey("dbo.Museum", "AreaId", "dbo.Area");
            DropForeignKey("dbo.Feature", "FeatureTypeId", "dbo.FeatureType");
            DropForeignKey("dbo.Museum", "OwnerId", "dbo.Owner");
            DropForeignKey("dbo.City", "RegionId", "dbo.Region");
            DropForeignKey("dbo.Region", "CountryId", "dbo.Country");
            DropIndex("dbo.Region", new[] { "CountryId" });
            DropIndex("dbo.City", new[] { "RegionId" });
            DropIndex("dbo.Area", new[] { "CityId" });
            DropIndex("dbo.Museum", new[] { "AreaId" });
            DropIndex("dbo.Museum", new[] { "OwnerId" });
            DropIndex("dbo.Feature", new[] { "FeatureTypeId" });
            AddColumn("dbo.Country", "Name", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Country", "Capital", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Country", "Language", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Country", "GDP", c => c.Single());
            AddColumn("dbo.City", "Name", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.City", "Mayor", c => c.String(maxLength: 128));
            AddColumn("dbo.City", "Area", c => c.Single(nullable: false));
            AddColumn("dbo.City", "Population", c => c.Int(nullable: false));
            AddColumn("dbo.City", "Rank", c => c.Int());
            AddColumn("dbo.City", "Density", c => c.Int());
            AddColumn("dbo.City", "Website", c => c.String());
            AddColumn("dbo.City", "CountryId", c => c.Int(nullable: false));
            AddColumn("dbo.Museum", "Name", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Museum", "PhoneNumber", c => c.String(nullable: false, maxLength: 15));
            AddColumn("dbo.Museum", "Address", c => c.String(nullable: false, maxLength: 64));
            AddColumn("dbo.Museum", "EmailAddress", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Museum", "Website", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Museum", "AnnualVisitor", c => c.Int(nullable: false));
            AddColumn("dbo.Museum", "Rating", c => c.Byte());
            AddColumn("dbo.Museum", "CityId", c => c.Int(nullable: false));
            AddColumn("dbo.Feature", "Name", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Museum", "BuiltDate", c => c.DateTime());
            AlterColumn("dbo.Museum", "OpeningHour", c => c.Byte(nullable: false));
            AlterColumn("dbo.Museum", "ClosingHour", c => c.Byte(nullable: false));
            CreateIndex("dbo.City", "CountryId");
            CreateIndex("dbo.Museum", "CityId");
            AddForeignKey("dbo.City", "CountryId", "dbo.Country", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Museum", "CityId", "dbo.City", "Id", cascadeDelete: true);
            DropColumn("dbo.Country", "CountryName");
            DropColumn("dbo.City", "CityName");
            DropColumn("dbo.City", "MayorName");
            DropColumn("dbo.City", "RegionId");
            DropColumn("dbo.Museum", "MuseumName");
            DropColumn("dbo.Museum", "BecomeMuseumDate");
            DropColumn("dbo.Museum", "AnnualVisitorCount");
            DropColumn("dbo.Museum", "AreaId");
            DropColumn("dbo.Museum", "OwnerId");
            DropColumn("dbo.Feature", "FeatureName");
            DropColumn("dbo.Feature", "FeatureTypeId");
            DropTable("dbo.Region");
            DropTable("dbo.Area");
            DropTable("dbo.FeatureType");
            DropTable("dbo.Owner");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Owner",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 64),
                        MiddleName = c.String(maxLength: 64),
                        LastName = c.String(nullable: false, maxLength: 64),
                        DateOfBirth = c.DateTime(),
                        Email = c.String(nullable: false, maxLength: 128),
                        Nationality = c.String(nullable: false, maxLength: 64),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeatureType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeatureTypeName = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreaName = c.String(),
                        Zip = c.String(),
                        SurfaceArea = c.Single(nullable: false),
                        Population = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Region",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegionName = c.String(nullable: false, maxLength: 128),
                        President = c.String(maxLength: 64),
                        OfficialLanguage = c.String(maxLength: 64),
                        NationalDay = c.DateTime(nullable: false),
                        Website = c.String(maxLength: 128),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Feature", "FeatureTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Feature", "FeatureName", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Museum", "OwnerId", c => c.Int());
            AddColumn("dbo.Museum", "AreaId", c => c.Int(nullable: false));
            AddColumn("dbo.Museum", "AnnualVisitorCount", c => c.Int(nullable: false));
            AddColumn("dbo.Museum", "BecomeMuseumDate", c => c.DateTime());
            AddColumn("dbo.Museum", "MuseumName", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.City", "RegionId", c => c.Int(nullable: false));
            AddColumn("dbo.City", "MayorName", c => c.String(maxLength: 64));
            AddColumn("dbo.City", "CityName", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Country", "CountryName", c => c.String(nullable: false, maxLength: 128));
            DropForeignKey("dbo.Museum", "CityId", "dbo.City");
            DropForeignKey("dbo.City", "CountryId", "dbo.Country");
            DropIndex("dbo.Museum", new[] { "CityId" });
            DropIndex("dbo.City", new[] { "CountryId" });
            AlterColumn("dbo.Museum", "ClosingHour", c => c.Byte());
            AlterColumn("dbo.Museum", "OpeningHour", c => c.Byte());
            AlterColumn("dbo.Museum", "BuiltDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Feature", "Name");
            DropColumn("dbo.Museum", "CityId");
            DropColumn("dbo.Museum", "Rating");
            DropColumn("dbo.Museum", "AnnualVisitor");
            DropColumn("dbo.Museum", "Website");
            DropColumn("dbo.Museum", "EmailAddress");
            DropColumn("dbo.Museum", "Address");
            DropColumn("dbo.Museum", "PhoneNumber");
            DropColumn("dbo.Museum", "Name");
            DropColumn("dbo.City", "CountryId");
            DropColumn("dbo.City", "Website");
            DropColumn("dbo.City", "Density");
            DropColumn("dbo.City", "Rank");
            DropColumn("dbo.City", "Population");
            DropColumn("dbo.City", "Area");
            DropColumn("dbo.City", "Mayor");
            DropColumn("dbo.City", "Name");
            DropColumn("dbo.Country", "GDP");
            DropColumn("dbo.Country", "Language");
            DropColumn("dbo.Country", "Capital");
            DropColumn("dbo.Country", "Name");
            CreateIndex("dbo.Feature", "FeatureTypeId");
            CreateIndex("dbo.Museum", "OwnerId");
            CreateIndex("dbo.Museum", "AreaId");
            CreateIndex("dbo.Area", "CityId");
            CreateIndex("dbo.City", "RegionId");
            CreateIndex("dbo.Region", "CountryId");
            AddForeignKey("dbo.Region", "CountryId", "dbo.Country", "Id", cascadeDelete: true);
            AddForeignKey("dbo.City", "RegionId", "dbo.Region", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Museum", "OwnerId", "dbo.Owner", "Id");
            AddForeignKey("dbo.Feature", "FeatureTypeId", "dbo.FeatureType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Museum", "AreaId", "dbo.Area", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Area", "CityId", "dbo.City", "Id", cascadeDelete: true);
        }
    }
}
