using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }
        private string Texto()
        {
            string texto = "";
            for (int i = 1; i < 101; i++)
            {
                texto += $"{i} ";
            }
            return texto;
        }
        private void btnBotao_Click(object sender, EventArgs e)
        {
            this.txtBox.Text = Texto();
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
    }
}
