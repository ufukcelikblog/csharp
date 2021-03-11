using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_SANTFAHR_Click(object sender, EventArgs e)
        {
            // double sant = Double.Parse(textBox_SANTIGRAT.Text);
            double sant = Convert.ToDouble(textBox_SANTIGRAT.Text);
            double fahr = sant * 1.8 + 32;
            textBox_FAHRENHEIT.Text = Convert.ToString(fahr);
        }

        private void button_FAHRSANT_Click(object sender, EventArgs e)
        {
            double fahr = Convert.ToDouble(textBox_FAHRENHEIT.Text);
            double sant = (fahr - 32) / 1.8;
            textBox_SANTIGRAT.Text = Convert.ToString(sant);
        }
    }
}
