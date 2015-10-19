using System;
using System.Collections.Generic;

namespace Tecnicas
{
    public class TecnicasConteo
    {
        private MathTools mt;

        public TecnicasConteo()
        {
            mt = new MathTools();
        }

        public int permutacionSinRepeticion(int n)
        {
            return mt.factorial(n);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Cantidad de elementos que contiene</param>
        /// <param name="subconjuntos">Una lista que contiene subconjuntos cuya suma es n</param>
        /// <returns></returns>
        public int permutacionConRepeticion(int n, List<int> subconjuntos)
        {
            int denominador = 1;

            foreach(int m in subconjuntos)
            {
                denominador *= mt.factorial(m);
                Console.WriteLine(m);
            }     

            if (denominador == 0)
                return 1;

            return mt.factorial(n) / denominador;
        }

        public int variacionSinRepeticion(int n, int m)
        {
            int divisor = mt.factorial(n - m);

            return mt.factorial(n) / divisor;
        }

        public int variacionConRepeticion(int n, int m)
        {
            return (int)Math.Pow(n, m);
        }

        public int combinacionSinRepeticion(int n, int m)
        {
            int divisor = mt.factorial(m) * mt.factorial(n - m);

            return mt.factorial(n) / divisor;
        }

        public int combinacionConRepeticion(int n, int m)
        {
            int numerador = mt.factorial(m + n - 1);
            int denominador = mt.factorial(n) * mt.factorial(m - 1);

            Console.WriteLine("Num: " + numerador + " Dem: " + denominador);

            return numerador / denominador;
        }

        public int permutacionCircular(int n)
        {
            return mt.factorial(n - 1);
        }

        public int reglaMultiplicativa(int k)
        {
            return -1;
        }

        public int reglaAditiva()
        {
            return -1;
        }
    }

    public class MathTools
    {
        public MathTools()
        {

        }

        public int factorial(int numero)
        {
            if (numero == 0)
                return 1;

            return numero * factorial(numero - 1);
        }


    }
}