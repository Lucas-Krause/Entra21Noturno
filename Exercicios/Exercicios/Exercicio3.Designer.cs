
namespace Exercicios
{
    partial class Exercicio3
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
            this.txtTabuada = new System.Windows.Forms.TextBox();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.lbxTabuada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExitToMenu
            // 
            this.btnExitToMenu.BackColor = System.Drawing.Color.Tomato;
            this.btnExitToMenu.Location = new System.Drawing.Point(423, 409);
            this.btnExitToMenu.Name = "btnExitToMenu";
            this.btnExitToMenu.Size = new System.Drawing.Size(89, 29);
            this.btnExitToMenu.TabIndex = 8;
            this.btnExitToMenu.Text = "Exit to Menu";
            this.btnExitToMenu.UseVisualStyleBackColor = false;
            this.btnExitToMenu.Click += new System.EventHandler(this.btnExitToMenu_Click);
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Location = new System.Drawing.Point(38, 81);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(248, 15);
            this.lbLabel.TabIndex = 9;
            this.lbLabel.Text = "Digite um numero para receber a sua tabuada";
            // 
            // txtTabuada
            // 
            this.txtTabuada.Location = new System.Drawing.Point(47, 99);
            this.txtTabuada.Name = "txtTabuada";
            this.txtTabuada.Size = new System.Drawing.Size(69, 23);
            this.txtTabuada.TabIndex = 10;
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(47, 128);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(69, 23);
            this.btnTabuada.TabIndex = 11;
            this.btnTabuada.Text = "Executar";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // lbxTabuada
            // 
            this.lbxTabuada.BackColor = System.Drawing.SystemColors.Control;
            this.lbxTabuada.FormattingEnabled = true;
            this.lbxTabuada.ItemHeight = 15;
            this.lbxTabuada.Location = new System.Drawing.Point(222, 169);
            this.lbxTabuada.Name = "lbxTabuada";
            this.lbxTabuada.Size = new System.Drawing.Size(87, 154);
            this.lbxTabuada.TabIndex = 12;
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.lbxTabuada);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.txtTabuada);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.btnExitToMenu);
            this.Name = "Exercicio3";
            this.Text = "Exercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitToMenu;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.TextBox txtTabuada;
        private System.Windows.Forms.Button btnTabuada;
        private System.Windows.Forms.ListBox lbxTabuada;
    }
}