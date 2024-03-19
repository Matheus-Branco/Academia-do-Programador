namespace Exercicio13.ConsoleApp
{
    internal class Program
    {
        /*
         * A padaria Hotpão vende uma certa quantidade de pães 
         * franceses e uma quantidade de broas a cada dia. 
         * Cada pãozinho custa R$ 0,12 e a broa custa R$ 1,50. 
         * Ao final do dia, o dono quer saber quanto arrecadou 
         * com a venda dos pães e broas (juntos), e quanto 
         * deve guardar numa conta de poupança (10% do total arrecadado). 
         * Você foi contratado para fazer os cálculos para o dono. 
         * Com base nestes fatos, faça um algoritmo para ler as 
         * quantidades de pães e de broas, e depois calcular os 
         * dados solicitados.
         */

        static void Main(string[] args)
        {
            Console.Clear();                              

            const decimal PrecoDoPao = 0.12m;
            const decimal PrecoDaBroa = 1.50m; //literal real

            decimal valorPaes, valorBroas, total = 0.0m;
            decimal poupanca;

            Console.Write("Digite a quantidade de pães vendidos (R$ 0,12)? ");
            int paesVendidos = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite a quantidade de broas vendidas (R$ 1,50)? ");
            int broasVendidas = Convert.ToInt32(Console.ReadLine());

            valorPaes = paesVendidos * PrecoDoPao;
            valorBroas = broasVendidas * PrecoDaBroa;

            total = valorPaes + valorBroas;
            poupanca = total * 0.1m;

            Console.Write("O total apurado foi: R$" + total);
            Console.Write("\nO que vai para a poupança: R$" + poupanca);

            Console.ReadLine();
        }
    }
}