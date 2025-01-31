using ClassHub.Domain.Base;
using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHub.Domain.Entities
{
    public class Aluno : BaseEntity<int>
    {
        public Aluno() 
        {
        }

        public Aluno(int id, string nome, string telefone, string endereco, string bairro, string cpf, string sexo, string email, Cidade cidade)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
            Cpf = cpf;
            Sexo = sexo;
            Email = email;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Cpf { get; set; }
        public string? Sexo { get; set; }
        public string? Email { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
