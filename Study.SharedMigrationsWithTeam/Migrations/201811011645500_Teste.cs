namespace Study.SharedMigrationsWithTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Curso", "Campo3", c => c.String());
            AddColumn("dbo.Curso", "Campo4", c => c.String());
            AddColumn("dbo.Curso", "Campo5", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Curso", "Campo5");
            DropColumn("dbo.Curso", "Campo4");
            DropColumn("dbo.Curso", "Campo3");
        }
    }
}
