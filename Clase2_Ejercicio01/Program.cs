using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase02.entidades;

namespace Clase2_Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string nombre;

            
            MiClase.MostrarEdad();

            nombre=MiClase.RetornarNombre();

            Console.WriteLine("Su nombre es: {0}", nombre);

            nombre = "Luis";

            if(MiClase.CompararNombres(nombre))
            {
                Console.WriteLine("Los nombres son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            nombre = MiLibreria.MiClase02.retorno();

            Console.WriteLine("Nombre de la libreria: {0}",nombre);*/

            Sello.mensaje = "Hola mundo";
            Sello.color = ConsoleColor.Blue;

            Sello.mensaje=Sello.imprimir();

            //Sello.imprimirColor();

            
            

            Console.ReadLine();

            Sello.borrar();
            Sello.mensaje = Sello.imprimir();

            Console.ReadLine();

        }
    }
}
