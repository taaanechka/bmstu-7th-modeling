namespace lab_02
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.userNum = new System.Windows.Forms.NumericUpDown();
            this.go = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество состояний (<= 10):";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // userNum
            // 
            this.userNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNum.Location = new System.Drawing.Point(319, 5);
            this.userNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.userNum.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.userNum.Name = "userNum";
            this.userNum.ReadOnly = true;
            this.userNum.Size = new System.Drawing.Size(77, 23);
            this.userNum.TabIndex = 3;
            this.userNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.userNum.Click += new System.EventHandler(this._getNum_Click);
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.go.Location = new System.Drawing.Point(155, 330);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(118, 27);
            this.go.TabIndex = 124;
            this.go.Text = "Рассчитать";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this._go_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(267, 592);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(178, 22);
            this.error.TabIndex = 125;
            this.error.Text = "ОШИБКА ввода данных";
            this.error.UseCompatibleTextRendering = true;
            this.error.Visible = false;
            // 
            // chart1
            // 
            chartArea2.AxisX.Title = "Время, с";
            chartArea2.AxisY.Title = "Вероятность";
            chartArea2.BorderWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Состояния:";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(450, 10);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(685, 490);
            this.chart1.TabIndex = 126;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            title2.Name = "Title1";
            title2.Text = "Зависимость вероятности от времени";
            this.chart1.Titles.Add(title2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 717);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.go);
            this.Controls.Add(this.userNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ЛР N2";
            ((System.ComponentModel.ISupportInitialize)(this.userNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown userNum;

        private System.Windows.Forms.TextBox[,] arrs;
        private System.Windows.Forms.Label[] labelHeadColumns;
        private System.Windows.Forms.Label[] labelHeadRows;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        
        private System.Windows.Forms.TextBox[] p;
        private System.Windows.Forms.TextBox[] t;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}