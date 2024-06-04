using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo3_TADP.Clases
{
    internal class Primos
    {
        public static List<int> EncontrarPrimos(int limiteInferior, int limiteSuperior)
        {
            List<int> primos = new List<int>();

            for (int num = limiteInferior; num <= limiteSuperior; num++)
            {
                if (EsPrimo(num))
                {
                    primos.Add(num);
                }
            }

            return primos;
        }

        private static bool EsPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}
