using Classes.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class FormularioAluno : Form
    {
        Academia academia;
        bool novo;
        bool pagar = false;
        bool verificacao;
        string mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";

        public FormularioAluno()
        {
            InitializeComponent();
            academia = Academia.Instancia;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparDados();
            novo = true;
            txtNome.Focus();
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {   
            if (VerificarDados())
            {
                if (novo)
                {
                    academia.AdicionarAluno(
                        txtNome.Text,
                        mskTelefone.Text,
                        mskCPF.Text,
                        (Modalidade)cbxModalidade.SelectedItem);
                    if (pagar)
                    {
                        academia.ListaAlunos.Last().Pagou = "Sim.";
                    }
                    pagar = false;
                    btnNovo_Click(sender, e);
                }
                else
                {
                    if (lbxAlunos.SelectedIndex >= 0)
                    {
                        academia.EditarAluno(
                            lbxAlunos.SelectedIndex,
                            txtNome.Text,
                            mskTelefone.Text,
                            mskCPF.Text,
                            (Modalidade)cbxModalidade.SelectedItem);
                    }
                    btnNovo_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show(mensagemDeErro);
                mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";
            }
            AtualizarListaAlunos();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lbxAlunos.SelectedIndex >= 0)
            {
                academia.DeletarAluno(lbxAlunos.SelectedIndex);
            }
            AtualizarListaAlunos();
            btnNovo_Click(sender, e);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (lbxAlunos.SelectedIndex >= 0)
            {
                academia.ListaAlunos[lbxAlunos.SelectedIndex].Pagou = "Sim.";
            }
            else
            {
                pagar = true;
            }
            AtualizarListaAlunos();
        }

        private void AtualizarListaAlunos()
        {
            lbxAlunos.Items.Clear();
            foreach (var aluno in academia.ListaAlunos)
            {
                lbxAlunos.Items.Add(aluno);
            }
        }

        private void LimparDados()
        {
            txtNome.Clear();
            mskTelefone.Clear();
            mskCPF.Clear();
            txtMensalidade.Clear();
            txtTurno.Clear();
            txtProfessor.Clear();
            cbxModalidade.SelectedItem = null;
        }

        private bool VerificarDados()
        {
            verificacao = true;
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n--> Nome.";
            }
            if (!mskTelefone.MaskCompleted)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Telefone.";
            }
            if (!mskCPF.MaskCompleted)
            {
                verificacao = false;
                mensagemDeErro += "\n--> CPF.";
            }
            return verificacao;
        }

        private void lbxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lbxAlunos.SelectedIndex;
            if (indice >= 0)
            {
                txtNome.Text = academia.ListaAlunos[indice].Nome;
                mskTelefone.Text = academia.ListaAlunos[indice].Telefone;
                mskCPF.Text = academia.ListaAlunos[indice].CPF;
                txtTurno.Text = academia.ListaAlunos[indice].Modalidade.Professor.Turno;
                cbxModalidade.SelectedItem = academia.ListaAlunos[indice].Modalidade;
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
                novo = false;
            }
        }

        private void cbxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxModalidade.SelectedItem != null)
            {
                btnSalvar.Enabled = true;
                txtTurno.Text = academia.ListaModalidades[cbxModalidade.SelectedIndex].Professor.Turno;
                txtProfessor.Text = academia.ListaModalidades[cbxModalidade.SelectedIndex].Professor.Nome;
                txtMensalidade.Text = academia.ListaModalidades[cbxModalidade.SelectedIndex].CalcularValor().ToString();
            }
        }

        private void FormularioAluno_Enter(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
            cbxModalidade.Items.Clear();
            foreach (var modalidade in academia.ListaModalidades)
            {
                cbxModalidade.Items.Add(modalidade);
            }
        }

        private void FormularioAluno_Leave(object sender, EventArgs e)
        {
            LimparDados();
        }
        
        private void mskTelefone_Click(object sender, EventArgs e)
        {
            mskTelefone.Focus();
        }

        private void mskCPF_Click(object sender, EventArgs e)
        {
            mskCPF.Focus();
        }
    }
}




