class SModel
{
    public int MaxStateNum { get; }
    public int defaultNum { get; }
    public static int inputNum;
    public double[,] mtr;
    public double[] pArr;
    public double[] tArr;
    public double[] steadyTimeArr;

    public SModel()
    {
        MaxStateNum = 10;
        defaultNum = 5;
        pArr = new double[MaxStateNum];
        inputNum = defaultNum;
        mtr = new double[MaxStateNum, MaxStateNum];
        
        _initP();
    }

    public void Emulate(ref Chart chart)
    {
        double[] tempArr = new double[inputNum];
        tArr = new double[inputNum];
        double step = 0.01, t = step, temp;

        List<double> tArrAll = new List<double>();
        List<List<double>> pArrAll = new List<List<double>>();

        for (int i = 0; i < inputNum; i++)
        {
            pArrAll.Add(new List<double>());
        }

        _initSeries(ref chart);

        while (true)
        {
            double[] klmArr = new double[inputNum];
            tArrAll.Add(t);
            for (int i = 0; i < inputNum; i++)
            {
                pArrAll[i].Add(pArr[i]);
            }
            
            _draw(t, pArr, ref chart);

            for (int i = 0; i < inputNum; i++)
            {
                for (int j = 0; j < inputNum; j++)
                {
                    temp = mtr[j, i] * pArr[j] - mtr[i, j] * pArr[i];
                    tempArr[i] += temp * step;
                    klmArr[i] += temp;
                }
            }

            for (int i = 0; i < inputNum; i++)
                pArr[i] += tempArr[i];

            _checkStab(t, klmArr, ref tArr);

            if (__isZeroArr(tempArr))
                break;

            _resetArr(ref tempArr);

            t += step;
        }

        _getSteadyTime(tArrAll, pArrAll, tArr, ref steadyTimeArr);

        _drawPoints(tArr, pArr, ref chart);
    }

    private void _initP()
    {
        pArr[0] = 1;
        for (int i = 1; i < MaxStateNum; i++)
            pArr[i] = 0;
    }

    private static void _initSeries(ref Chart chart)
    {
        chart.Series.Clear();

        for (int i = 0; i < inputNum; i++)
        {
            chart.Series.Add((i + 1).ToString());
            chart.Series[i].ChartType = SeriesChartType.Line;
            chart.Series[i].BorderWidth = 3;
        }
        chart.Series.Add("Points");
        chart.Series[inputNum].ChartType = SeriesChartType.Point;
        chart.Series[inputNum].Color = Color.Red;
    }

    private void _resetArr(ref double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            arr[i] = 0;
    }

    private static bool _isZeroArr(double[] arr)
    {
        double eps = 1e-8;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] > eps)
                return false;
        return true;
    }

    private static void _checkStab(double t, double[] klmArr, ref double[] tArr)
    {
        double eps = 1e-5;

        for (int i = 0; i < inputNum; i++)
        {
            if (Math.Abs(klmArr[i]) > eps && tArr[i] != 0)
                tArr[i] = 0;
            else if (Math.Abs(klmArr[i]) < eps && tArr[i] == 0)
                tArr[i] = t;
        }
    }

    private static void _getSteadyTime(List<double> tArrAll, List<List<double>> pArrAll, double[] tArr, ref double[] steadyTimeArr)
    {
        double eps = 1e-5;
        bool flag = true;

        steadyTimeArr = new double[inputNum];
        
        for (int i = 0; i < inputNum; i++)
        {
            flag = true;
            double next_p = pArrAll[i][tArrAll.Count - 1];

            for (int j = tArrAll.Count - 2; j > -1; j--)
            {
                double cur_p = pArrAll[i][j];
                if (Math.Abs(cur_p - next_p) > eps)
                {
                    steadyTimeArr[i] = Math.Abs(tArr[i] - tArrAll[j]);
                    flag = false;
                    break;
                }
                next_p = cur_p;
            }

            if (flag)
            {
                steadyTimeArr[i] = 0;
            }
        }
    }

    private static void _draw(double t, double[] arr, ref Chart chart)
    {
        for (int i = 0; i < inputNum; i++)
        {
            chart.Series[i].Points.AddXY(t, arr[i]);
        }
    }

    private static void _drawPoints(double[] x, double[] y, ref Chart chart)
    {
        for (int i = 0; i < inputNum; i++)
        {
            chart.Series[inputNum].Points.AddXY(x[i], y[i]);
        }
    }
}