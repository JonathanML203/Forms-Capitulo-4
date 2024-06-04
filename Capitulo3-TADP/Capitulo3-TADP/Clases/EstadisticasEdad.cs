using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo3_TADP.Clases
{
    internal class EstadisticasEdad
    {
        public static double CalcularPromedio(List<int> edades)
        {
            if (edades.Count == 0) return 0;
            return edades.Average();
        }

        public static int EncontrarEdadMayor(List<int> edades)
        {
            if (edades.Count == 0) return 0;
            return edades.Max();
        }

        public static int EncontrarEdadMenor(List<int> edades)
        {
            if (edades.Count == 0) return 0;
            return edades.Min();
        }

    }
}
