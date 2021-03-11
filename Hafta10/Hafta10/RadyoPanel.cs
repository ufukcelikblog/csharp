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
    public partial class RadyoPanel : UserControl
    {
        private Image _logo;
        private string _isim;
        private string _frekans;
        private string _tur;

        public RadyoPanel()
        {
            InitializeComponent();
        }

        private void RadyoPanel_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Plum;
        }

        private void RadyoPanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Thistle;
        }

        [Category("Radyo Panel Özellikleri")]
        public Image Logo
        {
            get { return _logo; }
            set { _logo = value; pictureBoxLogo.Image = value; }
        }

        [Category("Radyo Panel Özellikleri")]
        public string Isim
        {
            get { return _isim; }
            set { _isim = value; labelIsim.Text = value; }
        }
        [Category("Radyo Panel Özellikleri")]
        public string Frekans
        {
            get { return _frekans; }
            set { _frekans = value; labelFrekans.Text = value; }
        }
        [Category("Radyo Panel Özellikleri")]
        public string Tur
        {
            get { return _tur; }
            set { _tur = value; labelTur.Text = value; }
        }
    }
}
