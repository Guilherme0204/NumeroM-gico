using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMágico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, div, mod, soma;
            

          for (num = 1000; num <= 9999; num++)
            {
                    div = num / 100;
                    mod = num % 100;
                    soma = div + mod;
                    soma = soma * soma;
                    if (soma == num)
                    {
                        Console.WriteLine($"{soma} é um número mágico ");
                    }
               
            } 
            Console.ReadKey();
            

        }
    }
}
