using ImpostoDeRenda.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>(); 

            Console.Write("Entre com o número de imposto a declarar: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Imposta a declarar {i}º ");
                Console.WriteLine();
                Console.Write("Pessoas Física ou Pessoa Jurídica (PF/PJ): ");
                string opcao = Console.ReadLine().ToUpper();
                if (opcao == "PF")
                {
                    Console.Write("Nome Completo: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine());
                    Console.Write("Despesa com saúde: ");
                    double despesaComSaude = double.Parse(Console.ReadLine());
                    list.Add(new PessoaFisica(nome, rendaAnual, despesaComSaude));
                    Console.WriteLine();
                }
                else if (opcao == "PJ")
                {
                    Console.Write("Nome da empresa: ");
                    string nomeDaEmpresa = Console.ReadLine();
                    Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine());
                    Console.Write("Número de funcionários: ");
                    int numeroDeFuncionario = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nomeDaEmpresa, rendaAnual, numeroDeFuncionario));
                    Console.WriteLine();
                }

            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("Contribuintes: ");
            foreach( Contribuintes contribuintes in list)
            {
                double contribuinte = contribuintes.Imposto();
                Console.WriteLine(contribuintes.Nome + ": R$: " + contribuintes.Imposto().ToString("F2", CultureInfo.InvariantCulture));
                sum += contribuinte;
            }
            Console.WriteLine("Total contribuição R$: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
