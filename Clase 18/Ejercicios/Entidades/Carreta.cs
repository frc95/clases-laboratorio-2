using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carreta : Vehiculo , IARBA
    {
        public Carreta(double precio) : base(precio) { }

        public override double GetPrecio
        {
            get {
                IARBA impuesto=this;
                return this._precio+impuesto.CalcularImpuesto(); }
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio*0.18;
        }
    }
}
