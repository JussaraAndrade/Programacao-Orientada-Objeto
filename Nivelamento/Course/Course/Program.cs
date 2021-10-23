using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            TipoBasicoDados tipos = new TipoBasicoDados();
            //tipos.TipoBasicoDado();

            SaidaDados saida = new SaidaDados();
            //saida.SaidaDado();
            //saida.PlaceInterConcat();

            Exercicios ex = new Exercicios();
            //ex.Ex01();

            OperadoresAtribuicao operadoresAtribuicao = new OperadoresAtribuicao();
            //operadoresAtribuicao.Operadores();
            operadoresAtribuicao.Atribuicao();


        }
    }
}