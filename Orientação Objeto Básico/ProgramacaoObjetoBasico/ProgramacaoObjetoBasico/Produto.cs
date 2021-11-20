﻿using System.Globalization;

namespace ProgramacaoObjetoBasico
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Sobreposição - Transforma o produto em String
        public override string ToString() // Assinatura báisca da ToString
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                +ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int quantidade)
        {
            quantidade++;
        }
        public void RemoverProdutos(int quantidade)
        {
            quantidade--;
        }
    }
}
