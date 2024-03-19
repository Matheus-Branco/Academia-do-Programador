namespace Exercicio20.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo para receber um número qualquer
        //e informar na tela se é par ou ímpar.
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }

            Console.ReadLine();
        }
    }
}