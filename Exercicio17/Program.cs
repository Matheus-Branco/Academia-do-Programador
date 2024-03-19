namespace Exercicio17.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo que leia os valores A, B, C e
        //imprima na tela se a soma de A + B é menor que C.

        static void Main(string[] args)
        {
            Console.Clear();
            decimal a, b, c;

            Console.WriteLine("Digite o valor de A: ");
            a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            c = Convert.ToDecimal(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma de A e B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A e B não é menor que C.");
            }

            Console.ReadLine();
        }
    }
}