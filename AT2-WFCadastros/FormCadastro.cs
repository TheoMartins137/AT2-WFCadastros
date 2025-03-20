using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2_WFCadastros
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
            txtCategoria.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtCategoria.Text == "")
            {
                Erro("Campo de Categoria não pode estar Vazio");
                return;
            }

            if (txtNome.Text == "")
            {
                Erro("Campo de Nome não pode estar Vazio");
                return;
            }

            if (rdbAtivo.Checked == false && rdbInativo.Checked == false)
            {
                Erro("Campo de Status não pode estar Vazio");
                return;
            }

            if (txtDescricao.Text == "")
            {
                Erro("Campo de Descrição não pode estar Vazio");
                return;
            }

            Produtos Categoria = new Produtos();
            Categoria.Categoria = txtCategoria.Text;
            Categoria.Nome = txtNome.Text;
            Categoria.Codigo = Convert.ToInt32(txtCodigo.Text);
            if (rdbAtivo.Checked == true)
            {
                Categoria.Ativo = "Ativo";
            }
            else 
            {
                Categoria.Ativo = "Inativo";
            }
            Categoria.DtCadastro = DateTime.Now;
            Categoria.Descricao = txtDescricao.Text;

            MessageBox.Show("Categoria Cadastrada com Sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Produtos.ListaCategorias.Add(Categoria);

            Limpar();
            int qtdeProdutos = Produtos.ListaCategorias.Count;
            int novoCodigo = qtdeProdutos + 1;
            txtCodigo.Text = novoCodigo.ToString();

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            int qtdeProdutos = Produtos.ListaCategorias.Count;
            int novoCodigo = qtdeProdutos + 1;
            txtCodigo.Text = novoCodigo.ToString();
            rdbAtivo.Checked = false;
            rdbInativo.Checked = false;
        }
    }
}
