using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma(object sender, EventArgs e)
        {
            MessageBox.Show($"O resultado é: {int.Parse(textnumero1.Text) + int.Parse(txtnumero2.Text)}");
        }

        private void btnSubtracao(object sender, EventArgs e)
        {
            MessageBox.Show($"O resultado é: {int.Parse(textnumero1.Text) - int.Parse(txtnumero2.Text)}");
        }

        private void btnMultiplicacao(object sender, EventArgs e)
        {
            MessageBox.Show($"O resultado é: {int.Parse(textnumero1.Text) * int.Parse(txtnumero2.Text)}");
        }

        private void btnDivisao(object sender, EventArgs e)
        {
            MessageBox.Show($"O resultado é: {int.Parse(textnumero1.Text) / int.Parse(txtnumero2.Text)}");
        }
    }
}
