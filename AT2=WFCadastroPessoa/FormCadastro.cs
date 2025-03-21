using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastroPessoa
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void Erro(string Mensagem)
        {
            MessageBox.Show(Mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Limpar()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtEmail.Clear();
            mtxCPF.Clear();
            mtbCelular.Clear();
            rdbPessoal.Checked = false;
            rdbRecado.Checked = false;
            rdbComercial.Checked = false;
            ckbFilhos.CheckState = CheckState.Indeterminate;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string CPFMask = mtxCPF.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            if (string.IsNullOrEmpty(CPFMask))
            {
                Erro("Campo de CPF não pode estar Vazio");
                return;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Erro("Campo de Nome não pode estar Vazio");
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Erro("Campo de E-Mail não pode estar Vazio");
                return;
            }

            string DDDMask = mtbCelular.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");

            if (string.IsNullOrEmpty(DDDMask))
            {
                Erro("Campo de DDD/Celular não pode estar Vazio");
                return;
            }

            if (rdbPessoal.Checked == false && rdbComercial.Checked == false && rdbRecado.Checked == false)
            {
                Erro("Campo de Tipo Telefone não pode estar Vazio");
                return;
            }

            if (ckbFilhos.CheckState == CheckState.Indeterminate)
            {
                Erro("Campo de Possui Filhos não pode estar Vazio");
                return;
            }

            Pessoa fulano = new Pessoa();
            fulano.Codigo = Convert.ToInt32(txtCodigo.Text);
            fulano.CPF = CPFMask;
            fulano.Nome = txtNome.Text;
            fulano.Email = txtEmail.Text;
            fulano.DDD = DDDMask.Substring(0, 2);
            fulano.Telefone = DDDMask.Substring(2);

            if (rdbComercial.Checked == true)
            {
                fulano.TipoTelefone = "Comercial";
            }
            else if (rdbPessoal.Checked == true)
            {
                fulano.TipoTelefone = "Pessoal";
            }
            else
            {
                fulano.TipoTelefone = "Recado";
            }

            if (ckbFilhos.CheckState == CheckState.Checked)
            {
                fulano.Filhos = "Possui Filhos";
            }
            else
            {
                fulano.Filhos = "Não possui Filhos";
            }

            Pessoa.ListaPessoas.Add(fulano);

            MessageBox.Show("Cadastro realizado com Sucesso", "Cadastro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Limpar();

            int qtdeProdutos = Pessoa.ListaPessoas.Count;
            int novoCodigo = qtdeProdutos + 1;
            txtCodigo.Text = novoCodigo.ToString();

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            int qtdeProdutos = Pessoa.ListaPessoas.Count;
            int novoCodigo = qtdeProdutos + 1;
            txtCodigo.Text = novoCodigo.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
