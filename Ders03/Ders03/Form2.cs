using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Stopwatch km = new Stopwatch();

        private void buttonBASLA_Click(object sender, EventArgs e)
        {
            if(!km.IsRunning)
            {
                km.Start();
            }
        }

        private void buttonBEKLE_Click(object sender, EventArgs e)
        {
            if(km.IsRunning)
            {
                km.Stop();
            }

        }

        private void buttonTEKRAR_Click(object sender, EventArgs e)
        {
            labelKronometre.Text = "00:00:00:00:000";
            km.Reset();
        }

        private void timerKronometre_Tick(object sender, EventArgs e)
        {
            if(km.IsRunning)
            {
                // geçen zaman aralığını alıyoruz
                TimeSpan ts = km.Elapsed;
                labelKronometre.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                    ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            }
        }

        private void buttonKAYDET_Click(object sender, EventArgs e)
        {
            listBoxKAYITLAR.Items.Add(labelKronometre.Text);
        }
    }
}
