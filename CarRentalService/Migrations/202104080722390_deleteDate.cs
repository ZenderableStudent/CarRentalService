namespace CarRentalService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "AddDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "AddDate", c => c.DateTime(nullable: false));
        }
    }
}
