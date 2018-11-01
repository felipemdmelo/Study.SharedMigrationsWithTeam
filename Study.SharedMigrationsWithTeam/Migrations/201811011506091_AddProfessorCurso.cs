namespace Study.SharedMigrationsWithTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProfessorCurso : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Curso", "Professor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Curso", "Professor");
        }
    }
}
