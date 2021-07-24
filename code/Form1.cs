using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.CodeDom.Compiler;
using Excel = Microsoft.Office.Interop.Excel;

namespace DongGyu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void btn_open_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            txtBox_open.Text = openFileDialog.FileName;
        }

        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        private void btn_save_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtBox_save.Text = folderBrowserDialog.SelectedPath;
        }

        DataTable dt = new DataTable();
        private void btn_run_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Text = "시작";

                String data_str = File.ReadAllText(@txtBox_open.Text);
                Console.Write(data_str);
                JObject data_json = JObject.Parse(data_str);


                label4.Text = "Json 변환중";
                for (int k = 0; k < data_json["data"].Count(); k++)
                {
                    for (int i = 0; i < data_json["data"][k].Count(); i++)
                    {
                        string[] words = data_json["data"][k][i].ToString().Substring(1, data_json["data"][k][i].ToString().Length - 4).Split(',');
                        for (int j = 0; j < 7; j++)
                        {
                            words[j] = words[j].Substring(4);
                        }
                        add_row(words);
                    }
                }

                SaveToExcel();

                label4.Text = "실행 완료";
            }
            catch (Exception ex)
            {
                label4.Text = ex.Message;//"오류발생";
            }
        }
        private void add_row(string[] words)
        {
            DataRow row = dt.NewRow();
            row["A"] = Convert.ToDouble(words[0]);
            row["B"] = Convert.ToDouble(words[1]);
            row["C"] = Convert.ToDouble(words[2]);
            row["D"] = Convert.ToDouble(words[3]);
            row["E"] = Convert.ToDouble(words[4]);
            row["F"] = Convert.ToDouble(words[5]);
            row["G"] = Convert.ToDouble(words[6]);
            //row["H"] = Convert.ToDouble(words[7]);
            // row["I"] = Convert.ToDouble(words[8]);
            dt.Rows.Add(row);
        }

        private void SaveToExcel()
        {
            label4.Text = "저장중";

            string path = @txtBox_save.Text + "\\" + txtBox_filename.Text + ".xlsx";
            var excelApp = new Excel.Application();
            excelApp.Workbooks.Add();

            Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;

            for (var i = 0; i < dt.Rows.Count; i++)
            {
                for (var j = 0; j < dt.Columns.Count; j++)
                {
                    workSheet.Cells[i + 1, j + 1] = dt.Rows[i][j];
                }
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            workSheet.SaveAs(path);
            excelApp.Quit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add(new DataColumn("A", typeof(double)));
            dt.Columns.Add(new DataColumn("B", typeof(double)));
            dt.Columns.Add(new DataColumn("C", typeof(double)));
            dt.Columns.Add(new DataColumn("D", typeof(double)));
            dt.Columns.Add(new DataColumn("E", typeof(double)));
            dt.Columns.Add(new DataColumn("F", typeof(double)));
            dt.Columns.Add(new DataColumn("G", typeof(double)));
            //dt.Columns.Add(new DataColumn("H", typeof(double)));
            // dt.Columns.Add(new DataColumn("I", typeof(double)));
        }
    }
}
