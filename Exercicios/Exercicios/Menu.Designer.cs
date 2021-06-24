
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
            this.exercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuNivel2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsMenuNivel3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.btnExit = new System.Windows.Forms.Button();
            this.exercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuNivel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMenuNivel1
            // 
            this.cmsMenuNivel1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicio1ToolStripMenuItem,
            this.exercicio2ToolStripMenuItem,
            this.exercicio3ToolStripMenuItem});
            this.cmsMenuNivel1.Name = "cmsMenuNivel1";
            this.cmsMenuNivel1.Size = new System.Drawing.Size(181, 92);
            // 
            // exercicio1ToolStripMenuItem
            // 
            this.exercicio1ToolStripMenuItem.Name = "exercicio1ToolStripMenuItem";
            this.exercicio1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicio1ToolStripMenuItem.Text = "Exercicio 1";
            this.exercicio1ToolStripMenuItem.Click += new System.EventHandler(this.exercicio1ToolStripMenuItem_Click);
            // 
            // exercicio2ToolStripMenuItem
            // 
            this.exercicio2ToolStripMenuItem.Name = "exercicio2ToolStripMenuItem";
            this.exercicio2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicio2ToolStripMenuItem.Text = "Exercicio 2";
            this.exercicio2ToolStripMenuItem.Click += new System.EventHandler(this.exercicio2ToolStripMenuItem_Click);
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
            this.tvMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tvMenu.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvMenu.Location = new System.Drawing.Point(90, 76);
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
            this.tvMenu.Size = new System.Drawing.Size(87, 85);
            this.tvMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.Location = new System.Drawing.Point(229, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // exercicio3ToolStripMenuItem
            // 
            this.exercicio3ToolStripMenuItem.Name = "exercicio3ToolStripMenuItem";
            this.exercicio3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercicio3ToolStripMenuItem.Text = "Exercicio 3";
            this.exercicio3ToolStripMenuItem.Click += new System.EventHandler(this.exercicio3ToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 245);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tvMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.cmsMenuNivel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsMenuNivel1;
        private System.Windows.Forms.ContextMenuStrip cmsMenuNivel2;
        private System.Windows.Forms.ContextMenuStrip cmsMenuNivel3;
        private System.Windows.Forms.ToolStripMenuItem exercicio1ToolStripMenuItem;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem exercicio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio3ToolStripMenuItem;
    }
}

