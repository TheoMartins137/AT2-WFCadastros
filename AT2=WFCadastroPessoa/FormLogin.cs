namespace AT2_WFCadastroPessoa
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Codigo = 1001;
            user.Logon = "sistema";
            user.Senha = "123456";
            user.NovoUsuario();
        }


        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (Usuario user1 in Usuario.TodosUsuarios())
                {
                    if ((txtLogin.Text == user1.Logon) && (txtSenha.Text == user1.Senha))
                    {
                        FormPrincipal form = new FormPrincipal();
                        form.ShowDialog();

                        txtLogin.Clear();
                        txtSenha.Clear();
                        return;
                    }
                }
                txtSenha.Clear();
                MessageBox.Show("Usuário não cadastrado no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
