using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("=================================================");

            Console.WriteLine("Dado da primeira pessoa: ");
            Console.WriteLine($"Nome: {p1.Nome}");
            Console.WriteLine($"Idade: {p1.Idade}");

            Console.WriteLine("Dado da segunda pessoa: ");
            Console.WriteLine($"Nome: {p2.Nome}");
            Console.WriteLine($"Idade: {p2.Idade}");

            if (p1.Idade >= p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }

            //Dados do primeiro funcionário:
            //Nome: Carlos Silva
            //Salário: 6300.00
            //Dados do segundo funcionário:
            //Nome: Ana Marques
            //Salário: 6700.00
            //Salário médio = 6500.00

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("=================================================");

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine($"Nome: {f1.Nome}");
            Console.WriteLine($"Salário: {f1.Salario}", "F2", CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine($"Nome: {f2.Nome}");
            Console.WriteLine($"Idade: {f2.Salario}", "F2", CultureInfo.InvariantCulture);

            if (f1.Salario > f2.Salario)
            {
                Console.WriteLine($"Salário médio: {f1.Salario}");
            }
            else
            {
                Console.WriteLine($"Salário médio: {f1.Salario}");
            }

        }
    }
}
