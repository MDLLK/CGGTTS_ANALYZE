using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CGGTTS_ANALYZE
{
    public partial class Form1 : Form
    {
        List<File_Para> Global_T = new List<File_Para>();

        string[] filePath1;
        string[] filePath2;

        public Form1()
        {
            filePath1 = new string[10];
            filePath2 = new string[10];

            
            InitializeComponent();
        }


        string title_str1 = "标准接收机:                  自研接收机:\n";
        string title_str2 = "SV_NUM STTIME     REFSYS_1   STTIME     REFSYS_2     REFSYS_1-REFSYS_2";
        public void wirteFileLog(string filePath, string _file_name, string str)
        {
            filePath = filePath + "\\LOG\\";
            if (!System.IO.Directory.Exists(filePath))//如果不存在就创建file文件夹
            {
                System.IO.Directory.CreateDirectory(filePath);
            }
            string file_name = filePath + "\\" + _file_name;
            if (!System.IO.File.Exists(file_name))//如果不存在就创建file文件
            {
                StreamWriter sw = new StreamWriter(file_name, true);
                if (sw != null)
                {
                    sw.WriteLine(title_str1 + title_str2);
                    sw.WriteLine(str);
                    sw.Flush();
                    sw.Close();
                }
            }
            else
            {
                StreamWriter sw = new StreamWriter(file_name, true);
                if (sw != null)
                {
                    sw.WriteLine(str);
                    sw.Flush();
                    sw.Close();
                }
            }
        }

        private void FileReadBtn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Multiselect = true;
            //FileDialog.Multiselect = false;
            FileDialog.Title = "请选择需要导入的文件";

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                //如果选择文件，执行操作。
                filePath1 = FileDialog.FileNames;
                //FileReadPathBox1.Text = filePath1;
                string temp = "";
                for (int i = 0;i<filePath1.Length;i++) 
                {
                    temp += filePath1[i] + ",";
                }
                FileReadPathBox1.Text = temp;
            }
        }

        private void FileReadBtn2_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Multiselect = true;
            //FileDialog.Multiselect = false;
            FileDialog.Title = "请选择需要导入的文件";

            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                //如果选择文件，执行操作。
                filePath2 = FileDialog.FileNames;
                //FileReadPathBox1.Text = filePath2;
                string temp = "";
                for (int i = 0; i < filePath2.Length; i++)
                {
                    temp += filePath2[i] + ",";
                }
                FileReadPathBox2.Text = temp;
            }
        }

        private void WriteLogBtn_Click(object sender, EventArgs e)
        {
            filePath1 = FileReadPathBox1.Text.Split(',');
            filePath2 = FileReadPathBox2.Text.Split(',');
            float[] values = new float[65536];
            int value_num = 0;
            File_Para filePara1 = new File_Para();
            File_Para filePara2 = new File_Para();
            Global_T.Add(filePara1);
            Global_T.Add(filePara2);

            foreach (string name in filePath1) 
            {
                if (File.Exists(name))
                {
                    string str1 = File.ReadAllText(name);
                    file_data_read(str1, 0);
                }
            }

            foreach (string name in filePath2)
            {
                if (File.Exists(name))
                {
                    string str1 = File.ReadAllText(name);
                    file_data_read(str1, 1);
                }
            }

            if (Global_T.Count == 2)
            {
                File_Para msg1 = Global_T.ElementAt(0);
                File_Para msg2 = Global_T.ElementAt(1);

                while (msg1.FileIO.Count > 0 && msg2.FileIO.Count > 0)
                {
                    int sttime1 = Convert.ToInt32(msg1.FileIO.ElementAt(0).sttime);
                    int sttime2 = Convert.ToInt32(msg2.FileIO.ElementAt(0).sttime);
                    if (sttime1 == sttime2)
                    {
                        break;
                    }
                    else
                    {
                        if (sttime1 > sttime2)
                        {
                            msg2.FileIO.RemoveAt(0);
                        }
                        if (sttime1 < sttime2)
                        {
                            msg1.FileIO.RemoveAt(0);
                        }
                    }
                }
                double Average1 = 0;
                int num1 = 0;
                double Average2 = 0;
                int num2 = 0;
                int sum_common_star = 0;
                foreach (cggtts_para msg_t1 in msg1.FileIO)
                {
                    foreach (cggtts_para msg_t2 in msg2.FileIO)
                    {
                        if (msg_t1.sttime == msg_t2.sttime && msg_t1.mjd == msg_t2.mjd)
                        {
                            if (msg_t1.sttime == "085000")
                            {
                                Thread.Sleep(10);
                            }
                            foreach (sv_para sv_1 in msg_t1.GlobalSv)
                            {
                                foreach (sv_para sv_2 in msg_t2.GlobalSv)
                                {
                                    if (sv_1.sv == sv_2.sv)
                                    {
                                        Average1 += sv_1.refsys;
                                        num1++;
                                        Average2 += sv_2.refsys;
                                        num2++;
                                        sum_common_star++;
                                    }
                                }
                            }

                            if (sum_common_star != 0)
                            {

                                string file1_str = String.Format("{0,-4}", sum_common_star) + String.Format(" {0,8}", msg_t1.sttime) + String.Format(" {0,12}", (Average1 / num1).ToString("0.00"));
                                string file2_str = String.Format(" {0,8}", msg_t2.sttime) + String.Format(" {0,12}", (Average2 / num2).ToString("0.00"));
                                string result_str = String.Format("{0,12}", (((Average1 / num1) - (Average2 / num2)).ToString("0.00")));

                                values[value_num] = (float)((Average1 / num1) - (Average2 / num2));
                                value_num++;

                                wirteFileLog(Directory.GetCurrentDirectory(), DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + "_File", file1_str + file2_str + result_str);
                                //wirteFileLog(Directory.GetCurrentDirectory(), msg_t2.mjd + "_File2", msg_t2.sttime + "\t" + (Average2 / num2).ToString("0.00"));
                                Average1 = 0;
                                num1 = 0;
                                Average2 = 0;
                                num2 = 0;
                                sum_common_star = 0;
                            }
                        }
                    }
                }
            }

            if (value_num != 0)
            {
                float[] datas = new float[value_num];
                for (int i = 0; i < value_num; i++)
                    datas[i] = values[i];

                openChartTab(datas, value_num);
            }

            Global_T.Clear();

            System.Diagnostics.Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\LOG");
        }

        public int file_data_read(string str,int index)
        {
            if (false == str.Contains("CGGTTS"))
            {
                MessageBox.Show("格式错误");
                return -1;
            }
            if (false == (str.Contains("SAT") && str.Contains("CL") && str.Contains("MJD")))
            {
                MessageBox.Show("格式错误");
                return -1;
            }
            if (false == str.Contains("CKSUM"))
            {
                MessageBox.Show("格式错误");
                return -1;
            }

            string[] lines = str.Split('\r', '\n');
            int pack_head_over_flag = 1;
            int data_line_cnt = 0;

            //File_Para PARA = new File_Para();
            string sttime = "";
            string laststtime = "000000";

            cggtts_para para = null;
            int i = 0;
            foreach (string line in lines) //每行
            {
                string line_str = "";
                if (pack_head_over_flag == 1)
                {
                    if (line.Contains("SAT") && line.Contains("CL") && line.Contains("MJD"))
                    {
                        data_line_cnt = -2;
                    }
                    if (line.Length > 10)
                    {
                        if (data_line_cnt >= 0)
                        {
                            int flag = 0;
                            while (i < line.Length)
                            {

                                if (line.ElementAt(i) == 0x20)
                                {
                                    line_str = line.Remove(0, i + 1);
                                    flag = 1;
                                    i++;
                                }
                                else
                                {
                                    i = 0;
                                    if (flag == 0)
                                    {
                                        line_str = line;
                                    }
                                    break;
                                }
                            }
                            string[] datas = line_str.Replace("\t", " ").Replace("       ", " ").Replace("      ", " ").Replace("     ", " ").Replace("    ", " ")
                                             .Replace("   ", " ").Replace("  ", " ").Split(' ', '\t', '\r', '\n');

                            if (datas.Length == 24)
                            {
                                try
                                {
                                    int sv_id = Convert.ToInt16(datas[0].Replace("G", "").Replace("C", " "));
                                    string mjd = datas[2].PadLeft(5, '0');
                                    sttime = datas[3].PadLeft(6, '0'); ;
                                    if (datas[9].Contains("*")) { continue; }
                                    int refsys = Convert.ToInt32(datas[9]);

                                    if (sttime == "233800")
                                    {
                                        Thread.Sleep(10);
                                    }

                                    if (sttime != laststtime)
                                    {
                                        if (para != null)
                                        {
                                            //PARA.FileIO.Add(para);
                                            Global_T.ElementAt(index).FileIO.Add(para);
                                            para = null;
                                            para = new cggtts_para(sttime, mjd);
                                        }
                                        else
                                        {
                                            para = new cggtts_para(sttime, mjd);
                                        }
                                        laststtime = sttime;
                                    }

                                    if (para != null)
                                    {
                                        sv_para sv_msg = new sv_para();
                                        sv_msg.sv = sv_id;
                                        sv_msg.refsys = refsys;
                                        para.GlobalSv.Add(sv_msg);
                                    }

                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                    return -1;
                                }
                            }
                            else
                            {

                            }
                        }
                        data_line_cnt++;
                    }
                }
            }

            //PARA.FileIO.Add(para);
            Global_T.ElementAt(index).FileIO.Add(para);
            //Global_T.Add(PARA);
            return 0;
        }
       

        private void DataToFileBtn1_Click(object sender, EventArgs e)
        {

        }

        private void DataToFileBtn2_Click(object sender, EventArgs e)
        {

        } 
        
        public void openChartTab(float[] values,int num)
        {
            try
            {
                ChartTab tab = new ChartTab(values, num);
                tab.Set_X_max_min(num, 0);
                tab.Set_Y_max_min((double)(values.Max()), (double)(values.Min()));
                tab.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }



    public class File_Para
    {
        public List<cggtts_para> FileIO ;
        public File_Para()
        {
            FileIO = new List<cggtts_para>();
        }
    }

    public class cggtts_para
    {
        public string sttime;
        public string mjd;
        public List<sv_para> GlobalSv;
        public cggtts_para(string _sttime, string _mjd)
        {
            sttime = _sttime;
            mjd = _mjd;
            GlobalSv = new List<sv_para>();
        }
    }

    public class sv_para
    {
        public int sv;
        public int az;
        public int ez;
        public int refsys;
        public int mdio;
        public sv_para()
        {
            sv = 0;
            refsys = 0;
        }
    }

}
