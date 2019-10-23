using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        protected string _patente;
        public Auto(double precio, string patente):base(precio)
        {
            this._patente = patente;
        }

        public override double GetPrecio
        {
            get { return this._precio; }
        }

        public void MostrarPatente()
        {
            Console.WriteLine(this._patente);
        }
        
    }
}
