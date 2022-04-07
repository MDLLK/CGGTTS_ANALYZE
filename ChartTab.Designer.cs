
namespace CGGTTS_ANALYZE
{
    partial class ChartTab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.filterAverageBtn = new System.Windows.Forms.Button();
            this.MinXBox = new System.Windows.Forms.TextBox();
            this.MaxXBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RestorePositionBtn = new System.Windows.Forms.Button();
            this.SetXRangeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(896, 393);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // filterAverageBtn
            // 
            this.filterAverageBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.filterAverageBtn.Location = new System.Drawing.Point(930, 12);
            this.filterAverageBtn.Name = "filterAverageBtn";
            this.filterAverageBtn.Size = new System.Drawing.Size(85, 30);
            this.filterAverageBtn.TabIndex = 1;
            this.filterAverageBtn.Text = "滤除平均";
            this.filterAverageBtn.UseVisualStyleBackColor = true;
            this.filterAverageBtn.Click += new System.EventHandler(this.filterAverageBtn_Click);
            // 
            // MinXBox
            // 
            this.MinXBox.Font = new System.Drawing.Font("宋体", 12F);
            this.MinXBox.Location = new System.Drawing.Point(995, 91);
            this.MinXBox.Name = "MinXBox";
            this.MinXBox.Size = new System.Drawing.Size(92, 26);
            this.MinXBox.TabIndex = 2;
            // 
            // MaxXBox
            // 
            this.MaxXBox.Font = new System.Drawing.Font("宋体", 12F);
            this.MaxXBox.Location = new System.Drawing.Point(995, 127);
            this.MaxXBox.Name = "MaxXBox";
            this.MaxXBox.Size = new System.Drawing.Size(92, 26);
            this.MaxXBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(919, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "重设位置:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(927, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "最小值:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(927, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "最大值:";
            // 
            // RestorePositionBtn
            // 
            this.RestorePositionBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.RestorePositionBtn.Location = new System.Drawing.Point(928, 167);
            this.RestorePositionBtn.Name = "RestorePositionBtn";
            this.RestorePositionBtn.Size = new System.Drawing.Size(75, 30);
            this.RestorePositionBtn.TabIndex = 7;
            this.RestorePositionBtn.Text = "恢复";
            this.RestorePositionBtn.UseVisualStyleBackColor = true;
            this.RestorePositionBtn.Click += new System.EventHandler(this.RestorePositionBtn_Click);
            // 
            // SetXRangeBtn
            // 
            this.SetXRangeBtn.Font = new System.Drawing.Font("宋体", 12F);
            this.SetXRangeBtn.Location = new System.Drawing.Point(1012, 167);
            this.SetXRangeBtn.Name = "SetXRangeBtn";
            this.SetXRangeBtn.Size = new System.Drawing.Size(75, 30);
            this.SetXRangeBtn.TabIndex = 8;
            this.SetXRangeBtn.Text = "设置";
            this.SetXRangeBtn.UseVisualStyleBackColor = true;
            this.SetXRangeBtn.Click += new System.EventHandler(this.SetXRangeBtn_Click);
            // 
            // ChartTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 423);
            this.Controls.Add(this.SetXRangeBtn);
            this.Controls.Add(this.RestorePositionBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxXBox);
            this.Controls.Add(this.MinXBox);
            this.Controls.Add(this.filterAverageBtn);
            this.Controls.Add(this.chart1);
            this.Name = "ChartTab";
            this.Text = "ChartTab";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button filterAverageBtn;
        private System.Windows.Forms.TextBox MinXBox;
        private System.Windows.Forms.TextBox MaxXBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RestorePositionBtn;
        private System.Windows.Forms.Button SetXRangeBtn;
    }
}