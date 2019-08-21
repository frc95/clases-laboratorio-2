using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2_Ejercicio01
{
    public class  MiClase 
    {
        public static string nombre="Juan";
        public static int edad=15;
        public static void MostrarEdad()
        {
            Console.WriteLine("La edad es: {0}", MiClase.edad);
            Console.ReadLine();
        }
        public static string RetornarNombre()
        {
            return MiClase.nombre;
            
        }
        public static bool CompararNombres(string nombre)
        {
            if(nombre==MiClase.nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        

    }
}
