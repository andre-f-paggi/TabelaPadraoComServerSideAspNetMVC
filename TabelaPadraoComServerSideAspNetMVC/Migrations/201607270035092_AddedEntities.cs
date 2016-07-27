namespace TabelaPadraoComServerSideAspNetMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EntityTests",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        first_name = c.String(),
                        last_name = c.String(),
                        email = c.String(),
                        gender = c.String(),
                        ip_address = c.String(),
                        avatar = c.String(),
                        mac_address = c.String(),
                        postal_code = c.String(),
                        url = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EntityTests");
        }
    }
}
