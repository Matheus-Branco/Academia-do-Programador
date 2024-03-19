namespace Exercicio18.ConsoleApp
{
    internal class Program
    {
        //Escreva um algoritmo que leia três valores inteiros
        //e diferentes e mostre-os em ordem decrescente.
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite três valores inteiros e diferentes: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + ", " + b + ", " + c);
                }
                else
                {
                    Console.WriteLine(a + ", " + c + ", " + b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine(b + ", " + a + ", " + c);
                }
                else
                {
                    Console.WriteLine(b + ", " + c + ", " + a);
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine(c + ", " + a + ", " + b);
                }
                else
                {
                    Console.WriteLine(c + ", " + b + ", " + a);
                }
            }

            Console.ReadLine();
        }
    }
}