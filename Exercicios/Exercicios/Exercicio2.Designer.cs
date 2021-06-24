
namespace Exercicios
{
    partial class Exercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExitToMenu = new System.Windows.Forms.Button();
            this.lbLabel = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnFatorar = new System.Windows.Forms.Button();
            this.lbxNumerosFatorados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExitToMenu
            // 
            this.btnExitToMenu.BackColor = System.Drawing.Color.Tomato;
            this.btnExitToMenu.Location = new System.Drawing.Point(423, 409);
            this.btnExitToMenu.Name = "btnExitToMenu";
            this.btnExitToMenu.Size = new System.Drawing.Size(89, 29);
            this.btnExitToMenu.TabIndex = 7;
            this.btnExitToMenu.Text = "Exit to Menu";
            this.btnExitToMenu.UseVisualStyleBackColor = false;
            this.btnExitToMenu.Click += new System.EventHandler(this.btnExitToMenu_Click);
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Location = new System.Drawing.Point(56, 85);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(194, 15);
            this.lbLabel.TabIndex = 8;
            this.lbLabel.Text = "Informe qual numero deseja fatorar";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(66, 103);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(54, 23);
            this.txtNumero.TabIndex = 0;
            // 
            // btnFatorar
            // 
            this.btnFatorar.Location = new System.Drawing.Point(66, 132);
            this.btnFatorar.Name = "btnFatorar";
            this.btnFatorar.Size = new System.Drawing.Size(54, 23);
            this.btnFatorar.TabIndex = 1;
            this.btnFatorar.Text = "Fatorar";
            this.btnFatorar.UseVisualStyleBackColor = true;
            this.btnFatorar.Click += new System.EventHandler(this.btnFatorar_Click);
            // 
            // lbxNumerosFatorados
            // 
            this.lbxNumerosFatorados.BackColor = System.Drawing.SystemColors.Control;
            this.lbxNumerosFatorados.FormattingEnabled = true;
            this.lbxNumerosFatorados.ItemHeight = 15;
            this.lbxNumerosFatorados.Location = new System.Drawing.Point(170, 132);
            this.lbxNumerosFatorados.Name = "lbxNumerosFatorados";
            this.lbxNumerosFatorados.Size = new System.Drawing.Size(174, 184);
            this.lbxNumerosFatorados.TabIndex = 11;
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.lbxNumerosFatorados);
            this.Controls.Add(this.btnFatorar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.btnExitToMenu);
            this.Name = "Exercicio2";
            this.Text = "Exercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitToMenu;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnFatorar;
        private System.Windows.Forms.ListBox lbxNumerosFatorados;
    }
}