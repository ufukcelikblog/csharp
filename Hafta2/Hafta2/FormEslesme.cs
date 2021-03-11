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
    public partial class FormEslesme : Form
    {
        Label etk_1 = null;
        Label etk_2 = null;

        // rastgele sayı üretici
        Random random = new Random();
        List<string> icons = new List<string>() 
        { 
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        private void HucrelereResimAta()
        {
            foreach (Control etk in tableLayoutPanel1.Controls)
            {
                Label resEtk = etk as Label;
                if (resEtk != null)
                {
                    int rs = random.Next(icons.Count);
                    resEtk.Text = icons[rs];
                    resEtk.ForeColor = resEtk.BackColor;
                    icons.RemoveAt(rs);
                }
            }
        }
        public FormEslesme()
        {
            InitializeComponent();
            HucrelereResimAta();
        }

        private void label_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true) 
            {
                return;
            }
            Label secilenEtiket = sender as Label;
            if (secilenEtiket != null)
            {
                if (secilenEtiket.ForeColor == Color.Black)
                {
                    return;
                }

                if (etk_1 == null)
                {
                    etk_1 = secilenEtiket;
                    etk_1.ForeColor = Color.Black;

                    return;
                }

                etk_2 = secilenEtiket;
                etk_2.ForeColor = Color.Black;

                oyunBittimi();

                if (etk_1.Text == etk_2.Text)
                {
                    etk_1 = null;
                    etk_2 = null;
                    return;
                }

                timer1.Start();
            }

        }

        private void oyunBittimi()
        {
            foreach (Control etk in tableLayoutPanel1.Controls)
            {
                Label resEtk = etk as Label;
                if (resEtk != null)
                {
                    if (resEtk.ForeColor == resEtk.BackColor)
                    {
                        return;
                    }
                }
            }

            MessageBox.Show("Oyun Bitti...");
            Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            etk_1.ForeColor = etk_1.BackColor;
            etk_2.ForeColor = etk_2.BackColor;

            etk_1 = null;
            etk_2 = null;
        }
    }
}
