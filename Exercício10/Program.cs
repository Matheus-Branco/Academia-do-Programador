namespace Exercíco10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota da primeira prova: ");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o peso da primeira prova: ");
            decimal peso1 = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Informe a nota da segunda prova: ");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o peso da segunda prova: ");
            decimal peso2 = Convert.ToDecimal(Console.ReadLine());

            decimal mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.ReadLine();
        }
    }
}
