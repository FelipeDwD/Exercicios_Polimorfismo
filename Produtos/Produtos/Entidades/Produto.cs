using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produtos.Entidades
{
    class Produto
    {
        public string Nome { get; protected set; }

        public double Preco { get; protected set; }

        public Produto() { }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string Etiqueta()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nome: ");
            sb.Append(Nome);
            sb.Append(" - ");
            sb.Append("Preço: ");
            sb.Append(Preco.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }       
    }
}
