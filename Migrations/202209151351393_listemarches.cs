namespace MUAT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class listemarches : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ListeMarches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TitreMarche = c.String(),
                        LienMarche = c.String(),
                        ListeDocs = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ListeMarches");
        }
    }
}
