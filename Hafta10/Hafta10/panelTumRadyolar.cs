using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta10
{
    public partial class panelTumRadyolar : UserControl
    {

        public panelTumRadyolar()
        {
            InitializeComponent();
        }

        private void radyoPanelBestFM_Click(object sender, EventArgs e)
        {
            // bu panel öncelikle panelORTA içinde sonra Form1 içinde 
            // bu nesnenin öncesi panelORTA'dır ve panelORTA öncesi ise Form1'dir
            Form1 _form1 = (Form1)this.Parent.Parent;
            _form1.radyoCal("http://46.20.7.126:80/;stream.mp3");
        }

        private void radyoPanelBorusan_Click(object sender, EventArgs e)
        {
            Form1 _form1 = (Form1)this.Parent.Parent;
            _form1.radyoCal("https://playerservices.streamtheworld.com/api/livestream-redirect/BORUSAN_KLASIK.mp3");
        }

        private void radyoPanelFenomen_Click(object sender, EventArgs e)
        {
            Form1 _form1 = (Form1)this.Parent.Parent;
            _form1.radyoCal("http://fenomen.listenfenomen.com/fenomen/128/icecast.audio");
        }
    }
}
