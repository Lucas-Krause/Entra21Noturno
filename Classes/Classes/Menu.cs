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
        Academia _academia;

        public Menu()
        {
            InitializeComponent();
            _academia = new Academia();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            formProfessor = new FormularioProfessor(_academia);
            formProfessor.TopLevel = false;
            pnlFormulario.Controls.Add(formProfessor);
            formProfessor.WindowState = FormWindowState.Maximized;
            formProfessor.Show();

            btnProfessor.Enabled = false;
            btnAluno.Enabled = false;

            formModalidade = new FormularioModalidade(_academia);
            formModalidade.TopLevel = false;
            formModalidade.WindowState = FormWindowState.Maximized;

            formAluno = new FormularioAluno(_academia);
            formAluno.TopLevel = false;
            formAluno.WindowState = FormWindowState.Maximized;
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {   
            pnlFormulario.Controls.Clear();
            pnlFormulario.Controls.Add(formProfessor);
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
                pnlFormulario.Controls.Add(formModalidade);
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
                pnlFormulario.Controls.Add(formAluno);
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
