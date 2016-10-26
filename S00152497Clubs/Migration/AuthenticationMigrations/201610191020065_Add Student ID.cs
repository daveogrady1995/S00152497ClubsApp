namespace S00152497Clubs.Migration.AuthenticationMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "StudentID", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "StudentID");
        }
    }
}
