using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicio5 : Form
    {
        string nomeAluno;
        double notaAluno;
        int? numeroDeAlunos;
        int contagemAlunos = 0;
        double somaNotas = 0;
        public Exercicio5()
        {
            InitializeComponent();
        }
        private void btnExitToMenu_Click(object sender, EventArgs e)
        {
            ChamarMenu();
        }
        private void ChamarMenu()
        {
            var menu = new Menu();
            this.Close();
            menu.Show();
        }
        private void LerTextos()
        {
            notaAluno = double.Parse(txtNotaAluno.Text);
            nomeAluno = txtNomeDoAluno.Text;
        }
        private void LimparTextos()
        {
            txtNomeDoAluno.Clear();
            txtNotaAluno.Clear();
        }
        private void txtNumeroAlunos_TextChanged(object sender, EventArgs e)
        {
            if (numeroDeAlunos != null)
            {
                numeroDeAlunos = int.Parse(txtNumeroAlunos.Text);
            }
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (contagemAlunos == numeroDeAlunos)
            {
                lbMensagem.Text = "Numero de alunos excedido, nao ha como informar mais alunos!";
            }
            else
            {
                if (notaAluno > 10 || notaAluno < 0)
                {
                    lbMensagem.Text = "Vai se fuder, arruma a nota direito!";
                }
                else
                {
                    LerTextos();
                    LimparTextos();
                    lbxInformacoesAlunos.Items.Add($"{nomeAluno}, Nota = {notaAluno}");
                    txtNumeroAlunos.ReadOnly = true;
                    somaNotas += notaAluno;
                    contagemAlunos++;
                    if (contagemAlunos == numeroDeAlunos)
                    {
                        txtMediaTurma.Text = $"A media da turma eh: {(somaNotas / numeroDeAlunos).ToString()}";
                    }
                }
            }
        }
    }
}
