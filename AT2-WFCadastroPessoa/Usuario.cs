using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public class Usuario
    {
        public Usuario() { }

        public static List<Usuario> ListaUsuario = new List<Usuario>();

        public int Codigo { get; set; }
        public string Longo { get; set; }
        public string Senha { get; set; }


    }
}
