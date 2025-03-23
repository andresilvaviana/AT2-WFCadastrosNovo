using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT2_WFCadastros
{
    public enum ETipoStatus
    {
        Ativo,
        Inativo,
    }

    public class CadastroCategoria
    {
        public CadastroCategoria() { }

        public CadastroCategoria(int codigo, string? nome, string? descricao, ETipoStatus status, DateTime cadastro)
        {
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            Status = status;
            Cadastro = cadastro;
        }

        public static List<CadastroCategoria> ListaCategoria = new List<CadastroCategoria>();

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public ETipoStatus Status { get; set; }
        public DateTime Cadastro { get; set; }

        public static List<CadastroCategoria> ObterLista()
        {
            return ListaCategoria;
        }
    }
}
