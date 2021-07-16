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
    public partial class FormularioModalidade : Form
    {
        Academia _academia;
        bool novo;
        bool verificacao;
        string nome = "";
        string mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";


        public FormularioModalidade()
        {
            InitializeComponent();
            _academia = Academia.Instancia;
        }

        private void FormularioModalidade_Load(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
            AtualizarListaModalidades();
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
                    _academia.AdicionarModalidade(
                        txtNome.Text,
                        Convert.ToInt32(cbxVezesSemana.SelectedItem),
                        double.Parse(mskPrecoHora.Text.Substring(4)),
                        (Professor)cbxProfessor.SelectedItem);
                    btnNovo_Click(sender, e);
                    novo = false;
                }
                else
                {
                    if (lbxModalidades.SelectedIndex >= 0)
                    {
                        _academia.EditarModalidade(
                            lbxModalidades.SelectedIndex,
                            txtNome.Text,
                            Convert.ToInt32(cbxVezesSemana.SelectedItem),
                            double.Parse(mskPrecoHora.Text.Substring(4)),
                            (Professor)cbxProfessor.SelectedItem);
                    }
                    btnNovo_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show(mensagemDeErro);
                mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";
            }
            AtualizarListaModalidades();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int indice = lbxModalidades.SelectedIndex;
            bool verificarDelete = true;
            if (indice >= 0)
            {
                foreach (var aluno in _academia.ListaAlunos)
                {
                    if (aluno.Modalidade.Nome == _academia.ListaModalidades[indice].Nome)
                    {
                        nome += $"\n--> {aluno.Nome}";
                        verificarDelete = false;
                    }
                }
                if (verificarDelete)
                {
                    _academia.DeletarModalidade(indice);
                    btnNovo_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Você não pode deletar uma modalidade já cadastrado em um aluno\n" +
                        $"por favor altere a modalidade do(s) seguinte(s) aluno(s) {nome}");
                    nome = "";
                    btnNovo_Click(sender, e);
                }
            }
            AtualizarListaModalidades();
        }

        private void AtualizarListaModalidades()
        {
            lbxModalidades.Items.Clear();
            foreach (var modalidade in _academia.ListaModalidades)
            {
                lbxModalidades.Items.Add(modalidade);
            }
        }

        private void LimparDados()
        {
            txtNome.Clear();
            mskPrecoHora.Clear();
            cbxProfessor.SelectedItem = null;
            cbxVezesSemana.SelectedItem = null;
        }

        private bool VerificarDados()
        {
            verificacao = true;
            if (String.IsNullOrEmpty(txtNome.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n--> Nome.";
            }
            if (cbxProfessor.SelectedItem == null)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Professor.";
            }
            if (cbxVezesSemana.SelectedItem == null)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Vezes/Semana.";
            }
            if (!mskPrecoHora.MaskCompleted)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Preço/Hora.";
            }
            return verificacao;
        }

        private void mskPrecoHora_TextChanged(object sender, EventArgs e)
        {
            if (mskPrecoHora.MaskCompleted)
            {
                btnSalvar.Enabled = true;
            }
        }

        private void lbxModalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lbxModalidades.SelectedIndex;
            if (indice >= 0)
            {
                txtNome.Text = _academia.ListaModalidades[indice].Nome;
                mskPrecoHora.Text = _academia.ListaModalidades[indice].PrecoHora.ToString();
                cbxProfessor.SelectedItem = _academia.ListaModalidades[indice].Professor;
                cbxVezesSemana.SelectedIndex = _academia.ListaModalidades[indice].VezesSemana - 1;
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
                novo = false;
            }
        }

        private void FormularioModalidade_Enter(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
            cbxProfessor.Items.Clear();
            foreach (var professor in _academia.ListaProfessores)
            {
                cbxProfessor.Items.Add(professor);
            }
        }

        private void FormularioModalidade_Leave(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void mskPrecoHora_Click(object sender, EventArgs e)
        {
            mskPrecoHora.Focus();
        }
    }
}
