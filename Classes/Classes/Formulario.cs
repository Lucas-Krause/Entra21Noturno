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
        public Formulario()
        {
            InitializeComponent();
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.numero = 1;
            conta.titular = "Lucas";
            conta.saldo = 2000.0;
            MessageBox.Show($"Numero = {conta.numero}, Titular = {conta.titular}, Saldo = {conta.saldo}");
            conta.Sacar(45.5);
           
        }
    }
}
