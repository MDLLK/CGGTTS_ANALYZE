
namespace CGGTTS_ANALYZE
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FileReadPathBox1 = new System.Windows.Forms.TextBox();
            this.FileReadPathBox2 = new System.Windows.Forms.TextBox();
            this.FileReadBtn1 = new System.Windows.Forms.Button();
            this.FileReadBtn2 = new System.Windows.Forms.Button();
            this.FilePathLab1 = new System.Windows.Forms.Label();
            this.FilePathLab2 = new System.Windows.Forms.Label();
            this.WriteLogBtn = new System.Windows.Forms.Button();
            this.DataToFileBtn1 = new System.Windows.Forms.Button();
            this.DataToFileBtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileReadPathBox1
            // 
            this.FileReadPathBox1.Font = new System.Drawing.Font("宋体", 16F);
            this.FileReadPathBox1.Location = new System.Drawing.Point(29, 53);
            this.FileReadPathBox1.Name = "FileReadPathBox1";
            this.FileReadPathBox1.Size = new System.Drawing.Size(615, 32);
            this.FileReadPathBox1.TabIndex = 0;
            // 
            // FileReadPathBox2
            // 
            this.FileReadPathBox2.Font = new System.Drawing.Font("宋体", 16F);
            this.FileReadPathBox2.Location = new System.Drawing.Point(29, 127);
            this.FileReadPathBox2.Name = "FileReadPathBox2";
            this.FileReadPathBox2.Size = new System.Drawing.Size(615, 32);
            this.FileReadPathBox2.TabIndex = 1;
            // 
            // FileReadBtn1
            // 
            this.FileReadBtn1.Font = new System.Drawing.Font("宋体", 14F);
            this.FileReadBtn1.Location = new System.Drawing.Point(667, 53);
            this.FileReadBtn1.Name = "FileReadBtn1";
            this.FileReadBtn1.Size = new System.Drawing.Size(75, 32);
            this.FileReadBtn1.TabIndex = 2;
            this.FileReadBtn1.Text = "获取";
            this.FileReadBtn1.UseVisualStyleBackColor = true;
            this.FileReadBtn1.Click += new System.EventHandler(this.FileReadBtn1_Click);
            // 
            // FileReadBtn2
            // 
            this.FileReadBtn2.Font = new System.Drawing.Font("宋体", 14F);
            this.FileReadBtn2.Location = new System.Drawing.Point(667, 127);
            this.FileReadBtn2.Name = "FileReadBtn2";
            this.FileReadBtn2.Size = new System.Drawing.Size(75, 32);
            this.FileReadBtn2.TabIndex = 3;
            this.FileReadBtn2.Text = "获取";
            this.FileReadBtn2.UseVisualStyleBackColor = true;
            this.FileReadBtn2.Click += new System.EventHandler(this.FileReadBtn2_Click);
            // 
            // FilePathLab1
            // 
            this.FilePathLab1.AutoSize = true;
            this.FilePathLab1.Font = new System.Drawing.Font("黑体", 14F);
            this.FilePathLab1.Location = new System.Drawing.Point(25, 21);
            this.FilePathLab1.Name = "FilePathLab1";
            this.FilePathLab1.Size = new System.Drawing.Size(149, 19);
            this.FilePathLab1.TabIndex = 4;
            this.FilePathLab1.Text = "标准文件路径：";
            // 
            // FilePathLab2
            // 
            this.FilePathLab2.AutoSize = true;
            this.FilePathLab2.Font = new System.Drawing.Font("黑体", 14F);
            this.FilePathLab2.Location = new System.Drawing.Point(25, 96);
            this.FilePathLab2.Name = "FilePathLab2";
            this.FilePathLab2.Size = new System.Drawing.Size(149, 19);
            this.FilePathLab2.TabIndex = 5;
            this.FilePathLab2.Text = "自研文件路径：";
            // 
            // WriteLogBtn
            // 
            this.WriteLogBtn.Font = new System.Drawing.Font("宋体", 14F);
            this.WriteLogBtn.Location = new System.Drawing.Point(667, 192);
            this.WriteLogBtn.Name = "WriteLogBtn";
            this.WriteLogBtn.Size = new System.Drawing.Size(185, 32);
            this.WriteLogBtn.TabIndex = 6;
            this.WriteLogBtn.Text = "生成比对结果";
            this.WriteLogBtn.UseVisualStyleBackColor = true;
            this.WriteLogBtn.Click += new System.EventHandler(this.WriteLogBtn_Click);
            // 
            // DataToFileBtn1
            // 
            this.DataToFileBtn1.Font = new System.Drawing.Font("宋体", 14F);
            this.DataToFileBtn1.Location = new System.Drawing.Point(748, 53);
            this.DataToFileBtn1.Name = "DataToFileBtn1";
            this.DataToFileBtn1.Size = new System.Drawing.Size(104, 32);
            this.DataToFileBtn1.TabIndex = 7;
            this.DataToFileBtn1.Text = "生成文件";
            this.DataToFileBtn1.UseVisualStyleBackColor = true;
            this.DataToFileBtn1.Click += new System.EventHandler(this.DataToFileBtn1_Click);
            // 
            // DataToFileBtn2
            // 
            this.DataToFileBtn2.Font = new System.Drawing.Font("宋体", 14F);
            this.DataToFileBtn2.Location = new System.Drawing.Point(748, 127);
            this.DataToFileBtn2.Name = "DataToFileBtn2";
            this.DataToFileBtn2.Size = new System.Drawing.Size(104, 32);
            this.DataToFileBtn2.TabIndex = 8;
            this.DataToFileBtn2.Text = "生成文件";
            this.DataToFileBtn2.UseVisualStyleBackColor = true;
            this.DataToFileBtn2.Click += new System.EventHandler(this.DataToFileBtn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 236);
            this.Controls.Add(this.DataToFileBtn2);
            this.Controls.Add(this.DataToFileBtn1);
            this.Controls.Add(this.WriteLogBtn);
            this.Controls.Add(this.FilePathLab2);
            this.Controls.Add(this.FilePathLab1);
            this.Controls.Add(this.FileReadBtn2);
            this.Controls.Add(this.FileReadBtn1);
            this.Controls.Add(this.FileReadPathBox2);
            this.Controls.Add(this.FileReadPathBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileReadPathBox1;
        private System.Windows.Forms.TextBox FileReadPathBox2;
        private System.Windows.Forms.Button FileReadBtn1;
        private System.Windows.Forms.Button FileReadBtn2;
        private System.Windows.Forms.Label FilePathLab1;
        private System.Windows.Forms.Label FilePathLab2;
        private System.Windows.Forms.Button WriteLogBtn;
        private System.Windows.Forms.Button DataToFileBtn1;
        private System.Windows.Forms.Button DataToFileBtn2;
    }
}

