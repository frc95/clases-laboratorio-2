﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class validacion
    {
        public static bool validar (int valor, int min, int max)
        {
            if(valor<min || valor>max)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
