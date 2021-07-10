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
    public partial class Formulario : Form
    {
        Academia academia;
        bool novo;
        bool pagar = false;
        bool verificacao;
        string mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";

        public Formulario()
        {
            InitializeComponent();
            academia = new Academia();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            btnAdicionar_Click(sender, e);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
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
                        cbxTurno.SelectedItem.ToString(),
                        cbxModalidade.SelectedItem.ToString());
                    if (pagar)
                    {
                        academia.ListaAlunos.Last().Pagou = "Sim.";
                    }
                }
                else
                {
                    if (lbxAlunos.SelectedIndex >= 0)
                    {
                        academia.AtualizarAluno(
                            lbxAlunos.SelectedIndex,
                            txtNome.Text,
                            mskTelefone.Text,
                            mskCPF.Text,
                            cbxTurno.SelectedItem.ToString(),
                            cbxModalidade.SelectedItem.ToString());
                    }

                }
            }
            else
            {
                MessageBox.Show(mensagemDeErro);
                mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";
            }
            pagar = false;
            novo = false;
            AtualizarListaAlunos();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lbxAlunos.SelectedIndex >= 0)
            {
                academia.DeletarAluno(lbxAlunos.SelectedIndex);
            }
            LimparDados();
            AtualizarListaAlunos();
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = false;
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

        private void cbxModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxModalidade.SelectedItem != null)
            {
                btnSalvar.Enabled = true;
                CalcularMensalidade();
            }
        }

        private void lbxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lbxAlunos.SelectedIndex;
            if (indice >= 0)
            {
                txtNome.Text = academia.DadoAluno(indice, "Nome");
                mskTelefone.Text = academia.DadoAluno(indice, "Telefone");
                mskCPF.Text = academia.DadoAluno(indice, "CPF");
                cbxTurno.SelectedItem = academia.DadoAluno(indice, "Turno");
                cbxModalidade.SelectedItem = academia.DadoAluno(indice, "Modalidade");
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
                novo = false;
            }
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
            cbxTurno.SelectedItem = null;
            cbxModalidade.SelectedItem = null;
        }

        private void CalcularMensalidade()
        {
            switch (cbxModalidade.SelectedItem)
            {
                case "Musculação":
                    txtMensalidade.Text = "R$: 100,00";
                    break;
                case "Preparação Fisica":
                    txtMensalidade.Text = "R$: 125,00";
                    break;
                case "Dança":
                    txtMensalidade.Text = "R$: 90,00";
                    break;
                case "Crossfit":
                    txtMensalidade.Text = "R$: 200,00";
                    break;
            }
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
            if (cbxTurno.SelectedItem == null)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Turno.";
            }
            return verificacao;
        }
    }
}




