using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tipos básicos de dados em C# - Parte 1 e 2*/
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648;
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green"; //Cadeia de caracter Unicode
            object obj1 = "Alex Brown"; // Tipo Generico - aceita qualquer tipo
            object obj2 = "4.5";

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int n01 = int.MinValue;
            int n02 = int.MaxValue;
            sbyte n03 = sbyte.MinValue;
            decimal n04 = decimal.MaxValue;

            Console.WriteLine(n01);
            Console.WriteLine(n02);
            Console.WriteLine(n03);
            Console.WriteLine(n04);
        }
    }
}
