using System;
using System.Collections.Generic;

namespace _4Church.EBD.Domain.Entities
{
    public class Cargo
    {
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }

        public ICollection<CargoMembro> Membros { get; set; }
    }
}
