using System;
using System.Globalization;

namespace Course
{
    class Desafio
    {
        /*
         Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
         mensagem explicativa, conforme exemplos.
         */
        public void Desafio01()
        {
            int n1, n2, soma;

            Console.WriteLine("Dígite 1° número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dígite 2° número: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;
            Console.WriteLine("SOMA = " + soma);
        }

        /*
         Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
         casas decimais conforme exemplos.
         
         Fórmula da área: area = π . raio2
         Considere o valor de π = 3.14159
         */
        public void Desafio02()
        {
            double PI, RAIO, AREA;

            PI = 3.14159;
            RAIO = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            AREA = PI * Math.Pow(RAIO, 2.0);

            Console.WriteLine("A=" +AREA.ToString("F4", CultureInfo.InvariantCulture));
        }

        /*
         Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
         de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
         */
        public void Desafio03()
        {
            int A, B, C, D, DIFERENCA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENÇA = " + DIFERENCA);

        }

        public void Desafio04()
        {
            int FUNCIONARIO, HORAS;
            double VALOR, SALARIO;

            FUNCIONARIO = int.Parse(Console.ReadLine());
            HORAS = int.Parse(Console.ReadLine());
            VALOR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SALARIO = HORAS * VALOR;

            Console.WriteLine("NUMBER = " +FUNCIONARIO);
            Console.WriteLine("SALARY = U$ " + SALARIO.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void Desafio05()
        {
            int CODIGO01, PECA01, CODIGO02, PECA02;
            double VALORUNITARIO01, VALORUNITARIO02;

            string[] vet01 = Console.ReadLine().Split(' ');
            CODIGO01 = int.Parse(vet01[0]); // 12
            PECA01 = int.Parse(vet01[1]); // 1 * 5.30 = 5,30
            VALORUNITARIO01 = double.Parse(vet01[2], CultureInfo.InvariantCulture); // 5.30

            string[] vet02 = Console.ReadLine().Split(' ');

            CODIGO02 = int.Parse(vet02[0]); // 16
            PECA02 = int.Parse(vet02[1]); // 2 * 5.10 = 10,20
            VALORUNITARIO02 = double.Parse(vet02[2], CultureInfo.InvariantCulture); //5.10

            //TOTAL = 5,30 + 10,20 = 15,50

            double PAGAR = (PECA01 * VALORUNITARIO01) + (PECA02 * VALORUNITARIO02);

            Console.WriteLine("CÓDIGO PEÇA 1 " + CODIGO01);
            Console.WriteLine("CÓDIGO PEÇA 1 " + CODIGO02);
            Console.WriteLine("VALOR A PAGAR: R$ " + PAGAR.ToString("F2"), CultureInfo.InvariantCulture);
        }

        /*
         Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
         mostre:
         a) a área do triângulo retângulo que tem A por base e C por altura.
         b) a área do círculo de raio C. (pi = 3.14159)
         c) a área do trapézio que tem A e B por bases e C por altura.
         d) a área do quadrado que tem lado B.
         e) a área do retângulo que tem lados A e B.
         */
        public void Desafio06()
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0; // Área do triângulo retângulo que tem A por base e C por altura
            circulo = 3.14159 * C * C; // Área do círculo de raio C. (pi = 3.14159)
            trapezio = (A + B) / 2.0 * C; // Área do trapézio que tem A e B por bases e C por altura
            quadrado = B * B; // Área do quadrado que tem lado B
            retangulo = A * B; // Área do retângulo que tem lados A e B

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
