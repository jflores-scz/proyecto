using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    internal class Series
    {
        public int ObtenerFibonacci(string num)
        {
            int n = int.Parse(num);

            if (n == 1) return 0;
            if (n == 2) return 1;

            int a = 0;
            int b = 1;
            int resultado = 0;

            for (int i = 3; i <= n; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }

            return resultado;
        }
        public int SumarTerminosSerie(string num)
        {
            int n = int.Parse(num);

            int[] serie = new int[n];
            int suma = 0;

            serie[0] = 1;
            if (n > 1) serie[1] = 2;
            if (n > 2) serie[2] = 3;

            int incremento = 3;

            for (int i = 3; i < n; i += 3)
            {
                if (i < n)
                {
                    serie[i] = serie[i - 1] + incremento;
                    suma += serie[i];
                }
                if (i + 1 < n)
                {
                    serie[i + 1] = serie[i] + 1;
                    suma += serie[i + 1];
                }
                if (i + 2 < n)
                {
                    serie[i + 2] = serie[i + 1] + incremento;
                    suma += serie[i + 2];
                }
                incremento *= 2;
            }

            for (int i = 0; i < n; i++)
            {
                suma += serie[i];
            }

            return suma;
        }
        public int SeriePares(string num)
        {
            int n = int.Parse(num);
            int suma = 0;

            for (int i = 0; i < n ; i++)
            {
                int numeroPar = 2 * i;
                suma += numeroPar;
            }
            return suma;
        }
        public int TerminoSerie(string num)
        {
            int n = int.Parse(num);

            int termino = (int)Math.Pow(2, n) - 1;

            return termino;
        }
        public int SumarTerminosPares(string num)
        {
            int n = int.Parse(num);
            int suma = 0;
            int[] serie = GenerarSerie(num);

            for (int i = 0; i < n; i++)
            {
                if (serie[i] % 2 == 0)
                {
                    suma += serie[i];
                }
            }

            return suma;
        }
        public int[] GenerarSerie(string num)
        {
            int n = int.Parse(num);
            int[] serie = new int[n];

            serie[0] = 1;

            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 1)
                {
                    serie[i] = serie[i - 1] * 2;
                }
                else if (i % 3 == 2)
                {
                    serie[i] = serie[i - 1] + 2;
                }
                else
                {
                    serie[i] = serie[i - 1] + 1;
                }
            }

            return serie;
        }
    }
}
