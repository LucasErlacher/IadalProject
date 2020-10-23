using _4Church.EBD.Domain.Entities.Enums;
using System;
using System.Collections.Generic;

namespace _4Church.EBD.Domain.Entities
{
    public class Chamada
    {
        public DateTime DataChamada { get; set; }
        public string Observacoes { get; set; }
        public decimal TotalOfertas { get; set; }
        public CondicaoClimatica CondicaoClimatica { get; set; }

        public Turma Turma { get; set; }
        public Membro Professor { get; set; }
        public ICollection<Presenca> Presencas { get; set; }
    }
}