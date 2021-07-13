using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    public class Aluno : Pessoa
    {
        public string Turno { get; set; }
        public Modalidade Modalidade { get; set; }
        public string Pagou { get; set; }

        public Aluno(string nome, string telefone, string cpf, string turno, Modalidade modalidade)
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
