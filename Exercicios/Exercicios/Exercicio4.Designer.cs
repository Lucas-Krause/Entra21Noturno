
namespace Exercicios
{
    partial class Exercicio4
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.lbLabel = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbxResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExitToMenu
            // 
            this.btnExitToMenu.BackColor = System.Drawing.Color.Tomato;
            this.btnExitToMenu.Location = new System.Drawing.Point(423, 409);
            this.btnExitToMenu.Name = "btnExitToMenu";
            this.btnExitToMenu.Size = new System.Drawing.Size(89, 29);
            this.btnExitToMenu.TabIndex = 9;
            this.btnExitToMenu.Text = "Exit to Menu";
            this.btnExitToMenu.UseVisualStyleBackColor = false;
            this.btnExitToMenu.Click += new System.EventHandler(this.btnExitToMenu_Click);
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(205, 365);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(100, 23);
            this.txtNumeros.TabIndex = 10;
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Location = new System.Drawing.Point(201, 347);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(104, 15);
            this.lbLabel.TabIndex = 11;
            this.lbLabel.Text = "Digite um numero";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(217, 394);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbxResultado
            // 
            this.lbxResultado.BackColor = System.Drawing.SystemColors.Control;
            this.lbxResultado.FormattingEnabled = true;
            this.lbxResultado.ItemHeight = 15;
            this.lbxResultado.Location = new System.Drawing.Point(138, 176);
            this.lbxResultado.Name = "lbxResultado";
            this.lbxResultado.Size = new System.Drawing.Size(220, 64);
            this.lbxResultado.TabIndex = 13;
            // 
            // Exercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.lbxResultado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lbLabel);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.btnExitToMenu);
            this.Name = "Exercicio4";
            this.Text = "Exercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitToMenu;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lbxResultado;
    }
}