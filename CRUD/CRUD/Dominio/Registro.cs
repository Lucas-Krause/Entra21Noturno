using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Classe_Informacoes
{
    class Registro
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Serie { get; set; }
        public string Sexo { get; set; }
        public string NomeResponsavelUm { get; set; }
        public string PrimeiroCPF { get; set; }
        public string NomeResponsavelDois { get; set; }
        public string SegundoCPF { get; set; }

        public Registro(
            string nome,
            DateTime dataDeNascimento,
            string serie,
            string sexo,
            string nomeResponsavelUm,
            string primeiroCPF,
            string nomeResponsavelDois,
            string segundoCPF)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Serie = serie;
            Sexo = sexo;
            NomeResponsavelUm = nomeResponsavelUm;
            PrimeiroCPF = primeiroCPF;
            NomeResponsavelDois = nomeResponsavelDois;
            SegundoCPF = segundoCPF;
        }
        
        public override string ToString()
        {
            return $"{Nome}, {Sexo} - {Serie} - {DataDeNascimento}";
        }
        
    }
}

