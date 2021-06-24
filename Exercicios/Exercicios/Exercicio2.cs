using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exercicios;

namespace Exercicios
{
    public partial class Exercicio2 : Form
    {
        int numero;
        public Exercicio2()
        {
            InitializeComponent();
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
        private void btnFatorar_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            lbxNumerosFatorados.Items.Add(Fatorar(numero));
        }
        private void ArmazenarNumero()
        {
            numero = int.Parse(txtNumero.Text);
            txtNumero.Text = "";
        }
        private int Fatorar(int numero)
        {
            for (int i = numero - 1; i > 1; i--)
            {
                numero = numero * i;
            }
            return numero;
        }
    }
}
