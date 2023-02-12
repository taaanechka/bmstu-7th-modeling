#nullable disable

using System.Globalization;

namespace lab_01;

public partial class Form1 : Form
{
    double[] arrX;
    double[] arrf;
    double[] arrF;

    public Form1()
    {
        InitializeComponent();

        paramsUniform.Visible = true;
        paramsPoisson.Visible = false;
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _ClearAll();

            paramsUniform.Visible = true;
            paramsPoisson.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _ClearAll();

            paramsUniform.Visible = false;
            paramsPoisson.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valA, valB;
            double valLambda;
            int valK;

            _ClearAll();

            if (radioButton1.Checked)
            {
                try
                {
                    valA = double.Parse(a.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                    valB = double.Parse(b.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    err.Visible = true;
                    return;
                }

                try
                {
                    double x_0 = -10;
                    double x_n = 10;
                    _MakeArrX(x_0, x_n);

                    Distribution.Uniform(valA, valB, arrX, out arrf, out arrF);

                    _DrawCharts(0);
                }
                catch (Exception)
                {
                    err.Visible = true;
                }
            }
            else if (radioButton2.Checked)
            {
                try
                {
                    valK = int.Parse(k.Text.Replace(',', '.'), CultureInfo.InvariantCulture);
                    valLambda = double.Parse(lambda.Text.Replace(',', '.'), CultureInfo.InvariantCulture);

                    if (valLambda <= 0 || valK < 0)
                    {
                        err.Visible = true;
                        return;
                    }
                }
                catch (Exception)
                {
                    err.Visible = true;
                    return;
                }

                try
                {        
                    _MakeArrX2(0, valK);
                    Distribution.Poisson(valLambda, valK, arrX, out arrf, out arrF);

                    _DrawCharts(1);
                }
                catch (Exception)
                {
                    err.Visible = true;
                }
            }
        }

        private void _MakeArrX(double a, double b)
        {
            double d = b - a;

            double step = 1e-3;
            double x = a;

            int n = (int)(d / step) + 1;
            
            arrX = new double[n];

            for (int i = 0; i < n; i++)
            {
                arrX[i] = Math.Round(x, 3);

                x += step;
            }
        }

        private void _MakeArrX2(double a, double b)
        {
            double d = b - a;

            double step = 1;
            double x = a;

            int n = (int)(d / step) + 1;
            
            arrX = new double[n];

            for (int i = 0; i < n; i++)
            {
                arrX[i] = Math.Round(x, 3);

                x += step;
            }
        }

        private void _DrawCharts(int seriesNumb)
        {
            for (int i = 0; i < arrX.Length; i++)
            {
                chart1.Series[seriesNumb].Points.AddXY(arrX[i], arrf[i]);
                chart2.Series[seriesNumb].Points.AddXY(arrX[i], arrF[i]);
            }
        }

        private void _ClearAll()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();

            err.Visible = false;
        }
}
