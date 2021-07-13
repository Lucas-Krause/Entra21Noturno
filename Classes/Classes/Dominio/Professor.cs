using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    public class Professor : Pessoa
    {
        public string Turno { get; set; }
        public double SalarioHora { get; set; }

        public Professor(
            string nome,
            string telefone,
            string cpf,
            string turno,
            double salarioHora)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
            Turno = turno;
            SalarioHora = salarioHora;
        }

        public override string ToString()
        {
            return $"{Nome} - {Turno}";
        }
    }
}
