using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Linq;

// This program calculates pieces of data from the Polar Cycle HRM Files - Displaying averages and min + max
// including mph and km/h
namespace ASEB1
{
    public partial class Form2 : Form
    {
        
        

        public Form2()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = @"Open .HRM File";
                openFileDialog.InitialDirectory = @"c:\";
                openFileDialog.Filter = @"HRM files (*.hrm)|*.hrm|All files (*.*)|*.*"; // PJM, when using string literals use @ before
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

            renderGraph();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void renderGraph()
        {
            clearPoints();

            //draw points on chart from array based on selected checkboxes
            for (int x = 0; x < HRM.Active.DataRows.Count; x++)
            {
                charData.Series["Heart Rate"].Points.AddXY(x,   HRM.Active.DataRows.ElementAt(x).HeartRate);
                charData.Series["Speed"].Points.AddXY(x,        HRM.Active.DataRows.ElementAt(x).Speed);
                charData.Series["Cadence"].Points.AddXY(x,      HRM.Active.DataRows.ElementAt(x).Cadence);
                charData.Series["Altitude"].Points.AddXY(x,     HRM.Active.DataRows.ElementAt(x).Altitude);
                charData.Series["Power"].Points.AddXY(x,        HRM.Active.DataRows.ElementAt(x).Power);
            }
        }

        private void clearPoints()
        {
            //clear all points
            charData.Series["Heart Rate"].Points.Clear();
            charData.Series["Speed"].Points.Clear();
            charData.Series["Altitude"].Points.Clear();
            charData.Series["Power"].Points.Clear();
            charData.Series["Cadence"].Points.Clear();
            charData.Series["Averages"].Points.Clear();
            charData.Series["Maximums"].Points.Clear();
            charData.Series["Minimums"].Points.Clear();
        }

        private void chkHRate_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkHRate.Checked == false)
            {
                charData.Series["Heart Rate"].Points.Clear();
            }
            else
            {
                for (int x = 0; x < HRM.Active.DataRows.Count; x++)
                {
                    charData.Series["Heart Rate"].Points.AddXY(x, HRM.Active.DataRows.ElementAt(x).HeartRate);
                }
            }
        }


        private void chkSpeed_CheckedChanged_1(object sender, EventArgs e)
        {
            //if (chkSpeed.Checked == false)
            //{
            //    charData.Series["Speed"].Points.Clear();
            //}
            //else
            //{
            //    for (int a = 0; a < rowNum; a++)
            //    {
            //        int x = 0;
            //        charData.Series["Speed"].Points.AddXY(x, hrdata[1, a]);
            //        x++;
            //    }
            //}
        }

        
        private void chkCadence_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkCadence.Checked == false)
            //{
            //    charData.Series["Cadence"].Points.Clear();
            //}
            //else
            //{
            //    for (int a = 0; a < rowNum; a++)
            //    {
            //        int x = 0;
            //        charData.Series["Cadence"].Points.AddXY(x, hrdata[2, a]);
            //        x++;
            //    }
            //}
        }

        private void chkAlt_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAlt.Checked == false)
            //{
            //    charData.Series["Altitude"].Points.Clear();
            //}
            //else
            //{
            //    for (int a = 0; a < rowNum; a++)
            //    {
            //        int x = 0;
            //        charData.Series["Altitude"].Points.AddXY(x, hrdata[3, a]);
            //        x++;
            //    }
            //}
        }

        private void chkPower_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkPower.Checked == false)
            //{
            //    charData.Series["Power"].Points.Clear();
            //}
            //else
            //{
            //    for (int a = 0; a < rowNum; a++)
            //    {
            //        int x = 0;
            //        charData.Series["Power"].Points.AddXY(x, hrdata[4, a]);
            //        x++;
            //    }
            //}
        }

        private void chkAvg_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkAvg.Checked == false)
            //{
            //    charData.Series["avgHRate"].Points.Clear();
            //    charData.Series["avgSpeed"].Points.Clear();
            //    charData.Series["avgAlt"].Points.Clear();
            //    charData.Series["avgPower"].Points.Clear();
            //}
            //else
            //{
            //    if (chkHRate.Checked == true)
            //    {
            //        for (int a = 0; a < rowNum; a++)
            //        {
            //            int x = 0;
            //            charData.Series["avgHRate"].Points.AddXY(x, avgHRate);
            //        }
            //    }
            //    if (chkSpeed.Checked == true)
            //    {
            //        for (int a = 0; a < rowNum; a++)
            //        {
            //            int x = 0;
            //            charData.Series["avgSpeed"].Points.AddXY(x, avgSpeed);
            //        }
            //    }
            //    if (chkAlt.Checked == true)
            //    {
            //        for (int a = 0; a < rowNum; a++)
            //        {
            //            int x = 0;
            //            charData.Series["avgAlt"].Points.AddXY(x, avgAlt);
            //        }
            //    }
            //    if (chkPower.Checked == true)
            //    {
            //        for (int a = 0; a < rowNum; a++)
            //        {
            //            int x = 0;
            //            charData.Series["avgPower"].Points.AddXY(x, avgPower);
            //        }
            //    }
            //}
        }

        private void chkMax_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkMax.Checked == false)
            //{
            //    charData.Series["maxHRate"].Points.Clear();
            //    charData.Series["maxSpeed"].Points.Clear();
            //    charData.Series["avgAlt"].Points.Clear();
            //    charData.Series["avgPower"].Points.Clear();
            //}
            //else
            //{
            //    if (chkHRate.Checked == true)
            //    {
            //        for (int a = 0; a < rowNum; a++)
            //        {
            //            int x = 0;
            //            charData.Series["maxHRate"].Points.AddXY(x, maxHRate);
            //        }
            //    }
            //    if (chkSpeed.Checked == true)
            //    {
            //        for (int a = 0; a < rowNum; a++)
            //        {
            //            int x = 0;
            //            charData.Series["maxSpeed"].Points.AddXY(x, maxSpeed);
            //        }
            //    }
            //    if (chkAlt.Checked == true)
            //    {
            //        for (int a = 0; a < rowNum; a++)
            //        {
            //            int x = 0;
            //            charData.Series["maxAlt"].Points.AddXY(x, maxAlt);
            //        }
            //    }
            //    if (chkPower.Checked == true)
            //    {
            //        for (int a = 0; a < rowNum; a++)
            //        {
            //            int x = 0;
            //            charData.Series["maxPower"].Points.AddXY(x, maxPower);
            //        }
            //    }
            //}
        }

        private void chkMin_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkMin.Checked == false)
            //{
            //    charData.Series["minHRate"].Points.Clear();
            //}
            //else
            //{
            //    if (chkHRate.Checked == true)
            //    {
            //        for (int a = 0; a < rowNum; a++)
            //        {
            //            int x = 0;
            //            charData.Series["minHRate"].Points.AddXY(x, minHRate);
            //        }
            //    }
            //}
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

