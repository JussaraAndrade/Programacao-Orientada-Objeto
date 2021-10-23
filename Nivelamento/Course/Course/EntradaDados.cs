using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
