namespace Exercício04
{
    //Crie um programa para calcular o consumo de combustível por Km.
    //Deverá ser informado a quilometragem Inicial e Final do Percurso do Veículo. Deverá ser informado o Consumo de Combustível
    //Consumo = quilometragem inicial - quilometragem final / consumo de combustível
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula o consumo de combustível por km");
            Console.WriteLine("Por favor informe a quilometragem inicial");
            String km_iniS = Console.ReadLine();
            int km_ini = Convert.ToInt32(km_iniS);

            Console.WriteLine("Por favor informe a quilometragem final");
            String km_finS = Console.ReadLine();
            int km_fin = Convert.ToInt32(km_finS);

            Console.WriteLine("Por favor informe o quanto de combustível foi usado");
            String consS = Console.ReadLine();
            int cons = Convert.ToInt32(consS);

            int Res = km_ini - km_fin / cons;
            Console.WriteLine("A quantidade de km q o carro faz por litro é " + Res);
        }
    }
}
