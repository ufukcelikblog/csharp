using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta10
{
    public partial class Form1 : Form
    {
        private int formKoor, formKoorX, formKoorY;
        private int panelMenuGenislik;
        private bool panelMenuGizli;

        public Form1()
        {
            InitializeComponent();
            //panelTumRadyolar1.Parent = this;
            panelMenuGenislik = panelMENU.Width;
            panelMenuGizli = false;
        }

        private void labelAcKapat_Click(object sender, EventArgs e)
        {
            timerMENU.Start();
        }

        private void timerMENU_Tick(object sender, EventArgs e)
        {
            if(panelMenuGizli)
            {
                panelMENU.Width = panelMENU.Width + 10;
                labelAcKapat.Text = "<";
                labelRadyolar.Text = "RADYOLAR";
                labelFavoriler.Text = "FAVORİLER";
                labelAyarlar.Text = "AYARLAR";
                labelYardim.Text = "YARDIM";
                if(panelMENU.Width >= panelMenuGenislik)
                {
                    timerMENU.Stop();
                    panelMenuGizli = false;
                    this.Refresh();
                } 
            } else
            {
                panelMENU.Width = panelMENU.Width - 10;
                labelAcKapat.Text = ">";
                labelRadyolar.Text = "";
                labelFavoriler.Text = "";
                labelAyarlar.Text = "";
                labelYardim.Text = "?";
                if (panelMENU.Width <= 60)
                {
                    timerMENU.Stop();
                    panelMenuGizli = true;
                    this.Refresh();
                }
            }
        }
        private void labelKapat_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void panelUST_MouseDown(object sender, MouseEventArgs e)
        {
            formKoor = 1; formKoorX = e.X; formKoorY = e.Y;
        }

        private void labelAcKapat_MouseHover(object sender, EventArgs e)
        {
            labelAcKapat.ForeColor = Color.Yellow;
        }

        private void labelAcKapat_MouseLeave(object sender, EventArgs e)
        {
            labelAcKapat.ForeColor = Color.White;
        }

        private void labelRadyolar_MouseHover(object sender, EventArgs e)
        {
            labelRadyolar.ForeColor = Color.Yellow;
        }

        private void labelRadyolar_MouseLeave(object sender, EventArgs e)
        {
            labelRadyolar.ForeColor = Color.White;
        }

        private void labelFavoriler_MouseHover(object sender, EventArgs e)
        {
            labelFavoriler.ForeColor = Color.Yellow;
        }

        private void labelFavoriler_MouseLeave(object sender, EventArgs e)
        {
            labelFavoriler.ForeColor = Color.White;
        }

        private void labelAyarlar_MouseHover(object sender, EventArgs e)
        {
            labelAyarlar.ForeColor = Color.Yellow;
        }

        private void labelAyarlar_MouseLeave(object sender, EventArgs e)
        {
            labelAyarlar.ForeColor = Color.White;
        }

        private void panelUST_MouseMove(object sender, MouseEventArgs e)
        {
            if(formKoor == 1)
            {
                this.SetDesktopLocation(MousePosition.X - formKoorX, MousePosition.Y - formKoorY);
            }
        }

        private void panelUST_MouseUp(object sender, MouseEventArgs e)
        {
            formKoor = 0;
        }

        private void labelRadyolar_Click(object sender, EventArgs e)
        {
            panelORTA.Controls.Clear();
            panelORTA.Controls.Add(panelTumRadyolar1);
            panelTumRadyolar1.Dock = DockStyle.Fill;
        }

        private void labelFavoriler_Click(object sender, EventArgs e)
        {
            panelORTA.Controls.Clear();
            panelORTA.Controls.Add(panelFavoriRadyolar1);
            panelFavoriRadyolar1.Dock = DockStyle.Fill;
        }

        private void labelAyarlar_Click(object sender, EventArgs e)
        {
            panelORTA.Controls.Clear();
            panelORTA.Controls.Add(panelAyarlar1);
            panelAyarlar1.Dock = DockStyle.Fill;
        }

        public void radyoCal (string adres)
        {
            axWindowsMediaPlayer1.URL = @adres;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
