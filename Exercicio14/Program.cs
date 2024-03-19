namespace Exercicio14.ConsoleApp
{
    internal class Program
    {
        /*
         * Escreva um algoritmo para ler o nome e a idade 
         * de uma pessoa, e exibir quantos dias de vida ela possui. 
         * Considere sempre anos completos, e que um ano possui 365 dias. 
         * Ex: uma pessoa com 19 anos possui 6935 dias de vida; 
         * veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
         */
        static void Main(string[] args)
        {
            string nome;
            int idade, diasDeVida;
            const int qtdDiasNoAno = 365;

            Console.Write("Por favor, informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("\nAgora informe sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            diasDeVida = idade * qtdDiasNoAno;

            Console.WriteLine(nome + ", você já viveu " + diasDeVida + " dias");

            Console.ReadLine();
        }
    }
}