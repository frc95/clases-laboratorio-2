using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            int i;
            for(i=0;i<10;i++)
            {
                Console.Write("Ingrese el {0} numero: ", i + 1);
                int numero = int.Parse(Console.ReadLine());
                if(validacion.validar(numero,-100,100))
                {
                    Console.WriteLine("El numero {0} esta dentro del rango",numero);
                }
                else
                {
                    Console.WriteLine("El numero {0} esta fuera de rango",numero);
                }
            }

            Console.ReadLine();

        }
    }
}
