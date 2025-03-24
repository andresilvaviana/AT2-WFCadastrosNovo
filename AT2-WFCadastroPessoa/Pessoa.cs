using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastroPessoa
{
    public enum TipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado,
    }

    public class Pessoa
    {
        public Pessoa(int cadastro, string? cpf, string? nome, string? email, string? ddd, string? celular, TipoTelefone tipoTelefone, string? filhos)
        {
            Cadastro = cadastro;
            Cpf = cpf;
            Nome = nome;
            Email = email;
            DDD = ddd;
            Celular = celular;
            TipoTelefone = tipoTelefone;
            Filhos = filhos;
        }

        public static List<Pessoa> ListaPessoas = new List<Pessoa>();

        public int Cadastro { get; set; }
        public string? Cpf { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? DDD { get; set; }
        public string? Celular { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
        public string? Filhos { get; set; }

        public Pessoa() { }

        public static List<Pessoa> ObterLista()
        {
            return ListaPessoas;
        }
        
    }
}