using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class OperadoresAtribuicao
    {
        public void Operadores()
        {   
            int a = 10; // Recebe
            Console.WriteLine(a);

            a += 2; // Soma por 2
            Console.WriteLine(a);

            a *= 3; // Multiplica por 3
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);
        }

        public void Atribuicao()
        {
            // Operadores aritméticos/Atribuição
            int a = 10;
            a++; // Incrementa 10 + 1 = 11
            Console.WriteLine(a);

            int b = 10;
            b--; // Descrementa 10 - 1 = 9
            Console.WriteLine(b);

            int c = ++a;
            Console.WriteLine(c);
            Console.WriteLine(a);
        }
    }
}
