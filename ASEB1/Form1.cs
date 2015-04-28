using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

               dataGridView1.Rows.Add(
                    dataRow.HeartRate,
                    dataRow.Speed,
                    dataRow.Cadence,
                    dataRow.Altitude,
                    dataRow.Pressure,
                    dataRow.Power,
                    dataRow.DateTime);

               
            }


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

        
       

       



        

       

      

      


    }

}




