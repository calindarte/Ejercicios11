using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppG02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool hay_negativos = false;

            for (int i = 1;i <=10; i++)
            {
                Console.Write("Digite un numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero < 0) 
                {
                    hay_negativos=true;
                }
                            
            }
            if (hay_negativos == true)
            {
                Console.WriteLine("si existe al menos un numero negativo");
            }
            else
            {
                Console.WriteLine("No existe ningun numero negativo");
            }
        }
    }
}