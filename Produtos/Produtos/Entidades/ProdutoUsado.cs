using System;
using System.Collections.Generic;
using System.Text;

namespace Produtos.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }


        public ProdutoUsado() { }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao)
            : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string Etiqueta()
        {
            

            StringBuilder sb = new StringBuilder();
            sb.Append(base.Etiqueta());
            sb.Append(" - ");
            sb.Append("Data fabricação: ");
            sb.Append(DataFabricacao.Day);
            sb.Append("/");
            sb.Append(DataFabricacao.Month);
            sb.Append("/");
            sb.Append(DataFabricacao.Year);

            return sb.ToString();
        }
    }
}
