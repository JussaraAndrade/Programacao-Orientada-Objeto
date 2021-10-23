using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProgramacaoBasica
{
    class EntradaDados
    {
        public void EntradaDado()
        {
            // Ler os dados Console.ReadLine()
            // string frase; guarda na variável frase
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine(); // Leitura
            // Split; serve para quebrar linha por espaços (Recorte)
            string[] vetor = Console.ReadLine().Split(' '); 
            string a = vetor[0]; // Vetor na posição: [0] "Batata"
            string b = vetor[1]; // Vetor na posição: [1] "Tomate"
            string c = vetor[2]; // Vetor na posição: [2] "Abacaxi"

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public void ExercicioEntradaDado()
        {

            int n1 = int.Parse(Console.ReadLine()); // Leitura do número inteiro
            char ch = char.Parse(Console.ReadLine()); // Leitura de caracter 
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Leitura de casas decimais

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você dígitou");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
