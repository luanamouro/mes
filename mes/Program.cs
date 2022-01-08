using System;

namespace mes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            Console.WriteLine("Digite o mês escolhido, em valor numérico:");
            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    mes = 1;
                    Console.WriteLine("Mês Janeiro");
                    break;
                case 2:
                    mes = 2;
                    Console.WriteLine("Mês Fevereiro");
                    break;
                case 3:
                    mes = 3;
                    Console.WriteLine("Mês Março");
                    break;
                case 4:
                    mes = 4;
                    Console.WriteLine("Mês Abril");
                    break;
                case 5:
                    mes = 5;
                    Console.WriteLine("Mês Maio");
                    break;
                case 6:
                    mes = 6;
                    Console.WriteLine("Mês Junho");
                    break;
                case 7:
                    mes = 7;
                    Console.WriteLine("Mês Julho");
                    break;
                case 8:
                    mes = 8;
                    Console.WriteLine("Mês Agosto");
                    break;
                case 9:
                    mes = 9;
                    Console.WriteLine("Mês Setembro");
                    break;
                case 10:
                    mes = 10;
                    Console.WriteLine("Mês Outubro");
                    break;
                case 11:
                    mes = 11;
                    Console.WriteLine("Mês Novembro");
                    break;
                case 12:
                    mes = 12;
                    Console.WriteLine("Mês Dezembro");
                    break;
                default:
                    Console.WriteLine("Valor não corresponde a um mês.");
                    break;

            }

        }
    }
}
