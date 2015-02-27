using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASEB1
{
    public partial class Form1 : Form
    {

        private int seconds;
        private int counter;
        private int NumberOfLines;
        private string heart;
        private string speed;
        private string cadence;// = string.Empty;
        private string altitude;
        private string power;
        private string powerbal;
        private string line;
        private string HRM;
        private double[] heartgrapharr;
        DateTime myDateTime;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open .HRM File";
            openFileDialog.InitialDirectory = @"c:\";
            openFileDialog.Filter = "HRM files (*.hrm)|*.hrm|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

            }

            StreamReader reader = new StreamReader(openFileDialog.FileName, System.Text.Encoding.Default);

            string TextFF = reader.ReadToEnd();


            int lineIndex = TextFF.IndexOf("Date=");
            string lineDate = TextFF.Substring(lineIndex + 5, 8);// 8 characters = 20090412

            lineDate = lineDate.Insert(4, "-"); // add hyphen after yyyy
            lineDate = lineDate.Insert(7, "-"); // add hyphen after MM

            lineIndex = TextFF.IndexOf("StartTime=");
            string lineTime = TextFF.Substring(lineIndex + 10, 8); // 8 characters= hh:mm:ss
            //richTextBox1.AppendText(Environment.NewLine + " Time started: " + lineTime);

            lineIndex = TextFF.IndexOf("Interval="); //eg: StartTime=14:26:18.0
            string lineinter1 = TextFF.Substring(lineIndex + 9, 1); // 8 characters= hh:mm:ss
            //richTextBox1.AppendText(Environment.NewLine + " New entery every " + lineinter1 + " Second(s)");

            lineIndex = TextFF.IndexOf("Length="); //eg: Length=14:26:18.0
            string lineLength = TextFF.Substring(lineIndex + 7, 8); // 8 characters= hh:mm:ss
            //richTextBox1.AppendText(Environment.NewLine + " Length of workout: " + lineLength);

            //richTextBox1.AppendText(Environment.NewLine);

            string textTimeStamp = lineDate + " " + lineTime;

            myDateTime = new DateTime();
            myDateTime = DateTime.ParseExact(textTimeStamp, "yyyy-MM-dd HH:mm:ss", null);



            StreamReader sr = new StreamReader(openFileDialog.FileName, System.Text.Encoding.Default);
            HRM = null;
            NumberOfLines = File.ReadAllLines(openFileDialog.FileName).Length;
            while ((HRM = sr.ReadLine()) != null)
            {
                if (HRM.IndexOf("[HRData]") != -1)
                {
                    //found it
                    break;
                }

            }


            line = sr.ReadLine();

            // Setup an accumulator
            int heartTotal = 0, speedTotal = 0, powerTotal = 0, altTotal = 0;
            double mph = 0;



            DataGridViewColumn time = new DataGridViewTextBoxColumn();
            time.HeaderText = "Time Stamp";
            int colIndex1 = dataGridView1.Columns.Add(time);

            DataGridViewColumn heartrate = new DataGridViewTextBoxColumn();
            heartrate.HeaderText = "Heart Rate";
            int colIndex2 = dataGridView1.Columns.Add(heartrate);

            DataGridViewColumn speeding = new DataGridViewTextBoxColumn();
            speeding.HeaderText = "Speed";
            int colIndex3 = dataGridView1.Columns.Add(speeding);

            DataGridViewColumn cadencer = new DataGridViewTextBoxColumn();
            cadencer.HeaderText = "Cadence";
            int colIndex4 = dataGridView1.Columns.Add(cadencer);

            DataGridViewColumn alt = new DataGridViewTextBoxColumn();
            alt.HeaderText = "Altitude";
            int colIndex5 = dataGridView1.Columns.Add(alt);

            DataGridViewColumn pwr = new DataGridViewTextBoxColumn();
            pwr.HeaderText = "Power (watts)";
            int colIndex6 = dataGridView1.Columns.Add(pwr);


            DataGridViewColumn pwrbal = new DataGridViewTextBoxColumn();
            pwrbal.HeaderText = "Power Balance";
            int colIndex7 = dataGridView1.Columns.Add(pwrbal);



            seconds = Convert.ToInt32(lineinter1);
            counter = 0;



            heartgrapharr = new double[0];

            while (line != null)
            {

                // Increment counter each pass through the loop.
                counter++;

                if (seconds <= 1)
                {
                    myDateTime = myDateTime.AddSeconds(seconds);
                }
                else
                {
                    if (seconds >= 1)
                        myDateTime = myDateTime.AddSeconds(seconds);
                }



                heart = line.Split('\t')[0];
                int heartint = Convert.ToInt32(heart);
                List<string> heartarr = new List<string>();
                heartarr.Add(heart);
                heartTotal += heartint;

                speed = line.Split('\t')[1];
                int speedint = Convert.ToInt32(speed);
                speedTotal += speedint;

                mph = ((double)speedint / (double)1.6);

                if (speedint <= 1)
                {
                    speed = speed.Insert(1, "."); // add point after two numbers
                }
                else
                {
                    if (speedint >= 1)
                        speed = speed.Insert(2, "."); // add point after two numbers
                }



                cadence = line.Split('\t')[2];
                int cadenceint = Convert.ToInt32(cadence);


                altitude = line.Split('\t')[3];
                int altitudeint = Convert.ToInt32(altitude);
                altTotal += altitudeint;


                power = line.Split('\t')[4];




                int powerint = Convert.ToInt32(power);
                powerTotal += powerint;

                line = sr.ReadLine();

                dataGridView1.Rows.Add(myDateTime, heart, speed, cadence, altitude, power, powerbal);

            }





            // Now at the end we check to make sure counter is not zero and then divide heartTotal by our counter...
            double heartAvg = 0.0;
            double speedAvg = 0.0;
            double powerAvg = 0.0;
            double altAvg = 0.0;
            if (counter > 0)
            {
                heartAvg = heartTotal / counter;
                speedAvg = speedTotal / counter;
                powerAvg = powerTotal / counter;
                altAvg = altTotal / counter;
            }
            richTextBox1.AppendText(Environment.NewLine + "Heart average : " + heartAvg.ToString());
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine + "Average Speed (KM/H): " + speedAvg.ToString());
            richTextBox1.AppendText(Environment.NewLine + " - (MPH): " + mph);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine + "Power average : " + powerAvg.ToString());
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine + "Altitude average : " + altAvg.ToString());
        }
        }

    




}




