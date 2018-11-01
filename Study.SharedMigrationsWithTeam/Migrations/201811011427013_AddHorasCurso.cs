namespace Study.SharedMigrationsWithTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHorasCurso : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Curso", "Horas", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Curso", "Horas");
        }
    }
}
