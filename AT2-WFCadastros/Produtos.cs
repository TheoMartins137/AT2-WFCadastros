using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public class Produtos
    {
        public Produtos(int codigo, string? nome, string? descricao, string? ativo, DateTime dtCadastro, string? categoria)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            DtCadastro = dtCadastro;
            Categoria = categoria;
        }

        public Produtos () { }

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Ativo { get; set; }
        public DateTime DtCadastro { get; set; }
        public string? Categoria { get; set; }

        public static List<Produtos> ListaCategorias = new List<Produtos>();

    }
}
