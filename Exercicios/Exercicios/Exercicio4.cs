using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicio4 : Form
    {
        int numero;
        int somaPar = 0;
        int somaImpar = 0;
        bool par;
        public Exercicio4()
        {
            InitializeComponent();
        }
        private void ArmazenarNumero()
        {
            numero = int.Parse(txtNumeros.Text);
            txtNumeros.Text = "";
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
        private void Soma()
        {
            if (numero % 2 == 0)
            {
                somaPar += numero;
                par = true;
            }
            else
            {
                somaImpar += numero;
                par = false;
            }
        }
        private void MostrarNumero()
        {
            if (par)
            {
                lbxResultado.Items.Add($"{numero} eh par!");
            }
            else
            {
                lbxResultado.Items.Add($"{numero} eh impar!");
            }
        }
        private void MostrarSomas()
        {
            lbxResultado.Items.Add($"A soma dos numeros pares eh: {somaPar}");
            lbxResultado.Items.Add($"A soma dos numeros impares eh: {somaImpar}");
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            ArmazenarNumero();
            Soma();
            lbxResultado.Items.Clear();
            MostrarNumero();
            MostrarSomas();
        }
    }
}
