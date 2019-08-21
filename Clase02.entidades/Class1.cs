using System;

namespace Clase02.entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static string imprimir( )
        {
            Console.WriteLine(Sello.mensaje);
            return Sello.mensaje;
        }
        public static void borrar()
        {
            Sello.mensaje = " ";
        }
        public static void imprimirColor()
        {
            Console.ForegroundColor = color;

            
            Console.WriteLine(Sello.mensaje);

        }
        private static string astericoConMensaje()
        {
            Console.WriteLine("*" + Sello.mensaje + "*");
            return Sello.mensaje;

        }
    }
}
