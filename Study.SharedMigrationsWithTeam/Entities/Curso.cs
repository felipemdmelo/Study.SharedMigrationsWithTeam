﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Study.SharedMigrationsWithTeam.Entities
{
    public class Curso
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public int Horas { get; set; }
        public long DepartamentoId { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}