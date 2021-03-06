using Classes.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Classes
{
    public partial class Menu : Form
    {
        FormularioProfessor formProfessor;
        FormularioModalidade formModalidade;
        FormularioAluno formAluno;
        readonly Academia _academia;

        public Menu()
        {
            InitializeComponent();
            _academia = Academia.Instancia;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            formProfessor = new FormularioProfessor();
            formProfessor.TopLevel = false;
            pnlFormulario.Controls.Add(formProfessor);
            formProfessor.WindowState = FormWindowState.Maximized;
            formProfessor.Show();

            btnProfessor.Enabled = false;
            btnAluno.Enabled = false;

            formModalidade = new FormularioModalidade();
            formAluno = new FormularioAluno();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {   
            pnlFormulario.Controls.Clear();
            pnlFormulario.Controls.Add(formProfessor);
            formProfessor.WindowState = FormWindowState.Maximized;
            formProfessor.Show();
            formProfessor.Focus();
            btnProfessor.Enabled = false;
            btnModalidade.Enabled = true;
        }

        private void btnModalidade_Click(object sender, EventArgs e)
        {
            if (_academia.ListaProfessores.Count > 0)
            {
                pnlFormulario.Controls.Clear();
                formModalidade.TopLevel = false;
                pnlFormulario.Controls.Add(formModalidade);
                formModalidade.WindowState = FormWindowState.Maximized;
                formModalidade.Show();
                formModalidade.Focus();
                btnProfessor.Enabled = true;
                btnModalidade.Enabled = false;
                btnAluno.Enabled = true;
            }
            else
            {
                MessageBox.Show("Primeiro faça o cadastro de pelo menos 1 professor.");
                formProfessor.Focus();
            }
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            if (_academia.ListaModalidades.Count > 0)
            {
                pnlFormulario.Controls.Clear();
                formAluno.TopLevel = false;
                pnlFormulario.Controls.Add(formAluno);
                formAluno.WindowState = FormWindowState.Maximized;
                formAluno.Show();
                formAluno.Focus();
                btnProfessor.Enabled = true;
                btnModalidade.Enabled = true;
                btnAluno.Enabled = false;
            }
            else
            {
                MessageBox.Show("Primeiro faça o cadastro de pelo menos 1 modalidade.");
                formModalidade.Focus();
            }
        }
    }
}
