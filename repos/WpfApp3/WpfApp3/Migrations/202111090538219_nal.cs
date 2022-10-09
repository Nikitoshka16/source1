namespace WpfApp3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Doljs", "nal", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Doljs", "nal");
        }
    }
}
