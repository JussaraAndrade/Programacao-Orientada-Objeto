using System; // Importação de dependências

namespace ProgramacaoObjetoBasico // Namespace da clase
{
    class Triangulo // Nome da Classe
    {
        // Atributos A, B e C - Definição do triângulo:
        // prefixo public; indica que o método pode ser usado em outros arquivos
        public double A; // Dado A do tipo double
        public double B; // Dado B do tipo double
        public double C; // Dado C do tipo double
        
        // Método é uma função dentro da classe, tipo da classe é double
        public double Area() // Nenhum parametro de entrada
        {
            double p = (A + B + C) / 2.0;
            // area = √p(p-a)(p-b)(p-c)
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Corpo do método
        }
    }
}
