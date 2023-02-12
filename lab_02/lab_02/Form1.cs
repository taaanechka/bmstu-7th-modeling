using System;
using System.Windows.Forms;

namespace lab_02
{
    public partial class Form1 : Form
    {
        SModel model;

        public Form1()
        {
            model = new SModel();

            InitializeComponent();
            _EnableMtr(model.defaultNum);
        }

        private void _exitError()
        {
            error.Visible = true;
            
            _clearSeries();
            _clearOutput();
        }

        private void _hideError()
        {
            error.Visible = false;

            _clearSeries();
            // _clearOutput();
        }

        private void _clearControls()
        {
            // columns head
            for (int i = 0; i < model.MaxStateNum; i++)
            {
                if (this.Controls.ContainsKey($"labelHeadColumns{i}") == true)
                {
                    this.Controls.Remove(this.labelHeadColumns[i]);
                }
            }

            // rows head
            for (int i = 0; i < model.MaxStateNum; i++)
            {
                if (this.Controls.ContainsKey($"labelHeadRows{i}") == true)
                {
                    this.Controls.Remove(this.labelHeadRows[i]);
                }
            }

            // arr
            for (int i = 0; i < model.MaxStateNum; i++)
            {
                for (int j = 0; j < model.MaxStateNum; j++)
                {
                    if (this.Controls.ContainsKey($"arr{i}{j}") == true)
                    {
                        this.Controls.Remove(this.arrs[i,j]);
                    }
                }
            }

            // p
            for (int i = 0; i < model.MaxStateNum; i ++)
            {
                if (this.Controls.ContainsKey($"p{i}") == true)
                {
                    this.Controls.Remove(this.p[i]);
                }
            }

            // t
            for (int i = 0; i < model.MaxStateNum; i ++)
            {
                if (this.Controls.ContainsKey($"t{i}") == true)
                {
                    this.Controls.Remove(this.t[i]);
                }
            }
        }

        private void _clearOutput()
        {
            for (int i = 0; i < SModel.inputNum; i++)
            {
                if (this.Controls.ContainsKey($"p{i}") == true)
                {
                    this.Controls[$"p{i}"].Text = "";
                }
                
                if (this.Controls.ContainsKey($"t{i}") == true)
                {
                    this.Controls[$"t{i}"].Text = "";
                }
            }
        }

        private void _clearSeries()
        {
            for (int i = 0; i < chart1.Series.Count; i++)
            {
                chart1.Series[i].Points.Clear();
            }
        }

        private void _EnableMtr(int ind)
        {
            string temp, name = "arr";

            _hideError();

            // mtr
            this.arrs = new System.Windows.Forms.TextBox[ind, ind];
            int x_0 = 58, x_step = 62;
            int y_0 = 132, y_step = 38;
            int x_size = 56, y_size = 23;

            for (int i = 0; i < ind; i++)
            {
                for (int j = 0; j < ind; j++)
                {
                    temp = name + i.ToString() + j.ToString();

                    this.arrs[i, j] = new System.Windows.Forms.TextBox();
 
                    this.arrs[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    this.arrs[i, j].Location = new System.Drawing.Point(x_0 + x_step * j, y_0 + y_step * i);
                    this.arrs[i, j].Name = temp;
                    this.arrs[i, j].Size = new System.Drawing.Size(x_size, y_size);
                    this.arrs[i, j].TabIndex = 4 + i + j;
                    this.arrs[i, j].UseWaitCursor = true;

                    this.Controls.Add(this.arrs[i, j]);
                }
            }

            // columns labels
            int x_head_0 = 58;
            int y_head_0 = 100;

            this.labelHeadColumns = new System.Windows.Forms.Label[ind];

            for (int i = 0; i < ind; i++)
            {
                this.labelHeadColumns[i] = new System.Windows.Forms.Label();

                this.labelHeadColumns[i].AutoSize = true;
                this.labelHeadColumns[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.labelHeadColumns[i].Location = new System.Drawing.Point(x_head_0 + x_step * i, y_head_0);
                this.labelHeadColumns[i].Name = $"labelHeadColumns{i}";
                this.labelHeadColumns[i].Size = new System.Drawing.Size(14, 22);
                this.labelHeadColumns[i].TabIndex = 104 + i;
                this.labelHeadColumns[i].Text = $"{i + 1}";
                this.labelHeadColumns[i].UseCompatibleTextRendering = true;

                this.Controls.Add(this.labelHeadColumns[i]);
            }

            // rows labels
            int x_head_row_0 = x_head_0 - x_step / 2;
            int y_head_row_0 = y_head_0;

            this.labelHeadRows = new System.Windows.Forms.Label[ind];

            for (int i = 0; i < ind; i++)
            {
                this.labelHeadRows[i] = new System.Windows.Forms.Label();

                this.labelHeadRows[i].AutoSize = true;
                this.labelHeadRows[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.labelHeadRows[i].Location = new System.Drawing.Point(x_head_row_0, y_0 + y_step * i);
                this.labelHeadRows[i].Name = $"labelHeadRows{i}";
                this.labelHeadRows[i].Size = new System.Drawing.Size(14, 22);
                this.labelHeadRows[i].TabIndex = 114 + i;
                this.labelHeadRows[i].Text = $"{i + 1}";
                this.labelHeadRows[i].UseCompatibleTextRendering = true;

                this.Controls.Add(this.labelHeadRows[i]);
            }

            // res: p && T
            int max_i = x_0 + x_step * ind;
            int max_j = y_0 + y_step * ind;

            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(x_0, max_j);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(620, 17);
            this.label23.TabIndex = 147;
            this.label23.Text = "----------------------------------------------------------------------------";
            // 
            // label24 p
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(x_0 - x_step / 2, max_j + y_step);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(16, 22);
            this.label24.TabIndex = 148;
            this.label24.Text = "P";
            this.label24.UseCompatibleTextRendering = true;
            // 
            // label25 t
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(x_0 - x_step / 2, max_j + y_step * 2);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 22);
            this.label25.TabIndex = 149;
            this.label25.Text = "T";
            this.label25.UseCompatibleTextRendering = true;

            // p values
            this.p = new System.Windows.Forms.TextBox[ind];

            for (int i = 0; i < ind; i++)
            {
                this.p[i] = new System.Windows.Forms.TextBox();

                this.p[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.p[i].Location = new System.Drawing.Point(x_0 + x_step * i, max_j + y_step);
                this.p[i].Name = $"p{i}";
                this.p[i].ReadOnly = true;
                this.p[i].Size = new System.Drawing.Size(56, 23);
                this.p[i].TabIndex = 127 + i;

                this.Controls.Add(this.p[i]);
            }

            // t values
            this.t = new System.Windows.Forms.TextBox[ind];

            for (int i = 0; i < ind; i++)
            {
                this.t[i] = new System.Windows.Forms.TextBox();

                this.t[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.t[i].Location = new System.Drawing.Point(x_0 + x_step * i, max_j + y_step * 2);
                this.t[i].Name = $"t{i}";
                this.t[i].ReadOnly = true;
                this.t[i].Size = new System.Drawing.Size(56, 23);
                this.t[i].TabIndex = 137 + i;

                this.Controls.Add(this.t[i]);
            }
        }

        private void _getNum_Click(object sender, EventArgs e)
        {
            int num;

            _hideError();
            _clearControls();

            try 
            {
                num = int.Parse(userNum.Text);
            }
            catch 
            {
                _exitError();
                return;
            }

            SModel.inputNum = num;
            _EnableMtr(num);
        }

        private void _go_Click(object sender, EventArgs e)
        {
            string tempStr, tempP, name = "arr";
            double tempNum;

            _hideError();

            for (int i = 0; i < SModel.inputNum; i++)
                for (int j = 0; j < SModel.inputNum; j++)
                {
                    tempStr = name + i.ToString() + j.ToString();

                    try
                    {
                        tempP = this.Controls[tempStr].Text;
                        if (String.Compare(tempP, "") == 0)
                            model.mtr[i, j] = 0;
                        else
                        {
                            tempNum = double.Parse(this.Controls[tempStr].Text);

                            if (tempNum < 0 || tempNum > 1)
                            {
                                _exitError();
                                return;
                            }

                            model.mtr[i, j] = tempNum;
                        }
                    }
                    catch
                    {
                        _exitError();
                        return;
                    }
                }

            model.Emulate(ref chart1);
            // _outData(model.timeArr, "t");
            _outData(model.steadyTimeArr, "t");
            _outData(model.pArr, "p"); ;
        }

        private void _outData(double[] arr, string name)
        {
            string tempStr;

            for (int i = 0; i < SModel.inputNum; i++)
            {
                tempStr = name + i.ToString();
                this.Controls[tempStr].Text = Math.Round(arr[i], 3).ToString();
            }
        }
    }
}