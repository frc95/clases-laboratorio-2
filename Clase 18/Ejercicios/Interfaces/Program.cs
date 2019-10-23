using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IAFIP vehiculo;
            IARBA vehiculoProvincial;
            Auto deport = new Deportivo(100,"ASW45",230);
            Avion avion = new Avion(1000,550);
            Auto deport2 = new Deportivo(1500, "ASDGW", 250);
            Avion avionComercial = new Comercial(2000, 600, 150);
            Avion avionPrivado = new Privado(3000, 570, 8);
            Vehiculo carreta = new Carreta(150);

            vehiculo = (Deportivo)deport;

            Console.WriteLine("El impuesto es: "+Gestion.MostrarImpuestoNacional((Deportivo)deport));

            vehiculo = avion;
            Console.WriteLine("El impuesto es: " + Gestion.MostrarImpuestoNacional(vehiculo));

            vehiculo = (Deportivo)deport2;
            Console.WriteLine("El impuesto es: " + Gestion.MostrarImpuestoNacional(vehiculo));

            
            Console.WriteLine("El impuesto es: " + Gestion.MostrarImpuestoNacional(avionComercial));

            vehiculo = avionPrivado;
            Console.WriteLine("El impuesto es: " + Gestion.MostrarImpuestoNacional(avionPrivado));
            avionPrivado.MostrarPrecio();
            Console.WriteLine(avionPrivado.GetTotal);

            vehiculoProvincial = (Deportivo)deport;
            Console.WriteLine("El impuesto provincial es: " + Gestion.MostrarImpuestoProvincial(vehiculoProvincial));

            
            Console.WriteLine("El impuesto provincial es: " + Gestion.MostrarImpuestoProvincial((Carreta)carreta));

            vehiculoProvincial = avionComercial;

            Console.WriteLine("El impuesto provincial es: " + Gestion.MostrarImpuestoProvincial(vehiculoProvincial));

            vehiculoProvincial = avionPrivado;

            Console.WriteLine("El impuesto provincial es: " + Gestion.MostrarImpuestoProvincial(vehiculoProvincial));


            Console.WriteLine("El impuesto + precio: "+ carreta.GetPrecio);


            Console.ReadKey();

            
        }
    }
}
