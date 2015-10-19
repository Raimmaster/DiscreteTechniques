using System;

public class TecnicasConteo
{
    public MathTools mt;

	public TecnicasConteo()
	{
        mt = new MathTools();
	}

    public int permutacionSinRepeticion(int n)
    {
        return mt.factorial(n);
    }

    public int permutacionConRepeticion(int n)
    {

    }

    public int variacionSinRepeticion(int n, int m)
    {
        int divisor = mt.factorial(n - m);

        return mt.factorial(n) / divisor;
    }

    public int variacionConRepeticion(int n, int m)
    {
        return (int) Math.Pow(n, m);
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

        return numerador / denominador;
    }

    public int permutacionCircular(int n)
    {
        return mt.factorial(n - 1);
    }

    public int reglaMultiplicativa(int k)
    {

    }

    public int reglaAditiva()
    {

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