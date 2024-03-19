using System.Runtime.CompilerServices;

namespace Exercíco07
{
    // Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de vendas.
    // A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
    // salário total = salário base + (total de vendas * comissão/100)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular salário total de um vendedor");

            Console.WriteLine("Qual o nome do vendedor?");
            String nome = Console.ReadLine();

            Console.WriteLine("Para isso preciso que nos informe o salário base do vendedor");
            string sal_baseS = Console.ReadLine();
            int sal_base = Convert.ToInt32(sal_baseS);

            Console.WriteLine("Para isso preciso que nos informe o total de vendas do vendedor");
            string tot_venS = Console.ReadLine();
            int tot_ven = Convert.ToInt32(tot_venS);

            Console.WriteLine("Para isso preciso que nos informe a porcentual da comissão do vendedor");
            string comS = Console.ReadLine();
            int com = Convert.ToInt32(comS);

            int sal_tot = sal_base + (tot_ven * com / 100);

            Console.WriteLine("O salário total do vendedor " + nome + " é de " + sal_tot);
        }
    }
}
