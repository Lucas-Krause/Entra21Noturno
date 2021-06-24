
namespace Exercicios
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nivel 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nivel 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nivel 3");
            this.cmsMenuNivel1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuNivel2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMenuNivel3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tvMenu = new System.Windows.Forms.TreeView();
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
            this.exercicio1ToolStripMenuItem.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem_Click);
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
            // tvMenu
            // 
            this.tvMenu.Location = new System.Drawing.Point(12, 12);
            this.tvMenu.Name = "tvMenu";
            treeNode1.ContextMenuStrip = this.cmsMenuNivel1;
            treeNode1.Name = "Node0";
            treeNode1.Text = "Nivel 1";
            treeNode2.ContextMenuStrip = this.cmsMenuNivel2;
            treeNode2.Name = "Node1";
            treeNode2.Text = "Nivel 2";
            treeNode3.ContextMenuStrip = this.cmsMenuNivel3;
            treeNode3.Name = "Node2";
            treeNode3.Text = "Nivel 3";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.tvMenu.Size = new System.Drawing.Size(76, 59);
            this.tvMenu.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvMenu);
            this.Name = "Menu";
            this.Text = "Form1";
            this.cmsMenuNivel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.ContextMenuStrip cmsMenuNivel1;
        private System.Windows.Forms.ContextMenuStrip cmsMenuNivel2;
        private System.Windows.Forms.ContextMenuStrip cmsMenuNivel3;
        private System.Windows.Forms.ToolStripMenuItem exercicio1ToolStripMenuItem;
    }
}

