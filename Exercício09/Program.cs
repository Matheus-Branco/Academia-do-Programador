using System.Xml;

namespace Exercício09
{
    //Crie um programa para calcular a média harmônica das notas de um Aluno
    //n / nota01 + nota02 + notaN 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro notas dos alunos:");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());
            decimal nota3 = Convert.ToDecimal(Console.ReadLine());
            decimal nota4 = Convert.ToDecimal(Console.ReadLine());

            decimal mediaHarmonica = 4 / ((1 /nota1) + (1/nota2) + (1/nota3) + (1/nota4));

            Console.WriteLine("A média harmônica das notas é: " + mediaHarmonica);
            Console.ReadLine();
        }
    }
}
