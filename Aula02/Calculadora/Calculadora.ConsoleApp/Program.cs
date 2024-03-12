namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Requisito 01
            //Nossa calculadora deve ter a possibilidade de somar dois números


            //Requisito 02
            //Nossa calculadora deve ter a possibilidade de fazer várias operações de soma


            //Requisito 03
            //Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração


            //Requisito 04
            //Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática


            //Requisito 05
            //Nossa calculadora deve realizar as operações com "0"


            //Requisito 06
            //Nossa calculadora deve validar a opções do menu 


            //Requisito 07
            //Nossa calculadora deve realizar as operações com números com duas casas decimais

            //Condição
            while (true)
            {
                //Tela inicial
                Console.Clear();
                Console.WriteLine("Calculadora Tabajara 2024");
                Console.WriteLine("Digite 1 para fazer adição");
                Console.WriteLine("Digite 2 para fazer subtração");
                Console.WriteLine("Digite 3 para fazer multiplicação");
                Console.WriteLine("Digite 4 para fazer divisão");
                Console.WriteLine("Digite S para sair");
                string operacao = Console.ReadLine();
                if (operacao == "S")
                    break;
                else if (operacao == "1" || operacao == "2" || operacao == "3" || operacao == "4") ;
                {
                    //Primeiro número
                    Console.WriteLine("Digite o primeiro número:");
                    string n1String = Console.ReadLine();
                    float n1 = (float)Convert.ToDouble(n1String);

                    //Segundo número
                    Console.WriteLine("Digite o segundo número:");
                    string n2String = Console.ReadLine();
                    float n2 = (float)Convert.ToDouble(n2String);

                    //Respostas
                    int resultadoInt = 0;
                    float resultado = (float)Convert.ToDouble(resultadoInt);
                    if (operacao == "1")
                    {
                        resultado = n1 + n2;
                    }
                    else
                    if (operacao == "2")
                    {
                        resultado = n1 - n2;
                    }
                    else
                    if (operacao == "3")
                    {
                        resultado = n1 * n2;
                    }
                    else
                    if (operacao == "4")
                    {
                        resultado = n1 / n2;
                    }


                    Console.WriteLine("O resultado é: " + resultado);
                    Console.ReadLine();
                }
                { 
                        Console.WriteLine("Operação inválida");
                }
                    
            }
        }
    }
}
