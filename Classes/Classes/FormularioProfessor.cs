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
    public partial class FormularioProfessor : Form
    {
        readonly Academia _academia;
        bool novo;
        bool verificacao;
        string nome = "";
        string mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";

        public FormularioProfessor()
        {
            InitializeComponent();
            _academia = Academia.Instancia;
        }

        private void FormularioProfessor_Load(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
            AtualizarListaProfessores();
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
                    _academia.AdicionarProfessor(
                        txtNome.Text,
                        mskTelefone.Text,
                        mskCPF.Text,
                        cbxTurno.SelectedItem.ToString(),
                        double.Parse(mskSalarioHora.Text.Substring(4)));
                    btnNovo_Click(sender, e);
                    novo = false;
                }
                else
                {
                    if (lbxProfessores.SelectedIndex >= 0)
                    {
                        _academia.EditarProfessor(
                            lbxProfessores.SelectedIndex,
                            txtNome.Text,
                            mskTelefone.Text,
                            mskCPF.Text,
                            cbxTurno.SelectedItem.ToString(),
                            double.Parse(mskSalarioHora.Text.Substring(4)));
                    }
                    btnNovo_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show(mensagemDeErro);
                mensagemDeErro = "Os dados a seguir não foram preenchidos\npor favor os preencha";
            }
            AtualizarListaProfessores();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int indice = lbxProfessores.SelectedIndex;
            bool verificarDelete = true;
            if (indice >= 0)
            {
                foreach (var modalidade in _academia.ListaModalidades)
                {
                    if (modalidade.Professor.CPF == _academia.ListaProfessores[indice].CPF)
                    {
                        nome += $"\n--> {modalidade.Nome}";
                        verificarDelete = false;
                    }
                }
                if (verificarDelete)
                {
                    _academia.DeletarProfessor(indice);
                    btnNovo_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Você não pode deletar um professor já cadastrado em uma modalidade\n" +
                        $"por favor altere o professor da(s) seguinte(s) modalidade(s) {nome}");
                    nome = "";
                    btnNovo_Click(sender, e);
                }
            }
            AtualizarListaProfessores();    
        }

        private void lbxProfessores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = lbxProfessores.SelectedIndex;
            if (indice >= 0)
            {
                txtNome.Text = _academia.ListaProfessores[indice].Nome;
                mskTelefone.Text = _academia.ListaProfessores[indice].Telefone;
                mskCPF.Text = _academia.ListaProfessores[indice].CPF;
                cbxTurno.SelectedItem = _academia.ListaProfessores[indice].Turno;
                mskSalarioHora.Text = _academia.ListaProfessores[indice].SalarioHora.ToString();
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
                novo = false;
            }
        }
        
        private void cbxTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTurno.SelectedItem != null)
            {
                btnSalvar.Enabled = true;
            }
        }

        private void AtualizarListaProfessores()
        {
            lbxProfessores.Items.Clear();
            foreach (var professor in _academia.ListaProfessores)
            {
                lbxProfessores.Items.Add(professor);
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
            if (String.IsNullOrEmpty(mskSalarioHora.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n--> Salario/H.";
            }
            return verificacao;
        }

        private void LimparDados()
        {
            txtNome.Clear();
            mskSalarioHora.Clear();
            mskTelefone.Clear();
            mskCPF.Clear();
            cbxTurno.SelectedItem = null;
        }

        private void mskTelefone_Click(object sender, EventArgs e)
        {
            mskTelefone.Focus();
        }

        private void mskSalarioHora_Click(object sender, EventArgs e)
        {
            mskSalarioHora.Focus();
        }

        private void mskCPF_Click(object sender, EventArgs e)
        {
            mskCPF.Focus();
        }
    }
}
