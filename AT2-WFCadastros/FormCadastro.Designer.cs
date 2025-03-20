namespace AT2_WFCadastros
{
    partial class FormCadastro
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            gbxStatus = new GroupBox();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            txtNome = new TextBox();
            label1 = new Label();
            lblDescricao = new Label();
            textBox1 = new TextBox();
            gbxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(25, 29);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(25, 47);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // gbxStatus
            // 
            gbxStatus.Controls.Add(rdbInativo);
            gbxStatus.Controls.Add(rdbAtivo);
            gbxStatus.Location = new Point(170, 12);
            gbxStatus.Name = "gbxStatus";
            gbxStatus.Size = new Size(198, 58);
            gbxStatus.TabIndex = 2;
            gbxStatus.TabStop = false;
            gbxStatus.Text = "Status";
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(17, 22);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(93, 22);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 130);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(343, 23);
            txtNome.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 112);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome do Produto:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(25, 167);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(124, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição do Produto:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 185);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 137);
            textBox1.TabIndex = 6;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 450);
            Controls.Add(textBox1);
            Controls.Add(lblDescricao);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(gbxStatus);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            gbxStatus.ResumeLayout(false);
            gbxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private GroupBox gbxStatus;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private TextBox txtNome;
        private Label label1;
        private Label lblDescricao;
        private TextBox textBox1;
    }
}