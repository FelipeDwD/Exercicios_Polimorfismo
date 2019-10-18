using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Produtos.Entidades
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; protected set; }

        public ProdutoImportado() { }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega)
            : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;           
        }

        public double PrecoFinal()
        {
            return Preco + TaxaAlfandega;
        }

        public override string Etiqueta()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Etiqueta());
            sb.Append(" - ");
            sb.Append("Taxa Alfândega: ");
            sb.Append(TaxaAlfandega);
            sb.Append(" - ");
            sb.Append("Preço total: ");
            sb.Append(PrecoFinal().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
            
        }
    }
}
