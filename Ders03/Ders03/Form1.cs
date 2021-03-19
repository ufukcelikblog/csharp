using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timerZaman_Tick(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now; // Şimdiki Zaman
            labelZaman.Text = zaman.ToString();
            labelYıl.Text = zaman.Year.ToString();
            labelAy.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.MonthNames[zaman.Month-1];
            labelGün.Text = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat.DayNames[(int)zaman.DayOfWeek];
        }
    }
}
