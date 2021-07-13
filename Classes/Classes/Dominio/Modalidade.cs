using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    public class Modalidade : IMensalidade
    {
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public int VezesSemana { get; set; }
        public double PrecoHora { get; set; }

        public Modalidade(string nome, int vezesSemana, double precoHora, Professor professor)
        {
            Nome = nome;
            VezesSemana = vezesSemana;
            PrecoHora = precoHora;
            Professor = professor;
        }

        public double CalcularValor()
        {
            return PrecoHora * VezesSemana * 4;
        }

        public override string ToString()
        {
            return $"{Nome}"; 
        }
    }
}
