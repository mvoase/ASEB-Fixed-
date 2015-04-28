using System;
using System.Collections.Generic;
using System.Linq;

namespace ASEB1
{
    public class HRM
    {
        public static HRM Active = new HRM();

        public DateTime DateTime;
        public DateTime StartTime;
        public DateTime Length;
        public ICollection<Data> DataRows;
        public string Raw = "";

        public HRM(string data)
        {
            List<string> hrmRows = data
                .Substring(HRM.Active.Raw.IndexOf("[HRData]\r\n", StringComparison.Ordinal) + 10)
                .Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

            foreach (var line in hrmRows.TakeWhile(line => !string.IsNullOrWhiteSpace(line)))
            {
                #region 
                
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

                Active.DataRows.Add(dataRow);
                #endregion
            }
        }

        public HRM()
        {
            DataRows = new List<Data>();
        }
    }

    public class Features
    {
        public bool HeartRateEnabled;
        public bool SpeedEnabled;
        public bool CadenceEnabled;
        public bool AltitudeEnabled;
        public bool PowerEnabled;
        public bool PressureEnabled;
        public bool Euro;
    }

    public class Data
    {
        public double HeartRate;
        public double Speed;
        public double Cadence;
        public double Altitude;
        public double Power;
        public double Pressure;
        public DateTime DateTime;
    }
}
