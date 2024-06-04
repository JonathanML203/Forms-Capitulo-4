using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo3_TADP.Clases
{
    internal class Potencia
    {
        public static double CalcularPotencia(double baseNumero, double exponente)
        {
            return Math.Pow(baseNumero, exponente);
        }
    }
}
