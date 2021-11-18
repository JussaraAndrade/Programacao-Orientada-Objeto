using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class OperadoresLogicos
    {
        /*
        OPERADORES:

        && : E
        || : OU
        ! : NÃO

        1) ORDEM PRECEDÊNCIA: ! (Primeiro) > && (Segundo)  > || (Terceiro)
         
         */
        public void OperadoresLogico()
        {
            bool C1 = 2 > 3 &&  4 != 5; // false
            bool C2 = 2 > 3 || 4 != 5; // true
            bool C3 = !(2 > 3) && 4 != 5; // true  

            Console.WriteLine(C1);
            Console.WriteLine(C2);
            Console.WriteLine(C3);

            Console.WriteLine("------------------------------");

            bool C4 = 10 < 5; // false
            bool C5 = C1 || C2 && C3; // true

            Console.WriteLine(C4);
            Console.WriteLine(C5);
        }
    }
}
