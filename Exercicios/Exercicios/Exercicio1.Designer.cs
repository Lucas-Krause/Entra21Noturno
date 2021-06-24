
namespace Exercicios
{
    partial class Exercicio1
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
            this.cmsMenuNivel1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuNivel2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMenuNivel3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnBotao = new System.Windows.Forms.Button();
            this.btnExitToMenu = new System.Windows.Forms.Button();
            this.cmsMenuNivel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMenuNivel1
            // 
            this.cmsMenuNivel1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicio1ToolStripMenuItem});
            this.cmsMenuNivel1.Name = "cmsMenuNivel1";
            this.cmsMenuNivel1.Size = new System.Drawing.Size(131, 26);
            // 
            // exercicio1ToolStripMenuItem
            // 
            this.exercicio1ToolStripMenuItem.Name = "exercicio1ToolStripMenuItem";
            this.exercicio1ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.exercicio1ToolStripMenuItem.Text = "Exercicio 1";
            // 
            // cmsMenuNivel2
            // 
            this.cmsMenuNivel2.Name = "cmsMenuNivel2";
            this.cmsMenuNivel2.Size = new System.Drawing.Size(61, 4);
            // 
            // cmsMenuNivel3
            // 
            this.cmsMenuNivel3.Name = "cmsMenuNivel3";
            this.cmsMenuNivel3.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox.Location = new System.Drawing.Point(128, 65);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(250, 126);
            this.txtBox.TabIndex = 4;
            // 
            // btnBotao
            // 
            this.btnBotao.BackColor = System.Drawing.Color.Gray;
            this.btnBotao.Location = new System.Drawing.Point(222, 308);
            this.btnBotao.Name = "btnBotao";
            this.btnBotao.Size = new System.Drawing.Size(61, 35);
            this.btnBotao.TabIndex = 5;
            this.btnBotao.Text = "Executar";
            this.btnBotao.UseVisualStyleBackColor = false;
            this.btnBotao.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // btnExitToMenu
            // 
            this.btnExitToMenu.BackColor = System.Drawing.Color.Tomato;
            this.btnExitToMenu.Location = new System.Drawing.Point(423, 409);
            this.btnExitToMenu.Name = "btnExitToMenu";
            this.btnExitToMenu.Size = new System.Drawing.Size(89, 29);
            this.btnExitToMenu.TabIndex = 6;
            this.btnExitToMenu.Text = "Exit to Menu";
            this.btnExitToMenu.UseVisualStyleBackColor = false;
            this.btnExitToMenu.Click += new System.EventHandler(this.btnExitToMenu_Click);
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.btnExitToMenu);
            this.Controls.Add(this.btnBotao);
            this.Controls.Add(this.txtBox);
            this.Name = "Exercicio1";
            this.Text = "Exercicio 1";
            this.cmsMenuNivel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsMenuNivel1;
        private System.Windows.Forms.ToolStripMenuItem exercicio1ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMenuNivel2;
        private System.Windows.Forms.ContextMenuStrip cmsMenuNivel3;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnBotao;
        private System.Windows.Forms.Button btnExitToMenu;
    }
}