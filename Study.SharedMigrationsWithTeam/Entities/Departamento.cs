using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Study.SharedMigrationsWithTeam.Entities
{
    public class Departamento
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Coordenador { get; set; }
    }
}