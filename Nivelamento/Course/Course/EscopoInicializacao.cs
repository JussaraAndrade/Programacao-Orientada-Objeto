using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class EscopoInicializacao
    {
        public void EscopoInicializacao2()
        {
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;

            if(preco > 100.0)
            {
                desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);
        }
    }
}
