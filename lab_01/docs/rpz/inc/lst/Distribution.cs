public class Distribution
{
    public static void Uniform(double a, double b, double[] arrX, out double[] arrf, out double[] arrF)
    {
        int n = arrX.Length;
        arrf = new double[n];
        arrF = new double[n];

        if (a >= b)
            throw new Exception();

        for (int i = 0; i < n; i++)
        {
            arrf[i] = _Uniformf(a, b, arrX[i]);
            arrF[i] = _UniformF(a, b, arrX[i]);
        }
    }

    private static double _Uniformf(double a, double b, double x)
    {
        return (a <= x && x <= b) ? 1 / (b - a) : 0;
    }

    private static double _UniformF(double a, double b, double x)
    {
        if (x < a) 
            return 0;

        if (x > b) 
            return 1;

        return (x - a) / (b - a);
    }

    public static void Poisson(double lambda, int k, double[] arrX, out double[] arrf, out double[] arrF)
    {
        ulong n = (ulong)arrX.Length;
        arrf = new double[n];
        arrF = new double[n];

        if (k < 0 || lambda < 1e-4)
            throw new Exception();

        ulong max_k = (ulong)arrX[n - 1];
        // arrFactorial
        ulong [] factorialK = new ulong[max_k + 1];
        factorialK[0] = 1;

        for (ulong i = 1; i < max_k + 1; i++)
        {
            factorialK[i] = i * factorialK[i - 1];
        }

        ulong factk_tmp = 1;
        arrF[0] = 0;
        arrf[0] = _Poissonf(lambda, arrX[0], factk_tmp);

        for (ulong i = 1; i < n; i++)
        {
            factk_tmp =  (arrX[i] < 1e-4) ? 1: factorialK[(ulong)arrX[i]];
            arrf[i] = _Poissonf(lambda, arrX[i], factk_tmp);
            arrF[i] = arrF[i - 1] + arrf[i - 1];          
        }
    }

    private static double _Poissonf(double lambda, double k, ulong factorial_k)
    {
        return k < 1e-4 ? 0 : (Math.Pow(lambda, k) / factorial_k) * Math.Exp(-lambda);
    }
}