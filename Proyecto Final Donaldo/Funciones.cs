using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Donaldo
{
    internal class Funciones
    {
        public int ContarPalabras(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return 0;
            }

            string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return palabras.Length;
        }

        public string EliminarVocales(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return texto;
            }

            string vocales = "aeiouAEIOU";
            char[] resultado = texto.Where(c => !vocales.Contains(c)).ToArray();
            return new string(resultado);
        }

        public string EncontrarPalabraMasLarga(string cadena)
        {
            if (string.IsNullOrWhiteSpace(cadena))
            {
                throw new ArgumentException("La cadena no puede estar vacía o ser nula.");
            }
            string[] palabras = cadena.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string palabraMasLarga = palabras[0];
            int longitudMasLarga = palabraMasLarga.Length;
            foreach (string palabra in palabras)
            {
                int longitudActual = palabra.Length;
                if (longitudActual > longitudMasLarga)
                {
                    palabraMasLarga = palabra;
                    longitudMasLarga = longitudActual;
                }
            }

            return palabraMasLarga;
        }

        public string EliminarPrimeraLetraDeCadaPalabra(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return texto;
            }
            string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 1)
                {
                    palabras[i] = palabras[i].Substring(1);
                }
                else
                {
                    palabras[i] = string.Empty;
                }
            }
            return string.Join(" ", palabras);
        }

        public string InvertirCadaPalabra(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return texto;
            }

            string[] palabras = texto.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < palabras.Length; i++)
            {
                char[] caracteres = palabras[i].ToCharArray();
                Array.Reverse(caracteres);
                palabras[i] = new string(caracteres);
            }

            return string.Join(" ", palabras);
        }
    }  
}
