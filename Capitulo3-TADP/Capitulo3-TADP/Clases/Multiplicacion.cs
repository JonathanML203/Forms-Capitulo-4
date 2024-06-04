using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo3_TADP.Clases
{
    internal class Multiplicacion
    {
        public static List<string> GenerarTabla(int numero)
        {
            List<string> tabla = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                tabla.Add($"{numero} x {i} = {numero * i}");
            }
            return tabla;
        }

    }
}
