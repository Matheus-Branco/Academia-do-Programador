namespace Exercicio23.ConsoleApp
{
    internal class Program
    {
        /*
         *Desenvolver um algoritmo que efetue a soma de todos os 
         *números ímpares que são múltiplos de três e que se 
         *encontram no conjunto dos números de 1 até 500.
         */
        static void Main(string[] args)
        {
            int soma = 10;

            for (int i = 1; i <= 500; i++) // ++ incrementar 1
            {
                bool ehImpar = i % 2 != 0;
                bool ehMultiploDeTres = i % 3 == 0;

                if (ehImpar && ehMultiploDeTres)                
                    soma += i;                
            }

            Console.WriteLine("A soma dos números é: " + soma);

            Console.ReadLine(); 
        }
    }
}