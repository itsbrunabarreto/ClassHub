using ClassHub.Domain.Base;
using LocaMais.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHub.Domain.Entities
{
    public class Professor : BaseEntity<int>
    {
        public Professor()
        {
        }

        public Professor(int id, string nome, string telefone, string endereco, string bairro, string cpf, string sexo, 
            string estado_civil, DateTime data_contratacao, string formacao, string especializacao, float salario, bool status,
            string horario_trabalho, string observacoes, string email, Cidade cidade)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Bairro = bairro;
            Cpf = cpf;
            Sexo = sexo;
            Estado_civil = estado_civil;
            Data_contratacao = data_contratacao;
            Formacao = formacao;
            Especializacao = especializacao;
            Salario = salario;
            Status = status;
            Horario_trabalho = horario_trabalho;
            Observacoes = observacoes;
            Email = email;
            Cidade = cidade;
        }

        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Cpf { get; set; }
        public string? Sexo { get; set; }
        public string? Estado_civil { get; set; }
        public DateTime Data_contratacao { get; set; }
        public string? Formacao { get; set; }
        public string? Especializacao { get; set; }
        public float Salario { get; set; }
        public bool Status { get; set; }
        public string? Horario_trabalho { get; set; }
        public string Observacoes { get; set; }
        public string? Email { get; set; }
        public Cidade? Cidade { get; set; }
    }
}
