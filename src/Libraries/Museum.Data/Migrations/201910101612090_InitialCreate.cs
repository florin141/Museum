namespace Museum.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 128),
                        CountryCode = c.String(nullable: false, maxLength: 5),
                        DialingCode = c.String(maxLength: 4),
                        Currency = c.String(nullable: false, maxLength: 10),
                        DrivingSide = c.Int(),
                        Flag = c.Binary(),
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
                        SurfaceArea = c.Single(nullable: false),
                        Population = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Country", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(nullable: false, maxLength: 128),
                        MayorName = c.String(maxLength: 64),
                        SurfaceArea = c.Single(),
                        Population = c.Int(),
                        RegionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Region", t => t.RegionId, cascadeDelete: true)
                .Index(t => t.RegionId);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Museum",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MuseumName = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                        BuiltDate = c.DateTime(nullable: false),
                        BecomeMuseumDate = c.DateTime(),
                        OpeningHour = c.Byte(),
                        ClosingHour = c.Byte(),
                        AnnualVisitorCount = c.Int(nullable: false),
                        AdmissionCharge = c.Decimal(nullable: false, storeType: "money"),
                        AreaId = c.Int(nullable: false),
                        MuseumTypeId = c.Int(),
                        OwnerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Area", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.MuseumType", t => t.MuseumTypeId)
                .ForeignKey("dbo.Owner", t => t.OwnerId)
                .Index(t => t.AreaId)
                .Index(t => t.MuseumTypeId)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.Feature",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeatureName = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                        FeatureTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeatureType", t => t.FeatureTypeId, cascadeDelete: true)
                .Index(t => t.FeatureTypeId);
            
            CreateTable(
                "dbo.FeatureType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeatureTypeName = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MuseumType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 128),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.MuseumFeature",
                c => new
                    {
                        MuseumId = c.Int(nullable: false),
                        FeatureId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MuseumId, t.FeatureId })
                .ForeignKey("dbo.Museum", t => t.MuseumId, cascadeDelete: true)
                .ForeignKey("dbo.Feature", t => t.FeatureId, cascadeDelete: true)
                .Index(t => t.MuseumId)
                .Index(t => t.FeatureId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Region", "CountryId", "dbo.Country");
            DropForeignKey("dbo.City", "RegionId", "dbo.Region");
            DropForeignKey("dbo.Museum", "OwnerId", "dbo.Owner");
            DropForeignKey("dbo.Museum", "MuseumTypeId", "dbo.MuseumType");
            DropForeignKey("dbo.MuseumFeature", "FeatureId", "dbo.Feature");
            DropForeignKey("dbo.MuseumFeature", "MuseumId", "dbo.Museum");
            DropForeignKey("dbo.Feature", "FeatureTypeId", "dbo.FeatureType");
            DropForeignKey("dbo.Museum", "AreaId", "dbo.Area");
            DropForeignKey("dbo.Area", "CityId", "dbo.City");
            DropIndex("dbo.MuseumFeature", new[] { "FeatureId" });
            DropIndex("dbo.MuseumFeature", new[] { "MuseumId" });
            DropIndex("dbo.Feature", new[] { "FeatureTypeId" });
            DropIndex("dbo.Museum", new[] { "OwnerId" });
            DropIndex("dbo.Museum", new[] { "MuseumTypeId" });
            DropIndex("dbo.Museum", new[] { "AreaId" });
            DropIndex("dbo.Area", new[] { "CityId" });
            DropIndex("dbo.City", new[] { "RegionId" });
            DropIndex("dbo.Region", new[] { "CountryId" });
            DropTable("dbo.MuseumFeature");
            DropTable("dbo.Owner");
            DropTable("dbo.MuseumType");
            DropTable("dbo.FeatureType");
            DropTable("dbo.Feature");
            DropTable("dbo.Museum");
            DropTable("dbo.Area");
            DropTable("dbo.City");
            DropTable("dbo.Region");
            DropTable("dbo.Country");
        }
    }
}
