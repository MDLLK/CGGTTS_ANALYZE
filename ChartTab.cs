using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CGGTTS_ANALYZE
{
    public partial class ChartTab : Form
    {

        List<float> ChartValues = new List<float>();
        List<float> ChartValuesTemp = new List<float>();

        public ChartTab()
        {
            InitializeComponent();
            // 设置曲线的样式
            Series series = chart1.Series[0];
            // 画样条曲线（Spline）
            series.ChartType = SeriesChartType.Spline;
            // 线宽2个像素
            series.BorderWidth = 2;
            // 线的颜色：红色
            series.Color = System.Drawing.Color.Red;
            // 图示上的文字
            series.LegendText = "标准REFSYS-自研REFSYS";

            // 准备数据 
            //float[] values = { 95, 30, 20, 23, 60, 87, 42, 77, 92, 51, 29 };

            // 在chart中显示数据
            //int x = 0;
            //foreach (float v in values)
            //{
            //    series.Points.AddXY(x, v);
            //    x++;
            //}

            // 设置显示范围
            //ChartArea chartArea = chart1.ChartAreas[0];
            //chartArea.AxisX.Minimum = 0;
            //chartArea.AxisX.Maximum = 10;
            //chartArea.AxisY.Minimum = 0d;
            //chartArea.AxisY.Maximum = 100d;
        }

        public ChartTab(float[] values,int num)
        {
            InitializeComponent();
            // 设置曲线的样式
            Series series = chart1.Series[0];
            // 画样条曲线（Spline）
            series.ChartType = SeriesChartType.Spline;
            // 线宽2个像素
            series.BorderWidth = 2;
            // 线的颜色：红色
            series.Color = System.Drawing.Color.Red;
            // 图示上的文字
            series.LegendText = "标准REFSYS-自研REFSYS";

            chart1.ChartAreas[0].AxisX.Interval = 5;

            //Y轴显示小数点后两位
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = @"{0:0.00}";

            //在chart中显示数据
            for (int i = 0; i<num; i++) 
            {
                ChartValues.Add(values[i]);
                series.Points.AddXY(i, values[i]);
            }
        }

        public void Set_X_max_min(double max_x,double min_x) 
        {
            ChartArea chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.Minimum = min_x;
            chartArea.AxisX.Maximum = max_x;
        }

        public void Set_Y_max_min(double max_y, double min_y)
        {
            ChartArea chartArea = chart1.ChartAreas[0];
            chartArea.AxisY.Minimum = min_y;
            chartArea.AxisY.Maximum = max_y;
        }

        private void filterAverageBtn_Click(object sender, EventArgs e)
        {
            Series series = chart1.Series[0];
            series.Points.Clear();

            Set_Y_max_min(ChartValues.Max() - ChartValues.Average(), ChartValues.Min() - ChartValues.Average());

            for (int i = 0; i < ChartValues.Count; i++)
            {
                series.Points.AddXY(i, ChartValues.ElementAt(i) - ChartValues.Average());
            }
        }

        private void SetXRangeBtn_Click(object sender, EventArgs e)
        {
            Series series = chart1.Series[0];            
            series.Points.Clear();
            ChartValuesTemp.Clear();

            int selectNum = Convert.ToInt32(MaxXBox.Text) - Convert.ToInt32(MinXBox.Text) + 1;
            for (int i = 0; i < selectNum; i++)
            {
                ChartValuesTemp.Add(ChartValues.ElementAt(i + Convert.ToInt32(MinXBox.Text)));
            }

            Set_Y_max_min(ChartValuesTemp.Max(), ChartValuesTemp.Min());
            Set_X_max_min(Convert.ToInt32(MaxXBox.Text), Convert.ToInt32(MinXBox.Text));

            for (int i = 0; i < ChartValuesTemp.Count; i++)
            {
                series.Points.AddXY(i+ Convert.ToInt32(MinXBox.Text), ChartValuesTemp.ElementAt(i));
            }
        }

        private void RestorePositionBtn_Click(object sender, EventArgs e)
        {
            Series series = chart1.Series[0];
            series.Points.Clear();
            for (int i = 0; i < ChartValues.Count; i++)
            {             
                series.Points.AddXY(i, ChartValues.ElementAt(i));
            }
        }
    }
}
