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
        List<string> nomeAluno, serieAluno, sexoAluno, primeiroResponsavel, segundoRespondavel, primeiroCPF, segundoCPF;
        List<DateTime> dataDeNascimento;
        bool registro;

      

        public CRUD()
        {
            InitializeComponent();
            nomeAluno = new List<string>();
            serieAluno = new List<string>();
            sexoAluno = new List<string>();
            primeiroCPF = new List<string>();
            segundoCPF = new List<string>();
            primeiroResponsavel = new List<string>();
            segundoRespondavel = new List<string>();
            dataDeNascimento = new List<DateTime>();
        }

        private void txtNomeAluno_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNomeAluno.Text))
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            registro = true;
            LimparValores();
        }

        private void lbxRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxRegistros.SelectedIndex >= 0)
            {
                MostrarValores();
                registro = false;
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (registro)
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
                foreach (var nome in nomeAluno)
                {
                    lbxRegistros.Items.Add(nome);
                }
            }
            else
            {
                AtualizarSelecionado();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DeletarSelecionado();
            btnNovo_Click(sender, e);
            btnDeletar.Enabled = false;
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
        }
        private void SalvarValores()
        {
            nomeAluno.Add(txtNomeAluno.Text);
            serieAluno.Add(cbxSerieAluno.SelectedItem.ToString());
            sexoAluno.Add(cbxSexoAluno.SelectedItem.ToString());
            primeiroCPF.Add(mtxtCpfPrimeiro.Text);
            segundoCPF.Add(mtxtCpfSegundo.Text);
            primeiroResponsavel.Add(txtNomeResponsavel.Text);
            segundoRespondavel.Add(txtNomeSegundoResponsavel.Text);
            dataDeNascimento.Add(dtpDataDeNascimento.Value);
        }
        private void DeletarSelecionado()
        {
            nomeAluno.RemoveAt(lbxRegistros.SelectedIndex);
            serieAluno.RemoveAt(lbxRegistros.SelectedIndex);
            sexoAluno.RemoveAt(lbxRegistros.SelectedIndex);
            primeiroCPF.RemoveAt(lbxRegistros.SelectedIndex);
            segundoCPF.RemoveAt(lbxRegistros.SelectedIndex);
            primeiroResponsavel.RemoveAt(lbxRegistros.SelectedIndex);
            segundoRespondavel.RemoveAt(lbxRegistros.SelectedIndex);
            dataDeNascimento.RemoveAt(lbxRegistros.SelectedIndex);
            lbxRegistros.Items.RemoveAt(lbxRegistros.SelectedIndex);
        }
        private void AtualizarSelecionado()
        {
            nomeAluno[lbxRegistros.SelectedIndex] = txtNomeAluno.Text;
            primeiroResponsavel[lbxRegistros.SelectedIndex] = txtNomeResponsavel.Text;
            segundoRespondavel[lbxRegistros.SelectedIndex] = txtNomeSegundoResponsavel.Text;
            primeiroCPF[lbxRegistros.SelectedIndex] = mtxtCpfPrimeiro.Text;
            segundoCPF[lbxRegistros.SelectedIndex] = mtxtCpfSegundo.Text;
            serieAluno[lbxRegistros.SelectedIndex] = cbxSerieAluno.SelectedItem.ToString();
            sexoAluno[lbxRegistros.SelectedIndex] = cbxSexoAluno.SelectedItem.ToString();
            dataDeNascimento[lbxRegistros.SelectedIndex] = dtpDataDeNascimento.Value;
        }
        private void LimparValores()
        {
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
        private void MostrarValores()
        {
            txtNomeAluno.Text = nomeAluno[lbxRegistros.SelectedIndex];
            txtNomeResponsavel.Text = primeiroResponsavel[lbxRegistros.SelectedIndex];
            txtNomeSegundoResponsavel.Text = segundoRespondavel[lbxRegistros.SelectedIndex];
            mtxtCpfPrimeiro.Text = primeiroCPF[lbxRegistros.SelectedIndex];
            mtxtCpfSegundo.Text = segundoCPF[lbxRegistros.SelectedIndex];
            cbxSerieAluno.SelectedItem = serieAluno[lbxRegistros.SelectedIndex];
            cbxSexoAluno.SelectedItem = sexoAluno[lbxRegistros.SelectedIndex];
            dtpDataDeNascimento.Value = dataDeNascimento[lbxRegistros.SelectedIndex];
        }
    }
}