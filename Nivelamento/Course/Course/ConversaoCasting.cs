using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class ConversaoCasting
    {
        public void Conversao()
        {
            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            int a1 = 5;
            int b2 = 2;

            double resultado = (double) a1 / b2;

            Console.WriteLine(resultado);
        }
    }
}
