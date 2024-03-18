namespace Exercício03
{
    //Crie um programa para calcular o volume de um Cilindro
    //V = pi * raio^2 * altura
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao prigrama que calcula volume de um cilindro");

            Console.WriteLine("Para isso precisamos que informe o raio do cilindro");
            string raioS = Console.ReadLine();
            double raio = Convert.ToDouble(raioS);

            Console.WriteLine("E agora precisamos da altura");
            string altS = Console.ReadLine();
            double alt = Convert.ToDouble(altS);

            const double pi = 3.14;

            double V = pi * raio * raio * alt;

            Console.WriteLine("O volume do Cilindro é " + V);
        }
    }
}
