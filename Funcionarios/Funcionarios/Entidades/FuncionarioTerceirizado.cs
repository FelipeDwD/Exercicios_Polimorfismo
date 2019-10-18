using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionarios.Entidades
{
    class FuncionarioTerceirizado : Funcionario
    {
        public double DespesaAdicional { get; set; }

        public FuncionarioTerceirizado() { }

        public FuncionarioTerceirizado(string nome, double horasTrabalhadas, double valorPorHora, double despesaAdicional)
            : base(nome, horasTrabalhadas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double pagamento()
        {            
            double bonus = DespesaAdicional * 1.1;
            double pagamentoTotal = base.pagamento() + bonus;
            return pagamentoTotal;
        }
    }
}
