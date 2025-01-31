using ClassHub.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHub.Domain.Entities
{
    public class Disciplina : BaseEntity<int>
    {
        public Disciplina() 
        {
        }
        
        public Disciplina(int id, string nome, string serie, string tipo_ensino, string carga_horaria, string ano_letivo)
        {
            Id = id;
            Nome = nome;
            Serie = serie; 
            Tipo_ensino = tipo_ensino;
            Carga_horaria = carga_horaria;
            Ano_letivo = ano_letivo;
        }

        public string? Nome { get; set; }
        public string? Serie { get; set; }
        public string? Tipo_ensino { get; set; }
        public string? Carga_horaria { get; set; }
        public string? Ano_letivo { get; set; }
    }
}
