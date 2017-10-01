using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorApplicatie
{
    public partial class dataGUI : Form
    {
        TrainSession session;

        public dataGUI()
        {
            InitializeComponent();
        }

        public void SetTrainSession(TrainSession session)
        {
            this.session = session;
            SetChartData();
        }

        public void SetChartData()
        {
            double minValue = 0;
            double maxValue = 0;
            List<int> widthSpeed = new List<int>();
            List<double> valuesSpeed = new List<double>();
            foreach (ErgometerData data in session.data)
            {
                if(data.Speed > maxValue)
                {
                    maxValue = data.Speed;
                }
                SpeedChart.Series[0].Points.Add(data.Speed);
                widthSpeed.Add(data.Time);
                valuesSpeed.Add(data.Speed);
            }
            List<int> heightSpeed = new List<int>();
            for(int x = 0; x < 10; x++)
            {
                heightSpeed.Add((int)(minValue + (x * (maxValue / 10.0))));
            }
            SpeedChart.Series[0].Points.Clear();
            foreach(double d in valuesSpeed)
            {
                
            }
        }
    }
}
