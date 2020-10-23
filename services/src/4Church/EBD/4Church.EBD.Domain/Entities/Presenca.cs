namespace _4Church.EBD.Domain.Entities
{
    public class Presenca
    {
        public bool Presente { get; set; }
        public bool TrouxeRevista { get; set; }
        public bool TrouxeBiblia { get; set; }
        public bool TrouxeVisitante { get; set; }

        public MembroTurma Aluno { get; set; }
    }
}
