using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
    }
}
