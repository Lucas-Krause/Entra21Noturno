using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Dominio
{
    class Academia
    {
        public List<Aluno> ListaAlunos { get; set; }

        public Academia()
        {
            ListaAlunos = new List<Aluno>();
        }

        public void AdicionarAluno(string nome, string telefone, string cpf, string turno, string modalidade)
        {
            ListaAlunos.Add(new Aluno(nome, telefone, cpf, turno, modalidade));
        }

        public void AtualizarAluno(
            int indice,
            string nome,
            string telefone,
            string cpf,
            string turno,
            string modalidade)
        {
            ListaAlunos[indice].Nome = nome;
            ListaAlunos[indice].Telefone = telefone;
            ListaAlunos[indice].CPF = cpf;
            ListaAlunos[indice].Turno = turno;
            ListaAlunos[indice].Modalidade = modalidade;
        }

        public void DeletarAluno(int indice)
        {
            ListaAlunos.RemoveAt(indice);
        }

    }
}
