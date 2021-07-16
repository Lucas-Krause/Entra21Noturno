
namespace Classes
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnModalidade = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.CausesValidation = false;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(569, 269);
            this.pnlFormulario.TabIndex = 4;
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(13, 276);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(93, 48);
            this.btnProfessor.TabIndex = 6;
            this.btnProfessor.Text = "Formulario Professor";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnModalidade
            // 
            this.btnModalidade.Location = new System.Drawing.Point(112, 276);
            this.btnModalidade.Name = "btnModalidade";
            this.btnModalidade.Size = new System.Drawing.Size(93, 48);
            this.btnModalidade.TabIndex = 7;
            this.btnModalidade.Text = "Formulario Modalidade";
            this.btnModalidade.UseVisualStyleBackColor = true;
            this.btnModalidade.Click += new System.EventHandler(this.btnModalidade_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(211, 276);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(93, 48);
            this.btnAluno.TabIndex = 8;
            this.btnAluno.Text = "Formulario Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 125);
            this.panel1.TabIndex = 10;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(524, 336);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnModalidade);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnModalidade;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Panel panel1;
    }
}



