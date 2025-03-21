using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class Pessoa
    {
        public Pessoa(int codigo, string? nome, string? email, string? cPF, string? dDD, string? telefone, string? tipoTelefone, string? filhos)
        {
            Codigo = codigo;
            Nome = nome;
            Email = email;
            CPF = cPF;
            DDD = dDD;
            Telefone = telefone;
            TipoTelefone = tipoTelefone;
            Filhos = filhos;
        }

        public Pessoa () { }


        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
        public string? DDD { get; set; }
        public string? Telefone { get; set; }
        public string? TipoTelefone { get; set; }
        public string? Filhos { get; set; }

        public static List<Pessoa> ListaPessoas = new List<Pessoa>();
    }
}
