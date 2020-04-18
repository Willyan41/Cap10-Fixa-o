using System;
using System.Collections.Generic;
using System.Globalization;
using Cap10_Fixação.Entities;

namespace Cap10_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de taxas: ");
            int n = int.Parse(Console.ReadLine());

            List<Taxas> list = new List<Taxas>();

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine($"Taxa a pagar #{i} data:");
                Console.Write("Pessoa física ou jurídica (f/j)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Ganho anual: ");
                double ganho = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'f')
                {
                    Console.Write("Gastos com seguro de vida: ");
                    double seguroDeVida = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(seguroDeVida, nome, ganho));

                }
                else
                {
                    Console.Write("Número de colaboradores: ");
                    int colaborador = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(nome, ganho, colaborador));

                }

            }

            Console.WriteLine();
            Console.WriteLine("Taxas Pagas: ");
            foreach(Taxas tx in list)
            {
                Console.WriteLine(tx.Name 
                    +" , " 
                    + tx.Taxa().ToString("F2", CultureInfo.InvariantCulture));

            }

            double sum = 0.0;
            Console.WriteLine();
            foreach(Taxas tx in list)
            {
                sum += tx.Taxa();
                
            }
            Console.WriteLine("Total de Taxas Pagas: "+ sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
