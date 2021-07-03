using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public void Sacar(double quantia)
        {
            saldo -= quantia;
        }
    }
}
