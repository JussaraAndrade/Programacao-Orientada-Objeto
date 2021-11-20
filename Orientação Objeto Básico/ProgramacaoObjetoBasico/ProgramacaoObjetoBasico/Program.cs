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

            Triangulo x, y; // Duas variáveis do tipo Triangulo

            // Instanciar
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


            double p = (x.A + x.B + x.C) / 2.0;
            // area = √p(p-a)(p-b)(p-c)
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            // p = a + b + c/2 
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de x = " +areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}
