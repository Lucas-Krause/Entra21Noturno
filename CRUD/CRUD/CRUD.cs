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


        public CRUD()
        {
            InitializeComponent();
            registros = new List<Registro>();

        }
        /*
        private void txtNomeAluno_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNomeAluno.Text))
            {
                MessageBox.Show("Por favor informe o nome do aluno!");
                txtNomeAluno.Focus();
            }
        }

        private void dtpDataDeNascimento_Leave(object sender, EventArgs e)
        {
            if (dtpDataDeNascimento.Value.Equals(DateTime.Today))
            {
                MessageBox.Show("Por favor informe a data de nascimento do aluno!");
                dtpDataDeNascimento.Focus();
            }
        }

        private void cbxSerieAluno_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbxSerieAluno.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor informe qual serie o aluno pertence!");
                cbxSerieAluno.Focus();
            }
        }
        */
        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            txtNomeAluno.Text = "";
            txtNomeResponsavel.Text = "";
            txtNomeSegundoResponsavel.Text = "";
            mtxtCpfPrimeiro.Text = "";
            mtxtCpfSegundo.Text = "";
            cbxSerieAluno.SelectedItem = null;
            cbxSexoAluno.SelectedItem = null;
            dtpDataDeNascimento.Value = DateTime.Today;
            txtNomeAluno.Focus();
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = false;
            lbxRegistros.SelectedIndex = -1;
        }

        private void lbxRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxRegistros.SelectedIndex >= 0)
            {
                txtNomeAluno.Text = registros[lbxRegistros.SelectedIndex].Nome;
                txtNomeResponsavel.Text = registros[lbxRegistros.SelectedIndex].NomeResponsavelUm;
                txtNomeSegundoResponsavel.Text = registros[lbxRegistros.SelectedIndex].NomeResponsavelDois;
                mtxtCpfPrimeiro.Text = registros[lbxRegistros.SelectedIndex].PrimeiroCPF;
                mtxtCpfSegundo.Text = registros[lbxRegistros.SelectedIndex].SegundoCPF;
                cbxSerieAluno.SelectedItem = registros[lbxRegistros.SelectedIndex].Serie;
                cbxSexoAluno.SelectedItem = registros[lbxRegistros.SelectedIndex].Sexo;
                dtpDataDeNascimento.Value = registros[lbxRegistros.SelectedIndex].DataDeNascimento;
                novo = false;
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                if (!String.IsNullOrEmpty(txtNomeAluno.Text) && !dtpDataDeNascimento.Value.Equals(DateTime.Today) && !String.IsNullOrEmpty(cbxSerieAluno.SelectedItem.ToString()))
                {

                    if (String.IsNullOrEmpty(txtNomeResponsavel.Text) || String.IsNullOrEmpty(mtxtCpfPrimeiro.Text))
                    {
                        if (String.IsNullOrEmpty(txtNomeSegundoResponsavel.Text) || String.IsNullOrEmpty(mtxtCpfSegundo.Text))
                        {
                            MessageBox.Show("Por favor infome o nome e o CPF de pelo menos um responsável!");
                        }
                        else
                        {
                            SalvarValores();
                        }
                    }
                    else
                    {
                        SalvarValores();
                    }
                }
                else
                {
                    MessageBox.Show("Há campos obrigatórios de dados do aluno em branco!");
                }
                lbxRegistros.Items.Clear();
                foreach (var contato in registros)
                {
                    lbxRegistros.Items.Add(contato);
                }
            }
            else
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
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            registros.RemoveAt(lbxRegistros.SelectedIndex);
            lbxRegistros.Items.RemoveAt(lbxRegistros.SelectedIndex);
            btnNovo_Click(sender, e);
            btnDeletar.Enabled = false;
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
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
    }
}