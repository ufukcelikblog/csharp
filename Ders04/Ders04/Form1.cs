using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders04
{
    public partial class Form1 : Form
    {

        Bitmap akrepResim;
        int aci = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxAKREP.Parent = pictureBoxSAAT;
            pictureBoxAKREP.Location = new Point(0, 0);
            akrepResim = new Bitmap(Ders04.Properties.Resources.akrep);
        }

        private void buttonCEVIR_Click(object sender, EventArgs e)
        {
            //if (aci == 360) aci = 0; else aci += 6;
            aci = aci == 360 ? 0 : aci + 30;
            pictureBoxAKREP.Image = resimCevir(akrepResim, aci);
        }

        private Bitmap resimCevir(Bitmap eskiResim, float aci)
        {
            Bitmap yeniResim = new Bitmap(eskiResim.Width, eskiResim.Height);
            using(Graphics g = Graphics.FromImage(yeniResim))
            {
                g.TranslateTransform(eskiResim.Width / 2, eskiResim.Height / 2);
                g.RotateTransform(aci);
                g.TranslateTransform(-eskiResim.Width / 2, -eskiResim.Height / 2);
                g.DrawImage(eskiResim, new Point(0, 0));
            }
            return yeniResim;
        }
    }
}
