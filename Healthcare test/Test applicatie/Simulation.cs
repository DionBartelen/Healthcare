using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_test.test_applicatie
{
    public partial class Simulation : Form
    {
        private Time time;
        private float speed;
        private int power;
        private float distance;

        public Simulation()
        {
            InitializeComponent();
            time = new Time(0, 0, 0);
            new Thread(new ThreadStart(Count)).Start();
        }

        private void PowerTrackbar_Scroll(object sender, EventArgs e)
        {
            power = ((TrackBar)sender).Value;
            Powerlabel.Text = power + "";
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            speed = ((TrackBar)sender).Value;
            SpeedLabel.Text = speed + "";
        }

        private void Count()
        {
            while (true)
            {
                time.timer();
                TimeLabel.Invoke(new Action(() => TimeLabel.Text = time.ToString()));

                distance += (speed / 60);
                distanceLAbel.Invoke(new Action(() => distanceLAbel.Text = $"{distance:f2}"));

                Thread.Sleep(5);
            }
        }

        private void RPM()
        {

        }

      
    }
       
}
