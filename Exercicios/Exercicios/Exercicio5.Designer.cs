
namespace Exercicios
{
    partial class Exercicio5
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
            this.txtNomeDoAluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotaAluno = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbxInformacoesAlunos = new System.Windows.Forms.ListBox();
            this.txtMediaTurma = new System.Windows.Forms.TextBox();
            this.txtNumeroAlunos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExitToMenu
            // 
            this.btnExitToMenu.BackColor = System.Drawing.Color.Tomato;
            this.btnExitToMenu.Location = new System.Drawing.Point(423, 409);
            this.btnExitToMenu.Name = "btnExitToMenu";
            this.btnExitToMenu.Size = new System.Drawing.Size(89, 29);
            this.btnExitToMenu.TabIndex = 10;
            this.btnExitToMenu.Text = "Exit to Menu";
            this.btnExitToMenu.UseVisualStyleBackColor = false;
            this.btnExitToMenu.Click += new System.EventHandler(this.btnExitToMenu_Click);
            // 
            // txtNomeDoAluno
            // 
            this.txtNomeDoAluno.Location = new System.Drawing.Point(24, 138);
            this.txtNomeDoAluno.Name = "txtNomeDoAluno";
            this.txtNomeDoAluno.Size = new System.Drawing.Size(100, 23);
            this.txtNomeDoAluno.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Digite o nome do aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Digite a nota do aluno";
            // 
            // txtNotaAluno
            // 
            this.txtNotaAluno.Location = new System.Drawing.Point(24, 188);
            this.txtNotaAluno.Name = "txtNotaAluno";
            this.txtNotaAluno.Size = new System.Drawing.Size(100, 23);
            this.txtNotaAluno.TabIndex = 14;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(24, 217);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbxInformacoesAlunos
            // 
            this.lbxInformacoesAlunos.BackColor = System.Drawing.SystemColors.Control;
            this.lbxInformacoesAlunos.FormattingEnabled = true;
            this.lbxInformacoesAlunos.ItemHeight = 15;
            this.lbxInformacoesAlunos.Location = new System.Drawing.Point(202, 12);
            this.lbxInformacoesAlunos.Name = "lbxInformacoesAlunos";
            this.lbxInformacoesAlunos.Size = new System.Drawing.Size(120, 199);
            this.lbxInformacoesAlunos.TabIndex = 16;
            // 
            // txtMediaTurma
            // 
            this.txtMediaTurma.Location = new System.Drawing.Point(202, 217);
            this.txtMediaTurma.Name = "txtMediaTurma";
            this.txtMediaTurma.ReadOnly = true;
            this.txtMediaTurma.Size = new System.Drawing.Size(179, 23);
            this.txtMediaTurma.TabIndex = 17;
            // 
            // txtNumeroAlunos
            // 
            this.txtNumeroAlunos.Location = new System.Drawing.Point(24, 88);
            this.txtNumeroAlunos.Name = "txtNumeroAlunos";
            this.txtNumeroAlunos.Size = new System.Drawing.Size(100, 23);
            this.txtNumeroAlunos.TabIndex = 18;
            this.txtNumeroAlunos.TextChanged += new System.EventHandler(this.txtNumeroAlunos_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quantos alunos tem?";
            // 
            // lbMensagem
            // 
            this.lbMensagem.AutoSize = true;
            this.lbMensagem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMensagem.Location = new System.Drawing.Point(105, 221);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(0, 19);
            this.lbMensagem.TabIndex = 20;
            // 
            // Exercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroAlunos);
            this.Controls.Add(this.txtMediaTurma);
            this.Controls.Add(this.lbxInformacoesAlunos);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtNotaAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeDoAluno);
            this.Controls.Add(this.btnExitToMenu);
            this.Name = "Exercicio5";
            this.Text = "Exercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitToMenu;
        private System.Windows.Forms.TextBox txtNomeDoAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotaAluno;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ListBox lbxInformacoesAlunos;
        private System.Windows.Forms.TextBox txtMediaTurma;
        private System.Windows.Forms.TextBox txtNumeroAlunos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMensagem;
    }
}