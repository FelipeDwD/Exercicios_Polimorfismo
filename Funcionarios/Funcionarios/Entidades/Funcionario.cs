using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Funcionarios.Entidades
{
    class Funcionario
    {
        public string Nome { get; protected set; }

        public double HorasTrabalhadas { get; protected set; }

        public double ValorPorHora { get; protected set; }

        public Funcionario() { }

        public Funcionario(string nome, double horasTrabalhadas, double valorPorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }

        public virtual double pagamento()
        {
            double pagamento = ValorPorHora * HorasTrabalhadas;
            return pagamento;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nome: ");
            sb.AppendLine(Nome);
            sb.Append("Pagamento total: ");
            sb.Append(pagamento().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
