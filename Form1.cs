using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        int dsec = 0;
        int sec = 0;
        int min = 0;
        int hou = 0;
        int day = 0;
        string timerValue = null;
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            LabelTimer.ForeColor = Color.White;
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            dsec += 1;
            if (dsec == 10)
            {
                dsec = 0;
                sec += 1;
            }
            if (sec == 60)
            {
                sec = 0;
                min += 1;
            }
            if (min == 60)
            {
                min = 0;
                hou += 1;
            }
            if (hou == 24)
            {
                hou = 0;
                day += 1;
            }
            timerValue = day.ToString("00") + ":"+
                         hou.ToString("00") + ":" +
                         min.ToString("00") + ":" +
                         sec.ToString("00") + ":" +
                         dsec.ToString("0");
            LabelTimer.Text = timerValue;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            MainTimer.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            MainTimer.Stop();
            day = 0;
            hou = 0;
            min = 0;
            sec = 0;
            dsec = 0;
            timerValue = day.ToString("00") + ":" +
             hou.ToString("00") + ":" +
             min.ToString("00") + ":" +
             sec.ToString("00") + ":" +
             dsec.ToString("0");
            LabelTimer.Text = timerValue;

        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            MainTimer.Stop();
        }
    }
}
