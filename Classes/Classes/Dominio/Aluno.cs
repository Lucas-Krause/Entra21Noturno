using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    class Aluno : Pessoa
    {
        public string Turno { get; set; }
        public string Modalidade { get; set; }
        public string Pagou { get; set; }

        

        public Aluno(string nome, string telefone, string cpf, string turno, string modalidade)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
            Turno = turno;
            Modalidade = modalidade;
            Pagou = "Não.";
        }

        public override string ToString()
        {
            return $"{Nome} - {Turno} - {Modalidade} - Pagou: {Pagou}";
        }
    }
}
