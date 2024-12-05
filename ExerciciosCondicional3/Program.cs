using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

               string[] vet = Console.ReadLine().Split(' ');
               int x = int.Parse(vet[0]);
               int y = int.Parse(vet[0]);


                if (x % y == 0 || y % x == 0)
                {
                    Console.WriteLine("São multiplos");
                }
                else
                {
                    Console.WriteLine("Não multiplos");
                }
            }
        }
    }
}