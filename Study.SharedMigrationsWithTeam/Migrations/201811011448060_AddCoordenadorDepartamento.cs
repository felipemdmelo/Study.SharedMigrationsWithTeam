namespace Study.SharedMigrationsWithTeam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCoordenadorDepartamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departamento", "Coordenador", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departamento", "Coordenador");
        }
    }
}
