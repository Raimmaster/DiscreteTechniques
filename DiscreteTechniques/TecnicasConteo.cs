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

        public double permutacionSinRepeticion(double n)
        {
            return mt.factorial(n);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Cantidad de elementos que contiene</param>
        /// <param name="subconjuntos">Una lista que contiene subconjuntos cuya suma es n</param>
        /// <returns></returns>
        public double permutacionConRepeticion(double n, List<double> subconjuntos)
        {
            double denominador = 1;

            foreach(double m in subconjuntos)
            {
                denominador *= mt.factorial(m);
                Console.WriteLine(m);
            }     

            if (denominador == 0)
                return 1;

            return mt.factorial(n) / denominador;
        }

        public double variacionSinRepeticion(double n, double m)
        {
            double divisor = mt.factorial(n - m);

            return mt.factorial(n) / divisor;
        }

        public double variacionConRepeticion(double n, double m)
        {
            return (double)Math.Pow(n, m);
        }

        public double combinacionSinRepeticion(double n, double m)
        {
            double divisor = mt.factorial(m) * mt.factorial(n - m);

            return mt.factorial(n) / divisor;
        }

        public double combinacionConRepeticion(double n, double m)
        {
            double numerador = mt.factorial(m + n - 1);
            double denominador = mt.factorial(n) * mt.factorial(m - 1);

            Console.WriteLine("Num: " + numerador + " Dem: " + denominador);

            return numerador / denominador;
        }

        public double permutacionCircular(double n)
        {
            return mt.factorial(n - 1);
        }

        public double reglaMultiplicativa(List<double> subconjuntos)
        {
            double tot = 1;
            foreach(double n in subconjuntos)
            {
                tot *= n;
            }

            return tot;
        }

        public double reglaAditiva(List<double> subconjuntos)
        {
            double tot = 0;
            foreach (double n in subconjuntos)
            {
                tot += n;
            }

            return tot;
        }
    }

    public class MathTools
    {
        public MathTools()
        {

        }

        public double factorial(double numero)
        {
            if (numero == 0)
                return 1;

            return numero * factorial(numero - 1);
        }


    }
}