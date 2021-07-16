using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes.Dominio
{
    public class Academia
    {
        private static Academia instancia;
        public static Academia Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Academia();
                }
                return instancia;
            }
        }

        public List<Aluno> ListaAlunos { get; set; }
        public List<Professor> ListaProfessores { get; set; }
        public List<Modalidade> ListaModalidades { get; set; }

        private Academia()
        {
            ListaProfessores = new List<Professor>();
            ListaModalidades = new List<Modalidade>();
            ListaAlunos = new List<Aluno>();
        }

        public void AdicionarAluno(
            string nome, 
            string telefone, 
            string cpf, 
            Modalidade modalidade)
        {
            ListaAlunos.Add(new Aluno(nome, telefone, cpf, modalidade.Professor.Turno, modalidade));
        }

        public void AdicionarProfessor(
            string nome,
            string telefone,
            string cpf,
            string turno,
            double salarioHora)
        {
            ListaProfessores.Add(new Professor(nome, telefone, cpf, turno, salarioHora));
        }

        public void AdicionarModalidade(
            string nome,
            int vezesSemana,
            double precoHora,
            Professor professor)
        {
            ListaModalidades.Add(new Modalidade(nome, vezesSemana, precoHora, professor));
        }

        public void EditarAluno(
            int indice,
            string nome,
            string telefone,
            string cpf,
            Modalidade modalidade)
        {
            ListaAlunos[indice].Nome = nome;
            ListaAlunos[indice].Telefone = telefone;
            ListaAlunos[indice].CPF = cpf;
            ListaAlunos[indice].Turno = modalidade.Professor.Turno;
            ListaAlunos[indice].Modalidade = modalidade;
        }

        public void EditarProfessor(
            int indice,
            string nome,
            string telefone,
            string cpf,
            string turno,
            double salarioHora)
        {
            ListaProfessores[indice].Nome = nome;
            ListaProfessores[indice].Telefone = telefone;
            ListaProfessores[indice].CPF = cpf;
            ListaProfessores[indice].Turno = turno;
            ListaProfessores[indice].SalarioHora = salarioHora;
        }

        public void EditarModalidade(
            int indice,
            string nome,
            int vezesSemana,
            double precoHora,
            Professor professor)
        {
            ListaModalidades[indice].Nome = nome;
            ListaModalidades[indice].Professor = professor;
            ListaModalidades[indice].VezesSemana = vezesSemana;
            ListaModalidades[indice].PrecoHora = precoHora;
        }

        public void DeletarAluno(int indice)
        {
            ListaAlunos.RemoveAt(indice);
        }

        public void DeletarProfessor(int indice)
        {
            ListaProfessores.RemoveAt(indice);
        }

        public void DeletarModalidade(int indice)
        {
            ListaModalidades.RemoveAt(indice);
        }

    }
}
