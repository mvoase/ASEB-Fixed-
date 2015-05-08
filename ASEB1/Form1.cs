using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data;
using System.Drawing;


//////////////////////////////// This software allows the user to load HRM files to view Cycle Data from their monitor//////////////////////
namespace ASEB1
{
    public partial class CycleSoft : Form
    {
        

        public CycleSoft()
        {
            InitializeComponent();
        }

        //ERROR OPENS AND ASKS FOR FILE TWICE (NEEDS FIXING)
        private void radBrowseEditor1_ValueChanged(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = @"Open .HRM File";
                openFileDialog.InitialDirectory = @"C:\Users\mike\Desktop";
                openFileDialog.Filter = @"HRM files (*.hrm)|*.hrm|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                }

                using (StreamReader reader = new StreamReader(openFileDialog.FileName, System.Text.Encoding.Default))
                {
                    HRM.Active.Raw = reader.ReadToEnd();
                }
            }
          

            int lineIndex = HRM.Active.Raw.IndexOf("Date=");
            string lineDate = HRM.Active.Raw.Substring(lineIndex + 5, 8);// 8 characters = 20090412

            lineDate = lineDate.Insert(4, "-"); // add hyphen after yyyy
            lineDate = lineDate.Insert(7, "-"); // add hyphen after MM

            lineIndex = HRM.Active.Raw.IndexOf("StartTime=");
            string lineTime = HRM.Active.Raw.Substring(lineIndex + 10, 8); // 8 characters= hh:mm:ss
            

            lineIndex = HRM.Active.Raw.IndexOf("Interval="); //eg: StartTime=14:26:18.0
            string lineinter1 = HRM.Active.Raw.Substring(lineIndex + 9, 1); // 8 characters= hh:mm:ss
            

            lineIndex = HRM.Active.Raw.IndexOf("Length="); //eg: Length=14:26:18.0
            string lineLength = HRM.Active.Raw.Substring(lineIndex + 7, 8); // 8 characters= hh:mm:ss
            

            HRM.Active.DateTime = DateTime.ParseExact(lineDate + " " + lineTime, "yyyy-MM-dd HH:mm:ss", null);

            List<string> hrmRows = HRM.Active.Raw
                .Substring(HRM.Active.Raw.IndexOf("[HRData]\r\n", StringComparison.Ordinal) + 10)
                .Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            foreach (var line in hrmRows.TakeWhile(line => !string.IsNullOrWhiteSpace(line)))
            {
                
                //Splitting the data ready for each row. 
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
            richTextBox1.AppendText("\n" + "Pressure Maximum : " + HRM.Active.DataRows.Max(r => r.Pressure) + "\n");

            //Function Call 
            drawChart();
            //Function Call

            //New Code Added to show NP, IF and TSS in TextBox
            float NP = calcNP();

            richTextBox1.AppendText("\n" + "NP : "+ Math.Round(NP, 4)+ "\n");

            float IntFact = calcIFact();

            richTextBox1.AppendText("\n" + "IF : " + Math.Round(IntFact, 2) + "\n");

            double TSS = calcTSS();

            richTextBox1.AppendText("\n" + "TSS : " + Math.Round(TSS, 4) + "\n");

            //New Code Added to show NP, IF and TSS in TextBox

            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        /*Function Definition to Draw Chart */
        protected void drawChart()
        {

           
            DataTable dt = new DataTable();
            dt.Clear();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
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

            //Zoomable Function - Selectable Data. 
            ChartArea CA = chart1.ChartAreas[0];  
            CA.AxisX.ScaleView.Zoomable = true;
            CA.CursorX.AutoScroll = true;
            CA.CursorX.IsUserSelectionEnabled = true;

            
       }
        /*Function Definition to Draw Chart */
        //Checkboxes enabled in order to switch charts on and off
        private void radCheckBox1_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            Series sz = chart1.Series["Series1"];
            sz.Enabled = radCheckBox1.Checked;
         }

        private void radCheckBox2_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            Series sz = chart1.Series["Series2"];
            sz.Enabled = radCheckBox2.Checked;
        }

        private void radCheckBox3_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            Series sz = chart1.Series["Series3"];
            sz.Enabled = radCheckBox3.Checked;
        }

        private void radCheckBox4_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            Series sz = chart1.Series["Series4"];
            sz.Enabled = radCheckBox4.Checked;
        }

        private void radCheckBox5_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            Series sz = chart1.Series["Series5"];
            sz.Enabled = radCheckBox5.Checked;
        }

        private void radCheckBox6_ToggleStateChanged_1(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            Series sz = chart1.Series["Series6"];
            sz.Enabled = radCheckBox6.Checked;
        }




//Function to Calculate NP
      public float calcNP()
        {

            int rowcount = dataGridView1.Rows.Count;
           
            int[] colB=new int[rowcount];
            float[] NP = new float[rowcount];
            float avgNP = 0;
            for (int i = 0; i < rowcount; i++)
            {
                colB[i] =Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
              

            }

            float min = colB.Min();
            float max = colB.Max();
            float a = 1, b = 10;

            for (int i = 0; i < rowcount; i++)
            {
               NP[i]= (a + (colB[i] - min) * (b - a)) / (max - min) * 100;
               avgNP = NP[i] + avgNP;
           
              

            }

            avgNP = avgNP / rowcount;
            return  avgNP;
        }

            //Function to Calculate NP


            //Function to Calculate IF
      public float calcIFact()
      {
          
          float ftp = calcFTP();
          float NP = calcNP();
          float IntFact = NP / ftp;
         
          return IntFact;


      }
        //Function to Calculate IF

        //Function of Calculate FTP
      public float calcFTP()
      {

          float ftp = 0;

          if (chkFTP.Checked == true)
          {
              ftp =(float)Convert.ToDouble(txtFTP.Text)/100;
             
          }

          if (chkFTP.Checked == false)
          {
              int rowcount = dataGridView1.Rows.Count;
              
              int[] colB = new int[rowcount];


              for (int i = 0; i < rowcount; i++)
              {
                  colB[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                  

              }
              ftp = colB.Max() / 100;
              
          }

          return ftp;
         }
        //Function of Calculate FTP




        //Function to Calculate TSS
      public float calcTSS()
      {
          int duration = dataGridView1.Rows.Count;
          float NP = calcNP();
          float IntFact = calcIFact();
          float ftp = calcFTP();
          float TSS = (duration * NP * IntFact) / ((ftp * 3600) *100);
          return TSS;

      }

      //Function to Calculate TSS


      //Handling FTP Checkbox Check Uncheck Event
      private void chkFTP_CheckedChanged(object sender, EventArgs e)
      {
          if (chkFTP.Checked == true)
          {
              txtFTP.Enabled = true;
              btnFindTSS.Enabled = true;

          }

          if (chkFTP.Checked == false)
          {
              txtFTP.Enabled = false;
              btnFindTSS.Enabled = false;

          }
      }

      //Handing FTP Checkbox Check Unchek Event



     //Calculating TSS for TSS Tab with User Entered FTP Value
      private void btnFindTSS_Click(object sender, EventArgs e)
      {
          int duration = dataGridView1.Rows.Count;
          float NP = calcNP();
          float IntFact = calcIFact();
          float ftp = calcFTP();
          float TSS = (duration * NP * IntFact) / ((ftp * 3600) * 100);
          
          txtNP.Text = Convert.ToString(Math.Round(NP, 2));

          txtIF.Text = Convert.ToString(Math.Round(IntFact, 2));

          txtTSS.Text = Convert.ToString(Math.Round(TSS, 2));


      }

     

    

      

      
        //Calculating TSS for TSS Tab with User Entered FTP Value

       




        

       

      

      


    }

}




