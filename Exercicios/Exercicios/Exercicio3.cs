using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicio3 : Form
    {
        int numero;
        public Exercicio3()
        {
            InitializeComponent();
        }
        private void ArmazenarNumero()
        {
            numero = int.Parse(txtTabuada.Text);
            txtTabuada.Text = "";
        }
        private void Tabuada()
        {
            lbxTabuada.Items.Clear();
            for (int i = 1; i < 11; i++)
            {
                lbxTabuada.Items.Add($"{numero} * {i} = {i * numero}");
            }
        }
        private void btnExitToMenu_Click(object sender, EventArgs e)
        {
            ChamarMenu();
        }
        private void ChamarMenu()
        {
            var menu = new Menu();
            this.Close();
            menu.Show();
        }
        private void btnTabuada_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            Tabuada();
        }
    }
}
