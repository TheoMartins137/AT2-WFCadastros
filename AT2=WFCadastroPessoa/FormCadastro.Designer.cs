namespace AT2_WFCadastroPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblCPF = new Label();
            mtxCPF = new MaskedTextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblDDD = new Label();
            mtbCelular = new MaskedTextBox();
            gbxTipoTelefone = new GroupBox();
            rdbRecado = new RadioButton();
            rdbComercial = new RadioButton();
            rdbPessoal = new RadioButton();
            ckbFilhos = new CheckBox();
            btnVoltar = new Button();
            btnSalvar = new Button();
            gbxTipoTelefone.SuspendLayout();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(25, 36);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(121, 23);
            txtCodigo.TabIndex = 12;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(25, 18);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(181, 18);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF:";
            // 
            // mtxCPF
            // 
            mtxCPF.Location = new Point(181, 36);
            mtxCPF.Mask = "000-000-000-00";
            mtxCPF.Name = "mtxCPF";
            mtxCPF.Size = new Size(120, 23);
            mtxCPF.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(25, 81);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(99, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome Completo:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 23);
            txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(25, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(25, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "E-mail:";
            // 
            // lblDDD
            // 
            lblDDD.AutoSize = true;
            lblDDD.Location = new Point(25, 225);
            lblDDD.Name = "lblDDD";
            lblDDD.Size = new Size(76, 15);
            lblDDD.TabIndex = 9;
            lblDDD.Text = "DDD/Celular:";
            // 
            // mtbCelular
            // 
            mtbCelular.Location = new Point(25, 243);
            mtbCelular.Mask = "(99) 00000-0000";
            mtbCelular.Name = "mtbCelular";
            mtbCelular.Size = new Size(121, 23);
            mtbCelular.TabIndex = 4;
            // 
            // gbxTipoTelefone
            // 
            gbxTipoTelefone.Controls.Add(rdbRecado);
            gbxTipoTelefone.Controls.Add(rdbComercial);
            gbxTipoTelefone.Controls.Add(rdbPessoal);
            gbxTipoTelefone.Location = new Point(181, 225);
            gbxTipoTelefone.Name = "gbxTipoTelefone";
            gbxTipoTelefone.Size = new Size(120, 102);
            gbxTipoTelefone.TabIndex = 5;
            gbxTipoTelefone.TabStop = false;
            gbxTipoTelefone.Text = "Tipo Telefone:";
            // 
            // rdbRecado
            // 
            rdbRecado.AutoSize = true;
            rdbRecado.Location = new Point(6, 72);
            rdbRecado.Name = "rdbRecado";
            rdbRecado.Size = new Size(64, 19);
            rdbRecado.TabIndex = 8;
            rdbRecado.TabStop = true;
            rdbRecado.Text = "Recado";
            rdbRecado.UseVisualStyleBackColor = true;
            // 
            // rdbComercial
            // 
            rdbComercial.AutoSize = true;
            rdbComercial.Location = new Point(6, 47);
            rdbComercial.Name = "rdbComercial";
            rdbComercial.Size = new Size(79, 19);
            rdbComercial.TabIndex = 7;
            rdbComercial.TabStop = true;
            rdbComercial.Text = "Comercial";
            rdbComercial.UseVisualStyleBackColor = true;
            // 
            // rdbPessoal
            // 
            rdbPessoal.AutoSize = true;
            rdbPessoal.Location = new Point(6, 22);
            rdbPessoal.Name = "rdbPessoal";
            rdbPessoal.Size = new Size(64, 19);
            rdbPessoal.TabIndex = 6;
            rdbPessoal.TabStop = true;
            rdbPessoal.Text = "Pessoal";
            rdbPessoal.UseVisualStyleBackColor = true;
            // 
            // ckbFilhos
            // 
            ckbFilhos.AutoSize = true;
            ckbFilhos.Checked = true;
            ckbFilhos.CheckState = CheckState.Indeterminate;
            ckbFilhos.Location = new Point(25, 298);
            ckbFilhos.Name = "ckbFilhos";
            ckbFilhos.Size = new Size(99, 19);
            ckbFilhos.TabIndex = 9;
            ckbFilhos.Text = "Possui Filhos?";
            ckbFilhos.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.ImageAlign = ContentAlignment.MiddleLeft;
            btnVoltar.Location = new Point(26, 368);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(120, 29);
            btnVoltar.TabIndex = 11;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Image = (Image)resources.GetObject("btnSalvar.Image");
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.Location = new Point(181, 368);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 29);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 419);
            Controls.Add(btnSalvar);
            Controls.Add(btnVoltar);
            Controls.Add(ckbFilhos);
            Controls.Add(gbxTipoTelefone);
            Controls.Add(mtbCelular);
            Controls.Add(lblDDD);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(mtxCPF);
            Controls.Add(lblCPF);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            gbxTipoTelefone.ResumeLayout(false);
            gbxTipoTelefone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblCPF;
        private MaskedTextBox mtxCPF;
        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblDDD;
        private MaskedTextBox mtbCelular;
        private GroupBox gbxTipoTelefone;
        private RadioButton rdbRecado;
        private RadioButton rdbComercial;
        private RadioButton rdbPessoal;
        private CheckBox ckbFilhos;
        private Button btnVoltar;
        private Button btnSalvar;
    }
}