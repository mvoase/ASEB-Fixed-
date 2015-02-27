using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

// This program calculates pieces of data from the Polar Cycle HRM Files - Displaying averages and min + max
// including mph and km/h

namespace ASEB1
{
    public partial class Form1 : Form
    {
        int i, j, rowNum;
        int[,] hrdata = new int[6, 10000];
        private int seconds;
        private int counter;
        string[,] prms = new string [2, 22] ;
        string file_name;
        double speed = 0, avgSpeed = 0;
        double Alt = 0, avgAlt = 0;
        double HRate = 0, avgHRate = 0;
        double Power = 0, avgPower = 0;
        double maxSpeed = 0, cSpeed;
        double maxHRate = 0, cHRateMax;
        double minHRate = 180, cHRateMin;
        double maxPower = 0, cPower;
        double maxAlt = -250, cAlt;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

           
            
            //load the hr file
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text Document (*.hrm)|*.hrm|All Files (*.*)|*.*";
            DialogResult dialogres = op.ShowDialog();
            file_name = op.FileName.ToString();
            if (file_name != "")
            {
                readFile();
            }
        }

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
        private void readFile()
        {
                 
            //read the hr file and split values
            try
            {
                using (StreamReader sr = new StreamReader(file_name))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("[HRData]"))
                        {
                            break;
                        }
                    }


                    while ((line = sr.ReadLine()) != null)
                    {
                        string split = line;
                        string[] values = split.Split('\t');
                        foreach (String value in values)
                        {
                            hrdata[i, j] = int.Parse(value);
                            i++;
                            if (i > 5)
                            {
                                
                                
                                
                                i = 0;
                                j++;
                            }
                        }

                       
                    }

                  

                    

                    //seconds = Convert.ToInt32(lineinter1);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            avgSpeedpro();
            maxSpeedpro();
            avgHRatepro();
            maxHRatepro();
            minHRatepro();
            avgPowerpro();
            maxPowerpro();
            avgAltpro();
            maxAltpro();
            totalDist();
            renderGraph();
        }

        private void avgSpeedpro()
        {
            //calculate the average speed
            rowNum = j;
            j = 0;
            speed = 0;
            string msg;
            for (i = 0; i < rowNum; i++)
            {
                speed = speed + hrdata[1, j];
                j++;
            }
            if (rdMph.Checked == true)
            {
                avgSpeed = (speed / 16) / rowNum;
                msg = " Mph";
            }
            else
            {
                avgSpeed = (speed / 10) / rowNum;
                msg = " Km/h";
            }
            aspeed.Text = avgSpeed.ToString("N2") + msg;
        }

        private void avgHRatepro()
        {
            //calculate the average heart rate
            rowNum = j;
            j = 0;
            for (i = 0; i < rowNum; i++)
            {
                HRate = HRate + hrdata[0, j];
                j++;
            }
            avgHRate = HRate / rowNum;
            ahrate.Text = avgHRate.ToString("N2") + " Bpm";
        }

        private void avgPowerpro()
        {
            //calculate the average power
            rowNum = j;
            j = 0;
            for (i = 0; i < rowNum; i++)
            {
                Power = Power + hrdata[4, j];
                j++;
            }
            avgPower = Power / rowNum;
            apower.Text = avgPower.ToString("N2") + " Watts";
        }

        private void avgAltpro()
        {
            //calculate the average altitude
            rowNum = j;
            j = 0;
            string msg;
            for (i = 0; i < rowNum; i++)
            {
                Alt = Alt + hrdata[3, j];
                j++;
            }
            avgAlt = Alt / rowNum;
            if (avgAlt < 0)
            {
                msg = "m below sea level";
            }
            else
            {
                msg = "m above sea level";
            }
            aalt.Text = avgAlt.ToString("N2") + msg;
        }

        private void totalDist()
        {
            //calculate total distance
            rowNum = j;
            double dist, speed = 0, time = 0;
            string msg;
            j = 0;
            for (i = 0; i < rowNum; i++)
            {
                speed = speed + hrdata[1, j];
                j++;
            }
            time = ((double)rowNum / 60) / 60;
            if (rdMph.Checked == true)
            {
                speed = (speed / 16) / rowNum;
                msg = " Miles";
            }
            else
            {
                speed = (speed / 10) / rowNum;
                msg = " Km";
            }
            dist = speed * time;
            tdist.Text = dist.ToString("N2") + msg;
        }

        private void maxSpeedpro()
        {
            //calculate max speed
            rowNum = j;
            string msg;
            j = 0;
            for (i = 0; i < rowNum; i++)
            {
                cSpeed = hrdata[1, j];
                if (cSpeed > maxSpeed)
                {
                    maxSpeed = cSpeed;
                }
                j++;
            }
            if (rdMph.Checked == true)
            {
                maxSpeed = maxSpeed / 16;
                msg = " Mph";
            }
            else
            {
                maxSpeed = maxSpeed / 10;
                msg = " Km/h";
            }

            mspeed.Text = maxSpeed.ToString("N2") + msg;
        }

        private void maxHRatepro()
        {
            //calculate max heart rate
            rowNum = j;
            j = 0;
            for (i = 0; i < rowNum; i++)
            {
                cHRateMax = hrdata[0, j];
                if (cHRateMax > maxHRate)
                {
                    maxHRate = cHRateMax;
                }
                j++;
            }
            mhrate.Text = maxHRate.ToString("N2") + " Bpm";
        }

        private void minHRatepro()
        {
            //calculate min heart rate
            rowNum = j;
            j = 0;
            for (i = 0; i < rowNum; i++)
            {
                cHRateMin = hrdata[0, j];
                if (cHRateMin < minHRate)
                {
                    minHRate = cHRateMin;
                }
                j++;
            }
            mnnhrate.Text = minHRate.ToString("N2") + " Bpm";
        }

        private void maxPowerpro()
        {
            //calculate max power
            rowNum = j;
            j = 0;
            for (i = 0; i < rowNum; i++)
            {
                cPower = hrdata[4, j];
                if (cPower > maxPower)
                {
                    maxPower = cPower;
                }
                j++;
            }
            maxpowerproo.Text = maxPower.ToString("N2") + " Watts";
        }

        private void maxAltpro()
        {
            //calculate max altitude
            rowNum = j;
            string msg;
            j = 0;
            for (i = 0; i < rowNum; i++)
            {
                cAlt = hrdata[3, j];
                if (cAlt > maxAlt)
                {
                    maxAlt = cAlt;
                }
                j++;
            }
            if (maxAlt < 0)
            {
                msg = "m below sea level";
            }
            else
            {
                msg = "m above sea level";
            }
            malt.Text = maxAlt.ToString("N2") + msg;
        }

       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void rdKm_CheckedChanged(object sender, EventArgs e)
        {
            avgSpeedpro();
            maxSpeedpro();
            totalDist();
        }

        private void rdMph_CheckedChanged_1(object sender, EventArgs e)
        {
            avgSpeedpro();
            maxSpeedpro();
            totalDist();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        // Graph for next assignment 
        private void renderGraph()
        {
            clearPoints();

            //draw points on chart from array based on selected checkboxes
            for (int a = 0; a < rowNum; a++)
            {
                int x = 0;
                charData.Series["Heart Rate"].Points.AddXY(x, hrdata[0, a]);
                charData.Series["Speed"].Points.AddXY(x, hrdata[1, a]);
                charData.Series["Cadence"].Points.AddXY(x, hrdata[2, a]);
                charData.Series["Altitude"].Points.AddXY(x, hrdata[3, a]);
                charData.Series["Power"].Points.AddXY(x, hrdata[4, a]);
                x++;
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
            charData.Series["avgHRate"].Points.Clear();
            charData.Series["minHRate"].Points.Clear();
            charData.Series["maxHRate"].Points.Clear();
            charData.Series["avgSpeed"].Points.Clear();
            charData.Series["maxSpeed"].Points.Clear();
            charData.Series["avgAlt"].Points.Clear();
            charData.Series["maxAlt"].Points.Clear();
            charData.Series["avgPower"].Points.Clear();
            charData.Series["maxPower"].Points.Clear();
        }

        
        private void chkHRate_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkHRate.Checked == false)
            {
                charData.Series["Heart Rate"].Points.Clear();
            }
            else
            {
                for (int a = 0; a < rowNum; a++)
                {
                    int x = 0;
                    charData.Series["Heart Rate"].Points.AddXY(x, hrdata[0, a]);
                    x++;
                }
            }
        }
       

        private void chkSpeed_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSpeed.Checked == false)
            {
                charData.Series["Speed"].Points.Clear();
            }
            else
            {
                for (int a = 0; a < rowNum; a++)
                {
                    int x = 0;
                    charData.Series["Speed"].Points.AddXY(x, hrdata[1, a]);
                    x++;
                }
            }
        }

        
       
        private void chkCadence_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkCadence.Checked == false)
            {
                charData.Series["Cadence"].Points.Clear();
            }
            else
            {
                for (int a = 0; a < rowNum; a++)
                {
                    int x = 0;
                    charData.Series["Cadence"].Points.AddXY(x, hrdata[2, a]);
                    x++;
                }
            }
        }
      
   
        private void chkAlt_CheckedChanged_1(object sender, EventArgs e)
        {
             if (chkAlt.Checked == false)
            {
                charData.Series["Altitude"].Points.Clear();
            }
            else
            {
                for (int a = 0; a < rowNum; a++)
                {
                    int x = 0;
                    charData.Series["Altitude"].Points.AddXY(x, hrdata[3, a]);
                    x++;
                }
            }
        }

        private void chkPower_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPower.Checked == false)
            {
                charData.Series["Power"].Points.Clear();
            }
            else
            {
                for (int a = 0; a < rowNum; a++)
                {
                    int x = 0;
                    charData.Series["Power"].Points.AddXY(x, hrdata[4, a]);
                    x++;
                }
            }
        }

        private void chkAvg_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkAvg.Checked == false)
            {
                charData.Series["avgHRate"].Points.Clear();
                charData.Series["avgSpeed"].Points.Clear();
                charData.Series["avgAlt"].Points.Clear();
                charData.Series["avgPower"].Points.Clear();
            }
            else
            {
                if (chkHRate.Checked == true)
                {
                    for (int a = 0; a < rowNum; a++)
                    {
                        int x = 0;
                        charData.Series["avgHRate"].Points.AddXY(x, avgHRate);
                    }
                }
                if (chkSpeed.Checked == true)
                {
                    for (int a = 0; a < rowNum; a++)
                    {
                        int x = 0;
                        charData.Series["avgSpeed"].Points.AddXY(x, avgSpeed);
                    }
                }
                if (chkAlt.Checked == true)
                {
                    for (int a = 0; a < rowNum; a++)
                    {
                        int x = 0;
                        charData.Series["avgAlt"].Points.AddXY(x, avgAlt);
                    }
                }
                if (chkPower.Checked == true)
                {
                    for (int a = 0; a < rowNum; a++)
                    {
                        int x = 0;
                        charData.Series["avgPower"].Points.AddXY(x, avgPower);
                    }
                }
            }
        }

        private void chkMax_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkMax.Checked == false)
            {
                charData.Series["maxHRate"].Points.Clear();
                charData.Series["maxSpeed"].Points.Clear();
                charData.Series["avgAlt"].Points.Clear();
                charData.Series["avgPower"].Points.Clear();
            }
            else
            {
                if (chkHRate.Checked == true)
                {
                    for (int a = 0; a < rowNum; a++)
                    {
                        int x = 0;
                        charData.Series["maxHRate"].Points.AddXY(x, maxHRate);
                    }
                }
                if (chkSpeed.Checked == true)
                {
                    for (int a = 0; a < rowNum; a++)
                    {
                        int x = 0;
                        charData.Series["maxSpeed"].Points.AddXY(x, maxSpeed);
                    }
                }
                if (chkAlt.Checked == true)
                {
                    for (int a = 0; a < rowNum; a++)
                    {
                        int x = 0;
                        charData.Series["maxAlt"].Points.AddXY(x, maxAlt);
                    }
                }
                if (chkPower.Checked == true)
                {
                    for (int a = 0; a < rowNum; a++)
                    {
                        int x = 0;
                        charData.Series["maxPower"].Points.AddXY(x, maxPower);
                    }
                }
            }
        }

        private void chkMin_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkMin.Checked == false)
            {
                charData.Series["minHRate"].Points.Clear();
            }
            else
            {
                if (chkHRate.Checked == true)
                {
                    for (int a = 0; a < rowNum; a++)
                    {
                        int x = 0;
                        charData.Series["minHRate"].Points.AddXY(x, minHRate);
                    }
                }
            }
        }

    
    }
    }
