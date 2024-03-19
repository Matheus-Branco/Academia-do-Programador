namespace Exercicio16.ConsoleApp
{
    internal class Program
    {
        //Faça um algoritmo para ler o salário de um funcionário
        //e aumentá-lo em 15%. Após o aumento, desconte 8% de impostos.
        //Imprima o salário inicial, o salário com o aumento
        //e o salário final.
        static void Main(string[] args)
        {
            const decimal valorAumento = 0.15m;
            const decimal impostos = 0.8m;

            decimal salarioAtual, salarioComAumento, salarioFinal;

            Console.Write("Digite o seu salário atual: ");
            salarioAtual = Convert.ToDecimal(Console.ReadLine());

            salarioComAumento = salarioAtual + salarioAtual * valorAumento;

            salarioFinal = salarioComAumento - salarioComAumento * impostos;

            Console.WriteLine("\nO salário com aumento é: " + salarioComAumento);
            Console.WriteLine("O salário final é: " + salarioFinal);
        }
    }
}