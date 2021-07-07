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
        public Formulario()
        {
            InitializeComponent();
            academia = new Academia();
        }
        private void Formulario_Load(object sender, EventArgs e)
        {
            btnAdicionar_Click(sender, e);
        }
        private void lbxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAlunos.SelectedIndex >= 0)
            {
                txtNome.Text = academia.ListaAlunos[lbxAlunos.SelectedIndex].Nome;
                mskTelefone.Text = academia.ListaAlunos[lbxAlunos.SelectedIndex].Telefone;
                mskCPF.Text = academia.ListaAlunos[lbxAlunos.SelectedIndex].CPF;
                cbxTurno.SelectedItem = academia.ListaAlunos[lbxAlunos.SelectedIndex].Turno;
                cbxModalidade.SelectedItem = academia.ListaAlunos[lbxAlunos.SelectedIndex].Modalidade;
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            txtNome.Text = "";
            mskTelefone.Text = "";
            mskCPF.Text = "";
            cbxTurno.SelectedItem = null;
            cbxModalidade.SelectedItem = null;
            novo = true;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                academia.AdicionarAluno(
                    txtNome.Text,
                    mskTelefone.Text,
                    mskCPF.Text,
                    cbxTurno.SelectedItem.ToString(),
                    cbxModalidade.SelectedItem.ToString());
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
            novo = false;
            AtualizarListaAlunos();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lbxAlunos.SelectedIndex >= 0)
            {
                academia.DeletarAluno(lbxAlunos.SelectedIndex);
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

    }
}
