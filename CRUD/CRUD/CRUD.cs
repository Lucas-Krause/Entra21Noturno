using CRUD.Classe_Informacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class CRUD : Form
    {
        List<Registro> registros;
        bool novo;
        string mensagemDeErro = "Os dados obrigatórios a seguir não foram digitados\ndigite-os antes de salvar.";

        public CRUD()
        {
            InitializeComponent();
            registros = new List<Registro>();

        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparValores();
            txtNomeAluno.Focus();
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = false;
            lbxRegistros.SelectedIndex = -1;
            novo = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                if (VerificarDadosPreenchidos())
                {
                    SalvarValores();
                    novo = false;
                }
                else
                {
                    MessageBox.Show(mensagemDeErro);
                    mensagemDeErro = "Os dados obrigatórios a seguir não foram digitados\ndigite-os antes de salvar.";
                }
            }
            else
            {
                EditarSelecionado();
            }
            AtualizarCadastros();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarSelecionado();
            LimparValores();
            lbxRegistros.SelectedIndex = -1;
            btnDeletar.Enabled = false;
        }

        private void lbxRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxRegistros.SelectedIndex >= 0)
            {
                MostrarValoresSelecionado();
                novo = false;
                btnDeletar.Enabled = true;
            }
        }

        private void SalvarValores()
        {
            Registro contato = new Registro(
                txtNomeAluno.Text,
                dtpDataDeNascimento.Value,
                cbxSerieAluno.SelectedItem.ToString(),
                cbxSexoAluno.SelectedItem.ToString(),
                txtNomeResponsavel.Text,
                mtxtCpfPrimeiro.Text,
                txtNomeSegundoResponsavel.Text,
                mtxtCpfSegundo.Text);
            registros.Add(contato);
        }

        private void LimparValores()
        {
            txtNomeAluno.Clear();
            txtNomeResponsavel.Clear();
            txtNomeSegundoResponsavel.Clear();
            mtxtCpfPrimeiro.Clear();
            mtxtCpfSegundo.Clear();
            cbxSerieAluno.SelectedItem = null;
            cbxSexoAluno.SelectedItem = null;
            dtpDataDeNascimento.Value = DateTime.Today;
        }

        private void AtualizarCadastros()
        {
            lbxRegistros.Items.Clear();
            foreach (var contato in registros)
            {
                lbxRegistros.Items.Add(contato);
            }
        }

        private void MostrarValoresSelecionado()
        {
            txtNomeAluno.Text = registros[lbxRegistros.SelectedIndex].Nome;
            txtNomeResponsavel.Text = registros[lbxRegistros.SelectedIndex].NomeResponsavelUm;
            txtNomeSegundoResponsavel.Text = registros[lbxRegistros.SelectedIndex].NomeResponsavelDois;
            mtxtCpfPrimeiro.Text = registros[lbxRegistros.SelectedIndex].PrimeiroCPF;
            mtxtCpfSegundo.Text = registros[lbxRegistros.SelectedIndex].SegundoCPF;
            cbxSerieAluno.SelectedItem = registros[lbxRegistros.SelectedIndex].Serie;
            cbxSexoAluno.SelectedItem = registros[lbxRegistros.SelectedIndex].Sexo;
            dtpDataDeNascimento.Value = registros[lbxRegistros.SelectedIndex].DataDeNascimento;
        }

        private void DeletarSelecionado()
        {
            registros.RemoveAt(lbxRegistros.SelectedIndex);
            lbxRegistros.Items.RemoveAt(lbxRegistros.SelectedIndex);
        }

        private void EditarSelecionado()
        {
            registros[lbxRegistros.SelectedIndex].Nome = txtNomeAluno.Text;
            registros[lbxRegistros.SelectedIndex].NomeResponsavelUm = txtNomeResponsavel.Text;
            registros[lbxRegistros.SelectedIndex].NomeResponsavelDois = txtNomeSegundoResponsavel.Text;
            registros[lbxRegistros.SelectedIndex].PrimeiroCPF = mtxtCpfPrimeiro.Text;
            registros[lbxRegistros.SelectedIndex].SegundoCPF = mtxtCpfSegundo.Text;
            registros[lbxRegistros.SelectedIndex].Serie = cbxSerieAluno.SelectedItem.ToString();
            registros[lbxRegistros.SelectedIndex].Sexo = cbxSexoAluno.SelectedItem.ToString();
            registros[lbxRegistros.SelectedIndex].DataDeNascimento = dtpDataDeNascimento.Value;
        }

        private bool VerificarDadosPreenchidos()
        {
            bool verificacao = true;
            if (String.IsNullOrEmpty(txtNomeAluno.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n--> Nome do Aluno.";
            }
            if (dtpDataDeNascimento.Value == DateTime.Today)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Data de Nascimento.";
            }
            if (cbxSerieAluno.SelectedItem == null)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Serie do Aluno.";
            }
            if (String.IsNullOrEmpty(txtNomeResponsavel.Text) || !mtxtCpfPrimeiro.MaskCompleted)
            {
                if (String.IsNullOrEmpty(txtNomeSegundoResponsavel.Text) || !mtxtCpfSegundo.MaskCompleted)
                {
                    verificacao = false;
                    mensagemDeErro += "\n--> Nome de pelo menos um Responsavel com CPF";
                }
            }
            return verificacao;
        }
    }
}