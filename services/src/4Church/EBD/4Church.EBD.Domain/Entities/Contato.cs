using _4Church.EBD.Domain.Enums;

namespace _4Church.EBD.Domain.Entities
{
    public class Contato
    {
        public TipoContato Tipo { get; set; }
        public string Valor { get; set; }
    }
}
