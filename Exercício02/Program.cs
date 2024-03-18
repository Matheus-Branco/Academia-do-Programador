using System.Text.RegularExpressions;
using System;
using System.Data;

namespace Exercício02
{
    //Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius
    // C = 5/9 * (F - 32)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos fazer um programa para converter a temperatura de graus Fahrenheit para graus Celsius:");

            Console.WriteLine("Nos informe a temperatura em graus Fahrenheit:");
            string fahS = Console.ReadLine();
            int fah = Convert.ToInt32(fahS);

            int cel = 5/9 * (fah - 32);

            Console.WriteLine("A temperatura " + fah + "Fahrenheit em Graus Celsius é " + cel);

        }
    }
}
