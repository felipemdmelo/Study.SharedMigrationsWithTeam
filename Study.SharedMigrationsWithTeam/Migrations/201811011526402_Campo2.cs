namespace Study.SharedMigrationsWithTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Campo2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Curso", "Campo2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Curso", "Campo2");
        }
    }
}
