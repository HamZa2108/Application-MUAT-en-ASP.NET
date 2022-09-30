namespace MUAT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genererdocs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GenererDocs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Document = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GenererDocs");
        }
    }
}
