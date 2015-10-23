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

        public UInt64 permutacionSinRepeticion(UInt64 n)
        {
            return mt.factorial(n);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Cantidad de elementos que contiene</param>
        /// <param name="subconjuntos">Una lista que contiene subconjuntos cuya suma es n</param>
        /// <returns></returns>
        public UInt64 permutacionConRepeticion(UInt64 n, List<UInt64> subconjuntos)
        {
            UInt64 denominador = 1;

            foreach(UInt64 m in subconjuntos)
            {
                denominador *= mt.factorial(m);
                Console.WriteLine(m);
            }     

            if (denominador == 0)
                return 1;

            return mt.factorial(n) / denominador;
        }

        public UInt64 variacionSinRepeticion(UInt64 n, UInt64 m)
        {
            UInt64 divisor = mt.factorial(n - m);

            return mt.factorial(n) / divisor;
        }

        public UInt64 variacionConRepeticion(UInt64 n, UInt64 m)
        {
            return (UInt64)Math.Pow(n, m);
        }

        public UInt64 combinacionSinRepeticion(UInt64 n, UInt64 m)
        {
            UInt64 divisor = mt.factorial(m) * mt.factorial(n - m);

            return mt.factorial(n) / divisor;
        }

        public UInt64 combinacionConRepeticion(UInt64 n, UInt64 m)
        {
            UInt64 numerador = mt.factorial(m + n - 1);
            UInt64 denominador = mt.factorial(n) * mt.factorial(m - 1);

            Console.WriteLine("Num: " + numerador + " Dem: " + denominador);

            return numerador / denominador;
        }

        public UInt64 permutacionCircular(UInt64 n)
        {
            return mt.factorial(n - 1);
        }

        public UInt64 reglaMultiplicativa(UInt64 k)
        {
            return 0;
        }

        public UInt64 reglaAditiva()
        {
            return 0;
        }
    }

    public class MathTools
    {
        public MathTools()
        {

        }

        public UInt64 factorial(UInt64 numero)
        {
            if (numero == 0)
                return 1;

            return numero * factorial(numero - 1);
        }


    }
}