using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected double _precio;
        public void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }
        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
        public abstract double GetPrecio { get; }
        

    }
    //La herencia multiple no esta permitida en .Net
    //Los constructores no se heredan
    //Dependiendo del modificador de visivilidad se puede usar casi todos los metodos
    //Una interfaz es una estructura que va contener metodos y propiedades  para este lenguaje en particular(c#).
    //Es un conjunto de metodos sin definicion (son metodos y propiedades abstractos) pero no puedo colocar el
    //modificador abstract en los metodos. Pero son metodos y propiedades abstractas y por definicion son publicos.
    //No es necesario poner public en los metodos y propiedades.
    //Las interfaces establecen un contrato donde la clase derivada esta obligada tiene que dar implementacion en cada uno 
    //de los metodos y porpiedades.
    //La interface no es una clase. Una clase derivada pueden heredar una n cantidad de interfaces.
    //Por definicion las interfaces son una especie de clases abstractas.
    //No es necesario poner el override en la clase derivada.
    //[modificador] interface I[identificador]   siempre el identificador empieza con la I mayuscula.
    // void Metodo();  No es necesario poner public y abstract. Es automaticamente.
    // Clase MiClase : INombreInterface 
    // Clase MiClase : OtraClase , INombreInterface   siempre va primero la clase base
}
