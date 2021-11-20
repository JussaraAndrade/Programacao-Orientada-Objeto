using System;
using System.Globalization;

namespace ProgramacaoObjetoBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Classe, objetos e atributos:

            * Classe: é a definição do tipo
            * Objeto: são instâncias da classe, caso particulares da classe.
             
            Duas váriaveis compostas: x e y
            */

            // A classe Triangulo é um Tipo personalizados
            Triangulo x, y; // Duas variáveis do tipo Triangulo

            //// Instanciar
            x = new Triangulo(); // Objeto x
            y = new Triangulo(); // Objeto y


            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

            Console.WriteLine("-------------------------------------------");

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }



            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------------------------------");

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " +p);
        }
    }
}
