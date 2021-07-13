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
        FormularioAluno _formAluno;
        bool novo;
        bool verificacao;
        string mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";

        private void mskCPF_Click(object sender, EventArgs e)
        {
            mskPrecoHora.Focus();
        }

        public FormularioModalidade(Academia academiaPai, FormularioAluno formularioAluno)
        {
            InitializeComponent();
            _academia = academiaPai;
            _formAluno = formularioAluno;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparDados();
            novo = true;
            txtNome.Focus();
            btnDeletar.Enabled = false;
            btnSalvar.Enabled = false;
            if (_academia.ListaModalidades.Count > 0)
            {
                _formAluno.Enabled = true;
            }
            else
            {
                _formAluno.Enabled = false;
            }
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
                    AtualizarListaModalidades();
                    btnNovo_Click(sender, e);
                    if (_formAluno.Enabled)
                    {
                        _formAluno.Focus();
                    }
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
                    AtualizarListaModalidades();
                    btnNovo_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show(mensagemDeErro);
                mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";
            }
        }
        
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lbxModalidades.SelectedIndex >= 0)
            {
                _academia.DeletarModalidade(lbxModalidades.SelectedIndex);
            }
            AtualizarListaModalidades();
            btnNovo_Click(sender, e);
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

       
    }
}
