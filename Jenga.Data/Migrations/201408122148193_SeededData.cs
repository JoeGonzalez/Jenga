namespace Jenga.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeededData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usernames = c.String(),
                        Passwords = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Players");
        }
    }
}
