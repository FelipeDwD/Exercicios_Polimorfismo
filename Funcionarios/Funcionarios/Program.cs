using Funcionarios.Entidades;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.Write("Digite o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Dados do {(i + 1)} funcionário: ");
                Console.Write("Terceirizado: (y/n)");
                string terceirizado = Console.ReadLine();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Horas trabalhadas: ");
                double horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (terceirizado.Equals("y")){                   

                    Console.Write("Taxa adicional: ");
                    double taxaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    funcionarios.Add( new FuncionarioTerceirizado(nome, horasTrabalhadas, valorPorHora, taxaAdicional));
                }
                else if(terceirizado.Equals("n"))
                {
                    funcionarios.Add(new Funcionario(nome, horasTrabalhadas, valorPorHora));
                }
            }
            Console.WriteLine();

            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
                Console.WriteLine();
            }
        }   
    }
}
