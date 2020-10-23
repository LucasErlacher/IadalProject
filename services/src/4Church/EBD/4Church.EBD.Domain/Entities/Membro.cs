using System;
using System.Collections.Generic;

namespace _4Church.EBD.Domain.Entities
{
    public class Membro
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Contato Contato { get; set; }
        public bool Status { get; set; }

        public IEnumerable<CargoMembro> Cargos { get; set; }
        public IEnumerable<MembroTurma> Turmas { get; set; }
    }
}
