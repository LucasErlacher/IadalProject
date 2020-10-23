using System;
using System.Collections.Generic;

namespace _4Church.EBD.Domain.Entities
{
    public class Turma
    {
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Status { get; set; }

        public ICollection<MembroTurma> Membros { get; set; }
        public ICollection<Chamada> Chamadas { get; set; }

        public Turma(string nome, DateTime dataCriacao)
        {
            Nome = nome;
            DataCriacao = dataCriacao;
            Status = true;
        }
    }
}
