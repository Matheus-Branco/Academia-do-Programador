namespace Exercício06
{
    //Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
    //F = 9/5 * C + 32
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para converter temperatura de Celsius para Fahrenheit.");

            Console.WriteLine("Nos informe a temperatura em Fahrenheit");
            string cS = Console.ReadLine();
            int c = Convert.ToInt32(cS);

            int F = 9 / 5 * c + 32;

            Console.WriteLine("A temperatura" + c + "Celsius em Fahrenheit é " + F);
        }
    }
}
