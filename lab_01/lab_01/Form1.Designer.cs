namespace lab_01;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Title title15 = new System.Windows.Forms.DataVisualization.Charting.Title();
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
        System.Windows.Forms.DataVisualization.Charting.Title title16 = new System.Windows.Forms.DataVisualization.Charting.Title();
        this.labelDistributionTypes = new System.Windows.Forms.Label();
        this.radioButton1 = new System.Windows.Forms.RadioButton();
        this.radioButton2 = new System.Windows.Forms.RadioButton();
        this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        this.label1 = new System.Windows.Forms.Label();
        this.paramsUniform = new System.Windows.Forms.Panel();
        this.label6 = new System.Windows.Forms.Label();
        this.b = new System.Windows.Forms.TextBox();
        this.a = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.err = new System.Windows.Forms.Label();
        this.paramsPoisson = new System.Windows.Forms.Panel();
        this.label5 = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.k = new System.Windows.Forms.TextBox();
        this.lambda = new System.Windows.Forms.TextBox();
        this.label8 = new System.Windows.Forms.Label();
        this.label9 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
        this.paramsUniform.SuspendLayout();
        this.paramsPoisson.SuspendLayout();
        this.SuspendLayout();
        // 
        // labelDistributionTypes
        // 
        this.labelDistributionTypes.AutoSize = true;
        this.labelDistributionTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.labelDistributionTypes.Location = new System.Drawing.Point(12, 15);
        this.labelDistributionTypes.Name = "label2";
        this.labelDistributionTypes.Size = new System.Drawing.Size(22, 17);
        this.labelDistributionTypes.TabIndex = 7;
        this.labelDistributionTypes.Text = "Распределение:";
        // 
        // radioButton1
        // 
        this.radioButton1.AutoSize = true;
        this.radioButton1.Checked = true;
        this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.radioButton1.Location = new System.Drawing.Point(12, 42);
        this.radioButton1.Name = "radioButton1";
        this.radioButton1.Size = new System.Drawing.Size(247, 21);
        this.radioButton1.TabIndex = 1;
        this.radioButton1.TabStop = true;
        this.radioButton1.Text = "Равномерное";
        this.radioButton1.UseVisualStyleBackColor = true;
        this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
        // 
        // radioButton2
        // 
        this.radioButton2.AutoSize = true;
        this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.radioButton2.Location = new System.Drawing.Point(12, 69);
        this.radioButton2.Name = "radioButton2";
        this.radioButton2.Size = new System.Drawing.Size(239, 21);
        this.radioButton2.TabIndex = 2;
        this.radioButton2.Text = "Пуассона";
        this.radioButton2.UseVisualStyleBackColor = true;
        this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
        // 
        // chart1
        // 
        chartArea15.Name = "ChartArea1";
        this.chart1.ChartAreas.Add(chartArea15);
        this.chart1.Location = new System.Drawing.Point(288, 15);
        this.chart1.Name = "chart1";
        series15.BorderWidth = 3;
        series15.ChartArea = "ChartArea1";
        series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series15.Name = "Series1";
        series17.BorderWidth = 3;
        series17.ChartArea = "ChartArea1";
        series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        series17.Name = "Series2";
        this.chart1.Series.Add(series15);
        this.chart1.Series.Add(series17);
        this.chart1.Size = new System.Drawing.Size(594, 303);
        this.chart1.TabIndex = 0;
        this.chart1.Series["Series1"].Color = Color.Blue;
        this.chart1.Series["Series2"].Color = Color.Blue;
        this.chart1.Text = "chart1";
        title15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        title15.Name = "Title1";
        title15.Text = "График функции плотности распределения";
        this.chart1.Titles.Add(title15);
        this.chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.chart1.ChartAreas[0].AxisX.Title = "x";
        this.chart1.ChartAreas[0].AxisY.Title = "f(x)";
        // this.chart1.ChartAreas[0].AxisX.Minimum = ChartXMinValue;
        // this.chart1.ChartAreas[0].AxisX.Maximum = ChartXMaxValue;
        // 
        // chart2
        // 
        chartArea16.Name = "ChartArea1";
        this.chart2.ChartAreas.Add(chartArea16);
        this.chart2.Location = new System.Drawing.Point(288, 333);
        this.chart2.Name = "chart2";
        series16.BorderWidth = 3;
        series16.ChartArea = "ChartArea1";
        series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        series16.Name = "Series1";
        series18.BorderWidth = 3;
        series18.ChartArea = "ChartArea1";
        series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        series18.Name = "Series2";
        this.chart2.Series.Add(series16);
        this.chart2.Series.Add(series18);
        this.chart2.Size = new System.Drawing.Size(594, 303);
        this.chart2.TabIndex = 3;
        this.chart2.Series["Series1"].Color = Color.Green;
        this.chart2.Series["Series2"].Color = Color.Green;
        this.chart2.Text = "chart2";
        title16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        title16.Name = "Title1";
        title16.Text = "График функции распределения";
        this.chart2.Titles.Add(title16);
        this.chart2.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.chart2.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
        this.chart2.ChartAreas[0].AxisX.Title = "x";
        this.chart2.ChartAreas[0].AxisY.Title = "F(x)";
        // this.chart2.ChartAreas[0].AxisX.Minimum = ChartXMinValue;
        // this.chart2.ChartAreas[0].AxisX.Maximum = ChartXMaxValue;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label1.Location = new System.Drawing.Point(13, 157);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(98, 17);
        this.label1.TabIndex = 4;
        this.label1.Text = "Параметры:";
        // 
        // paramsUniform
        // 
        this.paramsUniform.Controls.Add(this.label6);
        this.paramsUniform.Controls.Add(this.b);
        this.paramsUniform.Controls.Add(this.a);
        this.paramsUniform.Controls.Add(this.label3);
        this.paramsUniform.Controls.Add(this.label2);
        this.paramsUniform.Location = new System.Drawing.Point(12, 181);
        this.paramsUniform.Name = "paramsUniform";
        this.paramsUniform.Size = new System.Drawing.Size(236, 100);
        this.paramsUniform.TabIndex = 6;
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label6.Location = new System.Drawing.Point(159, 30);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(45, 17);
        this.label6.TabIndex = 12;
        this.label6.Text = "a < b";
        // 
        // b
        // 
        this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.b.Location = new System.Drawing.Point(40, 47);
        this.b.Name = "b";
        this.b.Size = new System.Drawing.Size(100, 23);
        this.b.TabIndex = 11;
        this.b.Text = "5";
        // 
        // a
        // 
        this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.a.Location = new System.Drawing.Point(40, 10);
        this.a.Name = "a";
        this.a.Size = new System.Drawing.Size(100, 23);
        this.a.TabIndex = 10;
        this.a.Text = "-5";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label3.Location = new System.Drawing.Point(12, 50);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(22, 17);
        this.label3.TabIndex = 8;
        this.label3.Text = "b:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label2.Location = new System.Drawing.Point(12, 10);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(22, 17);
        this.label2.TabIndex = 7;
        this.label2.Text = "a:";
        // 
        // button1
        // 
        this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
        this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
        this.button1.FlatAppearance.BorderSize = 2;
        this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
        this.button1.Location = new System.Drawing.Point(12, 287);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(250, 32);
        this.button1.TabIndex = 7;
        this.button1.Text = "Построить графики";
        this.button1.UseVisualStyleBackColor = false;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // 
        // err
        // 
        this.err.AutoSize = true;
        this.err.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.err.ForeColor = System.Drawing.Color.Red;
        this.err.Location = new System.Drawing.Point(8, 334);
        this.err.Name = "err";
        this.err.Size = new System.Drawing.Size(274, 17);
        this.err.TabIndex = 10;
        this.err.Text = "ОШИБКА: данные введены неверно";
        this.err.Visible = false;
        // 
        // paramsPoisson
        // 
        this.paramsPoisson.Controls.Add(this.label5);
        this.paramsPoisson.Controls.Add(this.label7);
        this.paramsPoisson.Controls.Add(this.k);
        this.paramsPoisson.Controls.Add(this.lambda);
        this.paramsPoisson.Controls.Add(this.label8);
        this.paramsPoisson.Controls.Add(this.label9);
        this.paramsPoisson.Location = new System.Drawing.Point(12, 181);
        this.paramsPoisson.Name = "paramsPoisson";
        this.paramsPoisson.Size = new System.Drawing.Size(236, 100);
        this.paramsPoisson.TabIndex = 13;
        this.paramsPoisson.Visible = false;
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label5.Location = new System.Drawing.Point(159, 10);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(45, 17);
        this.label5.TabIndex = 5;
        this.label5.Text = "λ > 0";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label7.Location = new System.Drawing.Point(159, 50);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(45, 17);
        this.label7.TabIndex = 12;
        this.label7.Text = "k >= 0";
        // 
        // k
        // 
        this.k.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.k.Location = new System.Drawing.Point(40, 47);
        this.k.Name = "k";
        this.k.Size = new System.Drawing.Size(100, 23);
        this.k.TabIndex = 11;
        this.k.Text = "5";
        // 
        // lambda
        // 
        this.lambda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lambda.Location = new System.Drawing.Point(40, 10);
        this.lambda.Name = "lambda";
        this.lambda.Size = new System.Drawing.Size(100, 23);
        this.lambda.TabIndex = 10;
        this.lambda.Text = "1";
        // 
        // labelK
        // 
        this.label8.AutoSize = true;
        this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label8.Location = new System.Drawing.Point(12, 50);
        this.label8.Name = "labelK";
        this.label8.Size = new System.Drawing.Size(22, 17);
        this.label8.TabIndex = 8;
        this.label8.Text = "k:";
        // 
        // labelLambda
        // 
        this.label9.AutoSize = true;
        this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.label9.Location = new System.Drawing.Point(12, 10);
        this.label9.Name = "labelLambda";
        this.label9.Size = new System.Drawing.Size(22, 17);
        this.label9.TabIndex = 7;
        this.label9.Text = "λ:";
        // 
        // Form1
        // 
        //this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //this.ClientSize = new System.Drawing.Size(922, 677);
        this.ClientSize = new System.Drawing.Size(900, 650);
        this.CenterToScreen();
        this.Controls.Add(this.paramsPoisson);
        this.Controls.Add(this.err);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.paramsUniform);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.labelDistributionTypes);
        this.Controls.Add(this.radioButton1);
        this.Controls.Add(this.radioButton2);
        this.Controls.Add(this.chart1);
        this.Controls.Add(this.chart2);
        this.Name = "Form1";
        this.Text = "ЛР N1";
        ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
        this.paramsUniform.ResumeLayout(false);
        this.paramsUniform.PerformLayout();
        this.paramsPoisson.ResumeLayout(false);
        this.paramsPoisson.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    private System.Windows.Forms.Label labelDistributionTypes;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel paramsUniform;
    private System.Windows.Forms.TextBox a;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox b;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label err;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Panel paramsPoisson;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox k;
    private System.Windows.Forms.TextBox lambda;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;

    // private double ChartXMinValue = -10.0;
    // private double ChartXMaxValue = 10.0;
}
