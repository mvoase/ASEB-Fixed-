using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;

using System.Globalization;
// ReSharper disable ReturnValueOfPureMethodIsNotUsed


//////////////////////////////// This software allows the user to load HRM files to view Cycle Data from their monitor//////////////////////
namespace ASEB1
{
    public partial class CycleSoft : Form
    {
        

        public CycleSoft()
        {
            InitializeComponent();
        }

        
             private void openToolStripMenuItem1_Click(object sender, EventArgs e)
               {
                 using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = @"Open .HRM File";
                openFileDialog.InitialDirectory = @"C:\Users\mike\Desktop";
                openFileDialog.Filter = @"HRM files (*.hrm)|*.hrm|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                }

                using (var reader = new StreamReader(openFileDialog.FileName, System.Text.Encoding.Default))
                {
                    Hrm.Active.Raw = reader.ReadToEnd();
                }
            }
              

            var lineIndex = Hrm.Active.Raw.IndexOf("Date=", StringComparison.Ordinal);
            var lineDate = Hrm.Active.Raw.Substring(lineIndex + 5, 8);// 8 characters = 20090412

            lineDate = lineDate.Insert(4, "-"); // add hyphen after yyyy
            lineDate = lineDate.Insert(7, "-"); // add hyphen after MM

            lineIndex = Hrm.Active.Raw.IndexOf("StartTime=", StringComparison.Ordinal);
            var lineTime = Hrm.Active.Raw.Substring(lineIndex + 10, 8); // 8 characters= hh:mm:ss
            

            Hrm.Active.Raw.IndexOf("Interval=", StringComparison.Ordinal); //eg: StartTime=14:26:18.0


                 Hrm.Active.Raw.IndexOf("Length=", StringComparison.Ordinal); //eg: Length=14:26:18.0


                 Hrm.Active.DateTime = DateTime.ParseExact(lineDate + " " + lineTime, "yyyy-MM-dd HH:mm:ss", null);

            var hrmRows = Hrm.Active.Raw
                .Substring(Hrm.Active.Raw.IndexOf("[HRData]\r\n", StringComparison.Ordinal) + 10)
                .Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            foreach (var dataRow in hrmRows.TakeWhile(line => !string.IsNullOrWhiteSpace(line)).Select(line => new Data()
            {
                HeartRate = double.Parse(line.Split('\t')[0]),
                Speed = double.Parse(line.Split('\t')[1]),
                Cadence = double.Parse(line.Split('\t')[2]),
                Altitude = double.Parse(line.Split('\t')[3]),
                Power = double.Parse(line.Split('\t')[4]),
                Pressure = double.Parse(line.Split('\t')[4]),
                DateTime = Hrm.Active.DateTime.AddSeconds(Hrm.Active.DataRows.Count)
                    
            }))
            {
                Hrm.Active.DataRows.Add(dataRow);

               

                //Adding rows to DataGridView
                dataGridView1.Rows.Add(
                    dataRow.HeartRate,
                    dataRow.Speed,
                    dataRow.Cadence,
                    dataRow.Altitude,
                    dataRow.Pressure,
                    dataRow.Power,
                    dataRow.DateTime);
            }
            //To show the Data from file into the TextBox                                                          
            richTextBox1.AppendText("\n" + "Heart Average : " + Hrm.Active.DataRows.Average(r => r.HeartRate) + "\n");
            richTextBox1.AppendText("\n" + "Heart Minimum : " + Hrm.Active.DataRows.Min(r => r.HeartRate) + "\n");
            richTextBox1.AppendText("\n" + "Heart Maximum : " + Hrm.Active.DataRows.Max(r => r.HeartRate) + "\n");

            richTextBox1.AppendText("\n" + "Average Speed (KM/H): " + Hrm.Active.DataRows.Average(r => r.Speed) + "\n");
            richTextBox1.AppendText("\n" + "Maximum Speed : " + Hrm.Active.DataRows.Max(r => r.Speed) + "\n");
            richTextBox1.AppendText(Environment.NewLine + " - (MPH): " + "");

            richTextBox1.AppendText("\n" + "Average Power: " + Hrm.Active.DataRows.Average(r => r.Power) + "\n");
            richTextBox1.AppendText("\n" + "Maximum Power : " + Hrm.Active.DataRows.Max(r => r.Power) + "\n");

            richTextBox1.AppendText("\n" + "Average Altitude (KM/H): " + Hrm.Active.DataRows.Average(r => r.Altitude) + "\n");
            richTextBox1.AppendText("\n" + "Maximum Altitude : " + Hrm.Active.DataRows.Max(r => r.Altitude) + "\n");

            richTextBox1.AppendText("\n" + "Cadence Average : " + Hrm.Active.DataRows.Average(r => r.Cadence) + "\n");
            richTextBox1.AppendText("\n" + "Cadence Maximum : " + Hrm.Active.DataRows.Max(r => r.Cadence) + "\n");

            richTextBox1.AppendText("\n" + "Pressure Average : " + Hrm.Active.DataRows.Average(r => r.Pressure) + "\n");
            richTextBox1.AppendText("\n" + "Pressure Maximum : " + Hrm.Active.DataRows.Max(r => r.Pressure) + "\n");

            //Function Call 
            DrawChart();
            //Function Call

            //New Code Added to show NP, IF and TSS in TextBox
            var np = CalcNp();

            richTextBox1.AppendText("\n" + "NP : "+ Math.Round(np, 4)+ "\n");

            var intFact = CalcIFact();

            richTextBox1.AppendText("\n" + "IF : " + Math.Round(intFact, 2) + "\n");

            double tss = CalcTss();

            richTextBox1.AppendText("\n" + "TSS : " + Math.Round(tss, 4) + "\n");

            //New Code Added to show NP, IF and TSS in TextBox

            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        /*Function Definition to Draw Chart */
        protected void DrawChart()
        {

           
            var dt = new DataTable();
            dt.Clear();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            
            //Binds DataGridView to Chart to produce data 
            chart1.DataBind();

            chart1.DataSource = dt;
            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 90;
            chart1.Series["Series1"].Sort(PointSortOrder.Ascending, "X");
            chart1.Series["Series1"].XValueMember = "Date/Time";
           
            chart1.Series["Series1"].YValueMembers = "HeartRate";
           
            chart1.Series["Series2"].ChartType = SeriesChartType.Line;
            chart1.Series["Series2"].XValueMember = "Date/Time";
            chart1.Series["Series2"].YValueMembers = "Speed";

            chart1.Series["Series3"].ChartType = SeriesChartType.Line;
            chart1.Series["Series3"].XValueMember = "Date/Time";
            chart1.Series["Series3"].YValueMembers = "Cadence";

            chart1.Series["Series4"].ChartType = SeriesChartType.Line;
            chart1.Series["Series4"].XValueMember = "Date/Time";
            chart1.Series["Series4"].YValueMembers = "Altitude";

            chart1.Series["Series5"].ChartType = SeriesChartType.Line;
            chart1.Series["Series5"].XValueMember = "Date/Time";
            chart1.Series["Series5"].YValueMembers = "Pressure";

            chart1.Series["Series6"].ChartType = SeriesChartType.Line;
            chart1.Series["Series6"].XValueMember = "Date/Time";
            chart1.Series["Series6"].YValueMembers = "Power";

            chart1.Series["Series1"].LegendText = "Heart Rate";

            
            //Sets tooltips for selectable data. 
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

            

            //Chart2 
            chart2.DataBind();
            chart2.DataSource = dt;
            chart2.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chart2.ChartAreas[0].AxisX.LabelStyle.Angle = 90;

           chart2.Series["Series1"].XValueMember = "Date/Time";
            
            chart2.Series["Series1"].YValueMembers = "HeartRate";
           
            //chart2.Series["Series2"].ChartType = SeriesChartType.Pie;
            chart2.Series["Series2"].XValueMember = "Date/Time";
            chart2.Series["Series2"].YValueMembers = "Speed";

            //chart2.Series["Series3"].ChartType = SeriesChartType.Pie;
            chart2.Series["Series3"].XValueMember = "Date/Time";
            chart2.Series["Series3"].YValueMembers = "Cadence";

            //chart2.Series["Series4"].ChartType = SeriesChartType.Pie;
            chart2.Series["Series4"].XValueMember = "Date/Time";
            chart2.Series["Series4"].YValueMembers = "Altitude";

            //chart2.Series["Series5"].ChartType = SeriesChartType.Pie;
            chart2.Series["Series5"].XValueMember = "Date/Time";
            chart2.Series["Series5"].YValueMembers = "Pressure";

            //chart2.Series["Series6"].ChartType = SeriesChartType.Pie;
            chart2.Series["Series6"].XValueMember = "Date/Time";
            chart2.Series["Series6"].YValueMembers = "Power";

            chart2.Series["Series1"].LegendText = "Heart Rate";

            
            //Sets tooltips for selectable data. 
            chart2.Series["Series1"].ToolTip = "Heart Rate:#VALY\nAverage:#AVG\nMinimum:#MIN\nMaximum:#MAX ";

            chart2.Series["Series2"].LegendText = "Speed";
            chart2.Series["Series2"].ToolTip = "Speed(KM/H):#VALY\nAverage:#AVG\nMaximum:#MAX";

            chart2.Series["Series3"].LegendText = "Cadence";
            chart2.Series["Series3"].ToolTip = "Cadence:#VALY\nAverage:#AVG\nMaximum:#MAX";

            chart2.Series["Series4"].LegendText = "Altitude";
            chart2.Series["Series4"].ToolTip = "Altitude(KM/H):#VALY\nAverage:#AVG\nMaximum:#MAX";

            chart2.Series["Series5"].LegendText = "Pressure";
            chart2.Series["Series5"].ToolTip = "Pressure:#VALY\nAverage:#AVG\nMaximum:#MAX";

            chart2.Series["Series6"].LegendText = "Power";
            chart2.Series["Series6"].ToolTip = "Power:#VALY\nAverage:#AVG\nMaximum:#MAX";



            //Zoomable Function - Chart1  
            var ca = chart1.ChartAreas[0];  
            ca.AxisX.ScaleView.Zoomable = true;
            ca.CursorX.AutoScroll = true;
            ca.CursorX.IsUserSelectionEnabled = true;

            //Zoomable Function Chart 2
            var ca1 = chart2.ChartAreas[0];
            ca1.AxisX.ScaleView.Zoomable = true;
            ca1.CursorX.AutoScroll = true;
            ca1.CursorX.IsUserSelectionEnabled = true;
            
       }

        
        /*Function Definition to Draw Chart */
        //Checkboxes enabled in order to switch charts on and off
        private void radCheckBox1_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            var sz = chart1.Series["Series1"];
            sz.Enabled = radCheckBox1.Checked;
         }

        private void radCheckBox2_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            var sz = chart1.Series["Series2"];
            sz.Enabled = radCheckBox2.Checked;
        }

        private void radCheckBox3_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            var sz = chart1.Series["Series3"];
            sz.Enabled = radCheckBox3.Checked;
        }
      
        private void radCheckBox4_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            var sz = chart1.Series["Series4"];
            sz.Enabled = radCheckBox4.Checked;
        }
        private void radCheckBox5_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            var sz = chart1.Series["Series5"];
            sz.Enabled = radCheckBox5.Checked;
        }

        private void radCheckBox6_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            var sz = chart1.Series["Series6"];
            sz.Enabled = radCheckBox6.Checked;
        }



//Function to Calculate NP
        public float CalcNp()
        {

            var rowcount = dataGridView1.Rows.Count;

            var colB = new int[rowcount];
            var np = new float[rowcount];
            float avgNp = 0;
            for (var i = 0; i < rowcount; i++)
            {
                colB[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);


            }

            float min = colB.Min();
            float max = colB.Max();
            const float a = 1;
            const float b = 10;

            for (var i = 0; i < rowcount; i++)
            {
                np[i] = (a + (colB[i] - min) * (b - a)) / (max - min);
                avgNp = np[i] + avgNp;



            }

            avgNp = (avgNp / rowcount) * 100;
            return avgNp;
        }

            //Function to Calculate NP


            //Function to Calculate IF
        public float CalcIFact()
        {

            var ftp = CalcFtp();
            var np = CalcNp();
            var intFact = np / ftp;

            return intFact;


        }
        //Function to Calculate IF

        //Function of Calculate FTP
        public float CalcFtp()
        {

            float ftp = 0;

            if (chkFTP.Checked)
            {
                //  ftp =(float)Convert.ToDouble(txtFTP.Text)/100;
                ftp = (float)Convert.ToDouble(txtFTP.Text);

            }

            if (chkFTP.Checked) return ftp;
            var rowcount = dataGridView1.Rows.Count;

            var colB = new int[rowcount];


            for (var i = 0; i < rowcount; i++)
            {
                colB[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);


            }
            //  ftp = colB.Max() / 100;

            ftp = colB.Max();

            return ftp;
        }
        //Function of Calculate FTP




        //Function to Calculate TSS
        public float CalcTss()
        {
            var duration = dataGridView1.Rows.Count;
            var np = CalcNp();
            var intFact = CalcIFact();
            var ftp = CalcFtp();
            // float TSS = ((duration * NP * IntFact) / (ftp * 3600)) * 100;
            var tss = ((duration * np * intFact) / (ftp * 3600)) * 100;


            return tss;

        }

      //Function to Calculate TSS


      //Handling FTP Checkbox Check Uncheck Event
        private void chkFTP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFTP.Checked)
            {
                txtFTP.Enabled = true;
                btnFindTSS.Enabled = true;

            }

            if (chkFTP.Checked) return;
            txtFTP.Enabled = false;
            btnFindTSS.Enabled = false;
        }

      //Handing FTP Checkbox Check Unchek Event



     //Calculating TSS for TSS Tab with User Entered FTP Value
        private void btnFindTSS_Click(object sender, EventArgs e)
        {
            var duration = dataGridView1.Rows.Count;
            var np = CalcNp();
            var intFact = CalcIFact();
            var ftp = CalcFtp();
            //  float TSS = ((duration * NP * IntFact) / (ftp * 3600)) * 100;

            var tss = ((duration * np * intFact) / (ftp * 3600)) * 100;

            txtNP.Text = Convert.ToString(Math.Round(np, 2), CultureInfo.InvariantCulture);

            txtIF.Text = Convert.ToString(Math.Round(intFact, 2), CultureInfo.InvariantCulture);

            txtTSS.Text = Convert.ToString(Math.Round(tss,2), CultureInfo.InvariantCulture);


        }

      private void radCheckBox12_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
      {
          var sz = chart2.Series["Series1"];
          sz.Enabled = radCheckBox12.Checked;
      }

      private void radCheckBox11_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
      {
          var sz = chart2.Series["Series2"];
          sz.Enabled = radCheckBox11.Checked;
      }

      private void radCheckBox10_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
      {
          var sz = chart2.Series["Series3"];
          sz.Enabled = radCheckBox10.Checked;
      }

      private void radCheckBox9_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
      {
          var sz = chart2.Series["Series4"];
          sz.Enabled = radCheckBox9.Checked;
      }

      private void radCheckBox8_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
      {
          var sz = chart2.Series["Series5"];
          sz.Enabled = radCheckBox8.Checked;
      }

      private void radCheckBox7_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
      {
          var sz = chart2.Series["Series6"];
          sz.Enabled = radCheckBox7.Checked;
      }


        
       
      private void chart1_AxisViewChanged(object sender, ViewEventArgs e)
      {
          UpdateStats();
          
         
      }

        private int getVisiblePoint(Chart chart, Series series, bool first)
        {
            var s = series;
            var ca = chart.ChartAreas[s.ChartArea];
            DataPoint pt;
            if (first) pt = s.Points.Select(x => x)
                             .Where(x => x.XValue >= ca.AxisX.ScaleView.ViewMinimum)
                             .DefaultIfEmpty(s.Points.First()).First();
            else pt = s.Points.Select(x => x)
                             .Where(x => x.XValue <= ca.AxisX.ScaleView.ViewMaximum)
                             .DefaultIfEmpty(s.Points.Last()).Last();
            return s.Points.IndexOf(pt);
        }

        private void UpdateStats()
        {
            var firstPt = getVisiblePoint(chart1, chart1.Series[0], true);
            var lastPt = getVisiblePoint(chart1, chart1.Series[0], false);
            var sCount = chart1.Series.Count;
            var avg = new double[sCount];
            var min = new double[sCount];
            var max = new double[sCount];

            for (var i = 0; i < sCount; i++)
            {
                var s = chart1.Series[i];
                avg[i] = getAverage(s, firstPt, lastPt);
                min[i] = GetMixMax(s, firstPt, lastPt, true);
                max[i] = GetMixMax(s, firstPt, lastPt, false);
            }

            label7.Text = "" + getAverage(chart1.Series[0], firstPt, lastPt);
            label12.Text = "" + getAverage(chart1.Series[1], firstPt, lastPt);

        }

        private double getAverage(Series series, int first, int last)
        {
            double sum = 0;
            for (var i = first; i < last; i++) sum += series.Points[i].YValues[0];
            return sum/(last - first + 1);
        }

        static double GetMixMax(Series series, int first, int last, bool min)
        {
            double val = 0;

            for (var i = first; i < last; i++)
            {
                var v = series.Points[i].YValues[0];
                if ((min && val > v) || (!min && val >= v)) val = v;
            }
            return val;
        }


























    }


    }






