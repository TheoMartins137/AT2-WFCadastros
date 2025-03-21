using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class Usuario
    {
        public Usuario(int codigo, string? logon, string? senha)
        {
            Codigo = codigo;
            Logon = logon;
            Senha = senha;
        }

        public Usuario() { }

        public int Codigo { get; set; }
        public string? Logon { get; set; }
        public string? Senha { get; set; }

        private static List<Usuario> ListaUsuarios = new List<Usuario>();

        public void NovoUsuario()
        {
            ListaUsuarios.Add(this);
        }

        public static List<Usuario> TodosUsuarios()
        {
            return ListaUsuarios;
        }

    }
}
