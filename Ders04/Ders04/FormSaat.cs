using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ders04
{
    public partial class FormSaat : Form
    {
        Bitmap akrepResim = new Bitmap(Ders04.Properties.Resources.akrep);
        Bitmap yelkovanResim = new Bitmap(Ders04.Properties.Resources.yelkovan);
        Bitmap saniyeResim = new Bitmap(Ders04.Properties.Resources.saniye);
        Bitmap miliResim = new Bitmap(Ders04.Properties.Resources.mili);
        int saat, dakika, saniye, mili;
        DateTime zaman;

        private void FormSaat_Load(object sender, EventArgs e)
        {
            pictureBoxAKREP.Parent = pictureBoxSAAT;
            pictureBoxAKREP.Location = new Point(0, 0);
            pictureBoxYELKOVAN.Parent = pictureBoxAKREP;
            pictureBoxYELKOVAN.Location = new Point(0, 0);
            pictureBoxSANIYE.Parent = pictureBoxYELKOVAN;
            pictureBoxSANIYE.Location = new Point(0, 0);
            pictureBoxMILI.Parent = pictureBoxSANIYE;
            pictureBoxMILI.Location = new Point(0, 0);
            labelSAAT.Parent = pictureBoxMILI;
        }

        private void timerSAAT_Tick(object sender, EventArgs e)
        {
            zaman = DateTime.Now;
            saat = zaman.Hour;
            dakika = zaman.Minute;
            saniye = zaman.Second;
            mili = zaman.Millisecond;
            labelSAAT.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}",
                saat, dakika, saniye, mili);
            Single miliAci = mili * (float)(360) / (float)(1000);
            Single saniyeAci = saniye * 6 + miliAci / 1000;
            Single dakikaAci = dakika * 6 + saniyeAci / 60;
            Single saatAci = saat * 30 + dakikaAci / 12;

            pictureBoxAKREP.Image = resimCevir(akrepResim, saatAci);
            pictureBoxYELKOVAN.Image = resimCevir(yelkovanResim, dakikaAci);
            pictureBoxSANIYE.Image = resimCevir(saniyeResim, saniyeAci);
            pictureBoxMILI.Image = resimCevir(miliResim, miliAci);
        }


        private Bitmap resimCevir(Bitmap eskiResim, float aci)
        {
            Bitmap yeniResim = new Bitmap(eskiResim.Width, eskiResim.Height);
            using (Graphics g = Graphics.FromImage(yeniResim))
            {
                g.TranslateTransform(eskiResim.Width / 2, eskiResim.Height / 2);
                g.RotateTransform(aci);
                g.TranslateTransform(-eskiResim.Width / 2, -eskiResim.Height / 2);
                g.DrawImage(eskiResim, new Point(0, 0));
            }
            return yeniResim;
        }
        public FormSaat()
        {
            InitializeComponent();
        }
    }
}
