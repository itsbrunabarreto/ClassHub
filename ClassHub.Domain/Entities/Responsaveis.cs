using ClassHub.Domain.Base;
using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHub.Domain.Entities
{
    public class Responsaveis : BaseEntity<int>
    {
        public Responsaveis() 
        {
        }
        public Responsaveis(int id, string nome, string telefone, string email, string cpf, Aluno dependente, string parentesco, string observacao)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Parentesco = parentesco;
            Cpf = cpf;
            Observacao = observacao;
            Dependente = dependente;

        }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Parentesco { get; set; }
        public string? Cpf { get; set; }
        public string? Observacao { get; set; }
        public Aluno? Dependente { get; set; }
    }
}
