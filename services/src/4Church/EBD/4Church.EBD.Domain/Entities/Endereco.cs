namespace _4Church.EBD.Domain.Entities
{
    public class Endereco
    {
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public CEP CEP { get; private set; }

        public Endereco(string rua, string bairro, string cidade, string estado, CEP cep)
        {
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }
    }

    public struct CEP
    {
        private readonly string _cep;

        public CEP(string cep)
        {
            //TODO: Validações
            _cep = cep;
        }

        public static implicit operator string(CEP cep) => cep._cep;
        public static explicit operator CEP(string cep) => new CEP(cep);
    }
}