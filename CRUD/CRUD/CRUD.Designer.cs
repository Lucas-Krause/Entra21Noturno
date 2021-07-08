
namespace CRUD
{
    partial class CRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lbxRegistros = new System.Windows.Forms.ListBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtCpfPrimeiro = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxSerieAluno = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeSegundoResponsavel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtCpfSegundo = new System.Windows.Forms.MaskedTextBox();
            this.cbxSexoAluno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "Nome do aluno completo:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(8, 26);
            this.txtNomeAluno.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(200, 23);
            this.txtNomeAluno.TabIndex = 0;
          
            // 
            // lbxRegistros
            // 
            this.lbxRegistros.FormattingEnabled = true;
            this.lbxRegistros.ItemHeight = 15;
            this.lbxRegistros.Location = new System.Drawing.Point(358, 5);
            this.lbxRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.lbxRegistros.Name = "lbxRegistros";
            this.lbxRegistros.Size = new System.Drawing.Size(327, 169);
            this.lbxRegistros.TabIndex = 50;
            this.lbxRegistros.SelectedIndexChanged += new System.EventHandler(this.lbxRegistros_SelectedIndexChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(478, 178);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(53, 26);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(545, 178);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 26);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(609, 178);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(53, 26);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sexo aluno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data de nascimento:";
            // 
            // mtxtCpfPrimeiro
            // 
            this.mtxtCpfPrimeiro.Location = new System.Drawing.Point(7, 266);
            this.mtxtCpfPrimeiro.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtCpfPrimeiro.Mask = "000,000,000-00";
            this.mtxtCpfPrimeiro.Name = "mtxtCpfPrimeiro";
            this.mtxtCpfPrimeiro.Size = new System.Drawing.Size(103, 23);
            this.mtxtCpfPrimeiro.TabIndex = 5;
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(9, 74);
            this.dtpDataDeNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataDeNascimento.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(86, 23);
            this.dtpDataDeNascimento.TabIndex = 1;
            this.dtpDataDeNascimento.Value = new System.DateTime(2021, 6, 30, 0, 0, 0, 0);
    
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Série do aluno:";
            // 
            // cbxSerieAluno
            // 
            this.cbxSerieAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxSerieAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSerieAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSerieAluno.FormattingEnabled = true;
            this.cbxSerieAluno.Items.AddRange(new object[] {
            "1º Ano",
            "2º Ano",
            "3º Ano",
            "4º Ano",
            "5º Ano",
            "6º Ano",
            "7º Ano",
            "8º Ano",
            "9º Ano"});
            this.cbxSerieAluno.Location = new System.Drawing.Point(8, 122);
            this.cbxSerieAluno.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSerieAluno.Name = "cbxSerieAluno";
            this.cbxSerieAluno.Size = new System.Drawing.Size(71, 23);
            this.cbxSerieAluno.TabIndex = 2;

            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(7, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nome do responsavel:";
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.Location = new System.Drawing.Point(7, 218);
            this.txtNomeResponsavel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(200, 23);
            this.txtNomeResponsavel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(9, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(211, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome do segundo responsavel:";
            // 
            // txtNomeSegundoResponsavel
            // 
            this.txtNomeSegundoResponsavel.Location = new System.Drawing.Point(211, 218);
            this.txtNomeSegundoResponsavel.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeSegundoResponsavel.Name = "txtNomeSegundoResponsavel";
            this.txtNomeSegundoResponsavel.Size = new System.Drawing.Size(197, 23);
            this.txtNomeSegundoResponsavel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(211, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "CPF:";
            // 
            // mtxtCpfSegundo
            // 
            this.mtxtCpfSegundo.Location = new System.Drawing.Point(209, 266);
            this.mtxtCpfSegundo.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtCpfSegundo.Mask = "000,000,000-00";
            this.mtxtCpfSegundo.Name = "mtxtCpfSegundo";
            this.mtxtCpfSegundo.Size = new System.Drawing.Size(103, 23);
            this.mtxtCpfSegundo.TabIndex = 7;
            // 
            // cbxSexoAluno
            // 
            this.cbxSexoAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxSexoAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSexoAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexoAluno.FormattingEnabled = true;
            this.cbxSexoAluno.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbxSexoAluno.Location = new System.Drawing.Point(8, 170);
            this.cbxSexoAluno.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSexoAluno.Name = "cbxSexoAluno";
            this.cbxSexoAluno.Size = new System.Drawing.Size(86, 23);
            this.cbxSexoAluno.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 15);
            this.label9.TabIndex = 24;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "*";
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 300);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxSexoAluno);
            this.Controls.Add(this.mtxtCpfSegundo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeSegundoResponsavel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNomeResponsavel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxSerieAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataDeNascimento);
            this.Controls.Add(this.mtxtCpfPrimeiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbxRegistros);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.ListBox lbxRegistros;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxtCpfPrimeiro;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxSerieAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeResponsavel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeSegundoResponsavel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtCpfSegundo;
        private System.Windows.Forms.ComboBox cbxSexoAluno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

