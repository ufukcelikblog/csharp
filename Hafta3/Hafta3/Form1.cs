using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3
{
    public partial class Form1 : Form
    {
        String ekran = "";
        String islem = "YOK";
        double sayi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEsit_MouseHover(object sender, EventArgs e)
        {
            buttonEsit.BackColor = Color.Lime;
            Font eski = buttonEsit.Font;
            buttonEsit.Font = new Font(eski.FontFamily, 24, eski.Style);
        }

        private void buttonEsit_MouseLeave(object sender, EventArgs e)
        {
            buttonEsit.BackColor = Color.PaleGreen;
            Font eski = buttonEsit.Font;
            buttonEsit.Font = new Font(eski.FontFamily, 20, eski.Style);
        }

        private void SayiTiklandi(object sender, EventArgs e)
        {
            // Eğer button1 tıklandı ise sender = button1 olur
            // Eğer button5 tıklandı ise sender = button5 olur
            ekran = ekran + ((Button)sender).Text;
            textBoxEkran.Text = ekran;
        }

        private void IslemTiklandi(object sender, EventArgs e)
        {
            if (islem.Equals("YOK")) // birinci sayı belli oldu
            {
                sayi = double.Parse(ekran);
                ekran = "";
            }
            else // ikinci sayı belli oldu
            {
                switch (islem)
                {
                    case "+":
                        sayi = sayi + double.Parse(ekran);
                        break;
                    case "-":
                        sayi = sayi - double.Parse(ekran);
                        break;
                    case "*":
                        sayi = sayi * double.Parse(ekran);
                        break;
                    case "/":
                        sayi = sayi / double.Parse(ekran);
                        break;
                }
                ekran = sayi.ToString();
                textBoxEkran.Text = ekran;
            }
            islem = ((Button)sender).Text;
            ekran = "";
        }

        private void buttonEsit_Click(object sender, EventArgs e)
        {
            if (islem.Equals("YOK")) // birinci sayı belli değil eşittir anlamsızdır
            {

            }
            else
            {
                switch (islem)
                {
                    case "+":
                        sayi = sayi + double.Parse(ekran);
                        break;
                    case "-":
                        sayi = sayi - double.Parse(ekran);
                        break;
                    case "*":
                        sayi = sayi * double.Parse(ekran);
                        break;
                    case "/":
                        sayi = sayi / double.Parse(ekran);
                        break;
                }
                ekran = sayi.ToString();
                textBoxEkran.Text = ekran;
            }
            islem = "YOK";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            islem = "YOK";
            ekran = "";
            sayi = 0;
            textBoxEkran.Text = "0";
        }
    }
}
