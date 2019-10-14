namespace Museum.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetFieldsLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Country", "GDP", c => c.Long());
            AlterColumn("dbo.City", "Website", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.City", "Website", c => c.String());
            AlterColumn("dbo.Country", "GDP", c => c.Single());
        }
    }
}
