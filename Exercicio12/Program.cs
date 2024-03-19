namespace Exercicio12.ConsoleApp
{
    internal class Program
    {
        //A imobiliária Imóbilis vende apenas terrenos retangulares.
        //Faça um algoritmo para ler as dimensões de um terreno
        //e depois exibir a área do terreno.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do terreno:");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do terreno:");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine("A área do terreno é: " + area);

            Console.ReadLine();
        }
    }
}