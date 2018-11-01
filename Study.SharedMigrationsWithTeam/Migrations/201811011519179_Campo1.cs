namespace Study.SharedMigrationsWithTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Campo1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departamento", "Campo1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departamento", "Campo1");
        }
    }
}
