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
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblDescricao = new Label();
            txtDescricao = new TextBox();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            btnCadastrar = new Button();
            gbxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(25, 93);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(25, 111);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TabStop = false;
            // 
            // gbxStatus
            // 
            gbxStatus.Controls.Add(rdbInativo);
            gbxStatus.Controls.Add(rdbAtivo);
            gbxStatus.Location = new Point(170, 93);
            gbxStatus.Name = "gbxStatus";
            gbxStatus.Size = new Size(198, 58);
            gbxStatus.TabIndex = 2;
            gbxStatus.TabStop = false;
            gbxStatus.Text = "Status";
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(93, 22);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 1;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(17, 22);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(25, 163);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(131, 15);
            lblDescricao.TabIndex = 5;
            lblDescricao.Text = "Descrição da Categoria:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(25, 181);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(343, 137);
            txtDescricao.TabIndex = 6;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(25, 58);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(343, 23);
            txtCategoria.TabIndex = 7;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(25, 41);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(113, 15);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Nome da Categoria:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(263, 344);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 58);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(gbxStatus);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            Load += FormCadastro_Load;
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
        private Label lblDescricao;
        private TextBox txtDescricao;
        private TextBox txtCategoria;
        private Label lblCategoria;
        private Button btnCadastrar;
    }
}