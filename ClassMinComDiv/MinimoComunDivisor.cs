using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMinComDiv
{
    public class MinimoComunDivisor
    {
        public static int MinComDivi(int nro1, int nro2, int nro3, int nro4)  
        {
            int mcd_abcd = MCD(MCD(nro1, nro2), MCD(nro3, nro4));

            return mcd_abcd;

        }
        public static int MCD(int a, int b)
        {
            // Algoritmo de Euclides para encontrar el MCD
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;

        }

    }
}
