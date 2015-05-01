using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;

namespace ASEB1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void radBrowseEditor1_ValueChanged(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = @"Open .HRM File";
                openFileDialog.InitialDirectory = @"C:\Users\mike\Desktop";
                openFileDialog.Filter = @"HRM files (*.hrm)|*.hrm|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                }

                using (StreamReader reader = new StreamReader(openFileDialog.FileName, System.Text.Encoding.Default))
                {
                    HRM.Active.Raw = reader.ReadToEnd();
                }
            }
          /* Code For Chart*/
            DataTable dt = new DataTable();
            dt.Clear();
            
            
            dt.Columns.Add("HeartRate");
            dt.Columns.Add("Speed");
            dt.Columns.Add("Cadence");
            dt.Columns.Add("Altitude");
            dt.Columns.Add("Pressure");
            dt.Columns.Add("Power");
            dt.Columns.Add("DateTime");

            /* Code For Chart*/

            int lineIndex = HRM.Active.Raw.IndexOf("Date=");
            string lineDate = HRM.Active.Raw.Substring(lineIndex + 5, 8);// 8 characters = 20090412

            lineDate = lineDate.Insert(4, "-"); // add hyphen after yyyy
            lineDate = lineDate.Insert(7, "-"); // add hyphen after MM

            lineIndex = HRM.Active.Raw.IndexOf("StartTime=");
            string lineTime = HRM.Active.Raw.Substring(lineIndex + 10, 8); // 8 characters= hh:mm:ss
            //richTextBox1.AppendText(Environment.NewLine + " Time started: " + lineTime);

            lineIndex = HRM.Active.Raw.IndexOf("Interval="); //eg: StartTime=14:26:18.0
            string lineinter1 = HRM.Active.Raw.Substring(lineIndex + 9, 1); // 8 characters= hh:mm:ss
            //richTextBox1.AppendText(Environment.NewLine + " New entery every " + lineinter1 + " Second(s)");

            lineIndex = HRM.Active.Raw.IndexOf("Length="); //eg: Length=14:26:18.0
            string lineLength = HRM.Active.Raw.Substring(lineIndex + 7, 8); // 8 characters= hh:mm:ss
            //richTextBox1.AppendText(Environment.NewLine + " Length of workout: " + lineLength);

            //richTextBox1.AppendText(Environment.NewLine);

            HRM.Active.DateTime = DateTime.ParseExact(lineDate + " " + lineTime, "yyyy-MM-dd HH:mm:ss", null);

            List<string> hrmRows = HRM.Active.Raw
                .Substring(HRM.Active.Raw.IndexOf("[HRData]\r\n", StringComparison.Ordinal) + 10)
                .Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            foreach (var line in hrmRows.TakeWhile(line => !string.IsNullOrWhiteSpace(line)))
            {
                
                
                Data dataRow = new Data()
                {
                    HeartRate = double.Parse(line.Split('\t')[0]),
                    Speed = double.Parse(line.Split('\t')[1]),
                    Cadence = double.Parse(line.Split('\t')[2]),
                    Altitude = double.Parse(line.Split('\t')[3]),
                    Power = double.Parse(line.Split('\t')[4]),
                    Pressure = double.Parse(line.Split('\t')[4]),
                    DateTime = HRM.Active.DateTime.AddSeconds(HRM.Active.DataRows.Count)
                    
                };

               HRM.Active.DataRows.Add(dataRow);
              
                /* Code For Chart*/
               dt.Rows.Add(dataRow.HeartRate,dataRow.Speed,dataRow.Cadence,dataRow.Altitude,dataRow.Pressure,dataRow.Power,dataRow.DateTime);
               /* Code For Chart*/
              
               
               dataGridView1.Rows.Add(
                    dataRow.HeartRate,
                    dataRow.Speed,
                    dataRow.Cadence,
                    dataRow.Altitude,
                    dataRow.Pressure,
                    dataRow.Power,
                    dataRow.DateTime);
                              
            }


            /* Code For Chart*/
            chart1.DataSource = dt;
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            chart1.Series["Series1"].XValueMember = "DateTime";
            chart1.Series["Series1"].YValueMembers = "HeartRate";

            chart1.Series["Series2"].ChartType = SeriesChartType.Line;
            chart1.Series["Series2"].YValueMembers = "Speed";
            
            chart1.Series["Series3"].ChartType = SeriesChartType.Line;
            chart1.Series["Series3"].YValueMembers = "Cadence";
            
            chart1.Series["Series4"].ChartType = SeriesChartType.Line;
            chart1.Series["Series4"].YValueMembers = "Altitude";
            
            chart1.Series["Series5"].ChartType = SeriesChartType.Line;
            chart1.Series["Series5"].YValueMembers = "Pressure";
            
            chart1.Series["Series6"].ChartType = SeriesChartType.Line;
            chart1.Series["Series6"].YValueMembers = "Power";

            

            chart1.Series["Series1"].LegendText = "Heart Rate";

            chart1.Series["Series1"].ToolTip = "Heart Rate:#VALY\nAverage:#AVG\nMinimum:#MIN\nMaximum:#MAX ";

            chart1.Series["Series2"].LegendText = "Speed";
            chart1.Series["Series2"].ToolTip = "Speed(KM/H):#VALY\nAverage:#AVG\nMaximum:#MAX";

            chart1.Series["Series3"].LegendText = "Cadence";
            chart1.Series["Series3"].ToolTip = "Cadence:#VALY\nAverage:#AVG\nMaximum:#MAX";

            chart1.Series["Series4"].LegendText = "Altitude";
            chart1.Series["Series4"].ToolTip = "Altitude(KM/H):#VALY\nAverage:#AVG\nMaximum:#MAX";

            chart1.Series["Series5"].LegendText = "Pressure";
            chart1.Series["Series5"].ToolTip = "Pressure:#VALY\nAverage:#AVG\nMaximum:#MAX";

            chart1.Series["Series6"].LegendText = "Power";
            chart1.Series["Series6"].ToolTip = "Power:#VALY\nAverage:#AVG\nMaximum:#MAX";



            
            chart1.DataBind();

            

            /* Code For Chart*/

            richTextBox1.AppendText("\n" + "Heart Average : " + HRM.Active.DataRows.Average(r => r.HeartRate) + "\n");
            richTextBox1.AppendText("\n" + "Heart Minimum : " + HRM.Active.DataRows.Min(r => r.HeartRate) + "\n");
            richTextBox1.AppendText("\n" + "Heart Maximum : " + HRM.Active.DataRows.Max(r => r.HeartRate) + "\n");

            richTextBox1.AppendText("\n" + "Average Speed (KM/H): " + HRM.Active.DataRows.Average(r => r.Speed) + "\n");
            richTextBox1.AppendText("\n" + "Maximum Speed : " + HRM.Active.DataRows.Max(r => r.Speed) + "\n");
            richTextBox1.AppendText(Environment.NewLine + " - (MPH): " + "");

            richTextBox1.AppendText("\n" + "Average Power: " + HRM.Active.DataRows.Average(r => r.Power) + "\n");
            richTextBox1.AppendText("\n" + "Maximum Power : " + HRM.Active.DataRows.Max(r => r.Power) + "\n");

            richTextBox1.AppendText("\n" + "Average Altitude (KM/H): " + HRM.Active.DataRows.Average(r => r.Altitude) + "\n");
            richTextBox1.AppendText("\n" + "Maximum Altitude : " + HRM.Active.DataRows.Max(r => r.Altitude) + "\n");

            richTextBox1.AppendText("\n" + "Cadence Average : " + HRM.Active.DataRows.Average(r => r.Cadence) + "\n");
            richTextBox1.AppendText("\n" + "Cadence Maximum : " + HRM.Active.DataRows.Max(r => r.Cadence) + "\n");

            richTextBox1.AppendText("\n" + "Pressure Average : " + HRM.Active.DataRows.Average(r => r.Pressure) + "\n");
            richTextBox1.AppendText("\n" + "Pressue Maximum : " + HRM.Active.DataRows.Max(r => r.Pressure) + "\n");
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        

        
        
       

      



        

       

      

      


    }

}




