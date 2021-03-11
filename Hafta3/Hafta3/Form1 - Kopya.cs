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

        private void buttonTopla_Click(object sender, EventArgs e)
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
                    case "+" :
                        sayi = sayi + double.Parse(ekran);
                        break;
                    case "-" :
                        sayi = sayi - double.Parse(ekran);
                        break;
                    case "*" :
                        sayi = sayi * double.Parse(ekran);
                        break;
                    case "/" :
                        sayi = sayi / double.Parse(ekran);
                        break;
                }
                ekran = sayi.ToString();
                textBoxEkran.Text = ekran;              
            }
            islem = "+";
            ekran = "";
        }

        private void buttonCikar_Click(object sender, EventArgs e)
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
            islem = "-";
            ekran = "";
        }

        private void buttonCarp_Click(object sender, EventArgs e)
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
            islem = "*";
            ekran = "";
        }

        private void buttonBol_Click(object sender, EventArgs e)
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
            islem = "/";
            ekran = "";
        }


    }
}
