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
        public Time CurrentTime { get; set; }
        public float Distance { get; set; }
        public float Speed { get; set; }
        public int Power { get; set; }
        public int Pulse { get; set; }
        public double RPM { get; set; }
        public int Actual_Energy { get; set; }
        public int Requested_Energy { get; set; }
        private Thread CountThread;
        private Boolean ShouldCount = true;
        private Boolean IsRunning = true;

        public Simulation()
        {
            InitializeComponent();
            CurrentTime = new Time(0, 0, 0);
            Distance = 0;
            Speed = 0;
            Power = 0;
            Pulse = 0;
            RPM = 0;
            Actual_Energy = 0;
            Requested_Energy = 0;
            CountThread = new Thread(new ThreadStart(Count));
            CountThread.Start();
        }

        private void PowerTrackbar_Scroll(object sender, EventArgs e)
        {
<<<<<<< HEAD
            power = ((TrackBar)sender).Value;
            Powerlabel.Text = power + " Watt";
=======
            Power = ((TrackBar)sender).Value;
            PowerLabel.Text = Power + "";
>>>>>>> GUILinkToSimulation
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
<<<<<<< HEAD
            speed = ((TrackBar)sender).Value;
            SpeedLabel.Text = speed + " Km/h";
=======
            Speed = ((TrackBar)sender).Value;
            SpeedLabel.Text = Speed + "";
>>>>>>> GUILinkToSimulation
        }

        private void Count()
        {
            while (ShouldCount)
            {
                try
                {
                    CurrentTime.timer();
                    TimeLabel.Invoke(new Action(() => TimeLabel.Text = CurrentTime.ToString()));

<<<<<<< HEAD
                distance += (speed / 60);
                distanceLAbel.Invoke(new Action(() => distanceLAbel.Text = $"{distance:f2}" + " KM"));
=======
                    Distance += (Speed / 60);
                    distanceLAbel.Invoke(new Action(() => distanceLAbel.Text = $"{Distance:f2}"));
>>>>>>> GUILinkToSimulation

                    RPM = Speed * 2.8;
                    RpmLabel.Invoke(new Action(() => RpmLabel.Text = RPM.ToString()));

                    Pulse = 90 + (int)((Power/6) * (Speed/20));
                    PulseLabel.Invoke(new Action(() => PulseLabel.Text = Pulse.ToString()));

                }
                catch (Exception e)
                {
                    
                }

                Thread.Sleep(1000);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            CurrentTime = new Time(0, 0, 0);
            Distance = 0;
            Speed = 0;
            Power = 0;
            Pulse = 0;
            RPM = 0;
            Actual_Energy = 0;
            Requested_Energy = 0;
            SpeedTrackbar.Value = SpeedTrackbar.Minimum;
            PowerTrackbar.Value = PowerTrackbar.Minimum;
            SpeedLabel.Text = 0 + "";
            PowerLabel.Text = 0 + "";
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (IsRunning)
            {
                IsRunning = false;
                CountThread.Suspend();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!IsRunning)
            {
                IsRunning = true;
                CountThread.Resume();
            }
        }
    }
}
