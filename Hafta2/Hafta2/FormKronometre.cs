using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta2
{
    public partial class FormKronometre : Form
    {
        public int KalanSure;

        public FormKronometre()
        {
            InitializeComponent();
        }

        private void button_Baslat_Click(object sender, EventArgs e)
        {
            KalanSure = System.Convert.ToInt32(textBox_Sure.Text);
            label_KalanSure.Text = KalanSure.ToString();

            listBox_Kayit.Items.Add("Başladı: " + DateTime.Now.TimeOfDay.ToString());
            timer_Kronometre.Interval = System.Convert.ToInt32(comboBox_Interval.Text);
            timer_Kronometre.Start();
        }

        private void button_Durdur_Click(object sender, EventArgs e)
        {
            timer_Kronometre.Stop();
            listBox_Kayit.Items.Add("Durduruldu: " + DateTime.Now.TimeOfDay.ToString());
        }

        private void timer_Kronometre_Tick(object sender, EventArgs e)
        {
            KalanSure = KalanSure - 1;
            label_KalanSure.Text = KalanSure.ToString();

            if (KalanSure == 0)
            {
                timer_Kronometre.Stop();
                listBox_Kayit.Items.Add("Süre Bitti: " + DateTime.Now.TimeOfDay.ToString());
            }
        }
    }
}
