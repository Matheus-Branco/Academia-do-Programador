namespace Exercício05
{
    internal class Program
    {
        //Crie um programa para calcular o volume de uma esfera
        //V = 4/3 * pi * raio^3
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao prigrama que calcula volume de uma esfera");

            Console.WriteLine("Para isso precisamos que informe o raio da esfera");
            string raioS = Console.ReadLine();
            double raio = Convert.ToDouble(raioS);

            const double pi = 3.14;

            double V = 4/3 * pi * raio * raio * raio;

            Console.WriteLine("O volume da esfera é " + V);
        }
    }
}
