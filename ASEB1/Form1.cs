using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEB1
{
    public partial class Form1 : Form
    {
        int i, j, rowNum;
        int[,] hrdata = new int[6, 10000];
        string file_name;
        double speed = 0 , avgSpeed = 0;
        double Alt = 0, avgAlt = 0;
        double HRate = 0, avgHRate = 0;
        double Power = 0, avgPower = 0;
        double maxSpeed = 0, cSpeed;
        double maxHRate = 0, cHRateMax;
        double minHRate = 180, cHRateMin;
        double maxPower = 0, cPower;
        double maxAlt = -250, cAlt;
        double row = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
             // Load the HRM FIle 
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text Document (*.hrm) | *.hrm|All Files (*.*)|*.*";
            DialogResult dialog = op.ShowDialog();
            file_name = op.FileName.ToString();

            if (file_name != "")
            {
                readFile();
            }
        }

        
           
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void readFile()
        {
            //Read the HRM File and Split the values 
            try
            {
                using (StreamReader sr = new StreamReader(file_name))
                {
                    string line;

                    while ((line = sr.ReadLine()) != "[HRData]")
                    {
                        line = sr.ReadLine();
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
                }

            }

            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            avgSpeedpro();
            //maxSpeedpro();
            avgHRatepro();
            //maxHRatepro();
            //minHRatepro();
            //avgPowerpro();
            //maxPowerpro();
            //avgAltpro();
            //maxAltpro():
            //totalDist();
            //renderGraph();
        }
            private void avgSpeedpro()
            {
                //Calculate the average spped 
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
                    msg = "Mph";
                }
                else 
                {
                    avgSpeed = (speed / 10) /rowNum;
                    msg = "Km/h";
                }
                lbAvgSpeed.Text = avgSpeed.ToString("N2") + msg;
            }
            
            private void avgHRatepro()
            {
                //Calculate the average heart rate 
                rowNum = j; 
                j = 0;
                for (i = 0; i < rowNum; i++)
                {
                    HRate = HRate + hrdata[0, j];
                    j++;
                }
                avgHRate = HRate / rowNum;
                lbAvgHR.Text = avgHRate.ToString("N2") + "Bpm";
            }
        }

        





        
     
 }
           

 
    