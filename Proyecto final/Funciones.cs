using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_final
{
    internal class Funciones
    {
        public int getMaxDigit(int number)
        {
            int maxDigit = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
                number /= 10;
            }
            return maxDigit;

        }

        public int SumarDigitosPares(string numero)
        {
            int suma = 0;
            foreach (char digito in numero)
            {
                if (char.IsDigit(digito))
                {
                    int digitoInt = (int)char.GetNumericValue(digito);
                    if (digitoInt % 2 == 0)
                    {
                        suma += digitoInt;
                    }
                }
            }
            return suma;
        }

        public string MoverMayorDigitoAlFinal(string numero)
        {
            if (string.IsNullOrEmpty(numero))
            {
                return numero;
            }
            char mayorDigito = numero.Max();
            int indice = numero.LastIndexOf(mayorDigito);

            // Construir el nuevo número sin el mayor dígito y luego agregarlo al final
            string nuevoNumero = numero.Remove(indice, 1) + mayorDigito;

            return nuevoNumero;
        }

        public bool DigitosOrdenados(string numero)
        {
            if (string.IsNullOrEmpty(numero)) return false;

            for (int i = 1; i < numero.Length; i++)
            {
                if (numero[i] < numero[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int ContarImparesAntesDePar(string numero)
        {
            if (string.IsNullOrEmpty(numero))
            {
                return 0;
            }  
            int contador = 0;
            bool encontradoPar = false;

            for (int i = 0; i < numero.Length; i++)
            {
                if (char.IsDigit(numero[i]))
                {
                    int digito = (int)char.GetNumericValue(numero[i]);

                    if (digito % 2 == 0)
                    {
                        encontradoPar = true;
                    }
                    else if (!encontradoPar)
                    {
                        contador++;
                    }
                }
            }

            return contador;
        }
    }

    
}
