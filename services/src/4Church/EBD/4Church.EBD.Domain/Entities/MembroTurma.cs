using _4Church.EBD.Domain.Entities.Enums;
using System;

namespace _4Church.EBD.Domain.Entities
{
    public class MembroTurma
    {
        public DateTime DataIngresso { get; set; }
        public TipoMembroEBD TipoMembro { get; set; }

        public Membro Membro { get; set; }
        public Turma Turma { get; set; }
    }
}
