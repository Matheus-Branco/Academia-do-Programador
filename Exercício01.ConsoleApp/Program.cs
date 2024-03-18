namespace Exercício01.ConsoleApp
//Crie um programa para calcular o volume de uma caixa retangular
//V = Comprimento x Largura x Altura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo, vamos calcular o volume de uma caixa retangular.");

            Console.WriteLine("Primeiro digite o comprimento:");
            string compS = Console.ReadLine();
            decimal comp = Convert.ToDecimal(compS);

            Console.WriteLine("Primeiro digite o largura:");
            string larS = Console.ReadLine();
            decimal lar = Convert.ToDecimal(larS);

            Console.WriteLine("Primeiro digite o altura:");
            string altS = Console.ReadLine();
            decimal alt = Convert.ToDecimal(altS);

            decimal res = comp * lar * alt;

            Console.WriteLine(res);
        }
    }
}
