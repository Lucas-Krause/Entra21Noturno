using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exerc1 = new Exercicio1();
            exerc1.Show();
        }      
        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exerc2 = new Exercicio2();
            exerc2.Show();
        }
        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exerc3 = new Exercicio3();
            exerc3.Show();
        }
        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exerc4 = new Exercicio4();
            exerc4.Show();
        }
        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var exerc5 = new Exercicio5();
            exerc5.Show();
        }
        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

       
    }
}
