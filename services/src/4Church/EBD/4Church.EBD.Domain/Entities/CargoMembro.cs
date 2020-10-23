using System;

namespace _4Church.EBD.Domain.Entities
{
    public class CargoMembro
    {
        public DateTime DataIngresso { get; set; }

        public Cargo Cargo { get; set; }
        public Membro Membro { get; set; }
    }
}
