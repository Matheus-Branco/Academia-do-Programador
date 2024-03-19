namespace Exercicio28.ConsoleApp
{
    internal class Program
    {
        /*
         *Escreva um programa que exiba a tabuada de 
         *multiplicação do 1 até o 10. 
         *Para isso, o programa deve gerar todas as combinações 
         *de multiplicação entre 1 e 10, exibindo o resultado de 
         *cada operação na tela.

            Desafio: Para cada número, tente separar em colunas.

         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int result = i * j;
                    Console.Write("{0} x {1} = {2}\n", i, j, result);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}