using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        Double sonuc = 0;
        String islem = "";
        bool islemSecili = false, yeniSayi = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Sayilar_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // yeni sayı giriliyor
            if(yeniSayi)
            {
                label_SAYI.Text = "";
                yeniSayi = false;
            }
            // negatif pozitif
            if(button.Text == "-/+")
            {
                if(label_SAYI.Text != "")
                {
                    label_SAYI.Text = "" + (Double.Parse(label_SAYI.Text) * -1);
                }
            } // ondalık sayı girişi
            else if(button.Text == ",")
            {
                if(label_SAYI.Text == "")
                {
                    label_SAYI.Text = "0,";
                }
                if (!label_SAYI.Text.Contains(","))
                {
                    label_SAYI.Text += ",";
                }
            }
            else
            {
                if(label_SAYI.Text == "0")
                {
                    label_SAYI.Text = "";
                }
                label_SAYI.Text += button.Text;
            }
        }

        private void Islemler_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(islemSecili)
            {
                button_ESIT.PerformClick();
            } 
            else
            {
                sonuc = Double.Parse(label_SAYI.Text);
            }
            islem = button.Text;
            label_ISLEMLER.Text = sonuc + " " + islem;
            yeniSayi = true;
            islemSecili = true;
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            label_SAYI.Text = "0";
            yeniSayi = true;
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            button_CE.PerformClick();
            islem = "";
            label_ISLEMLER.Text = "";
            islemSecili = false;
        }

        private void button_AC_Click(object sender, EventArgs e)
        {
            button_C.PerformClick();
            listBox_GECMIS.Items.Clear();
        }

        private void button_ESIT_Click(object sender, EventArgs e)
        {
            if(islemSecili)
            {
                String gecmis = label_ISLEMLER.Text + " " + label_SAYI.Text + " = ";
                switch(islem)
                {
                    case "+":
                        label_SAYI.Text = (sonuc + Double.Parse(label_SAYI.Text)).ToString();
                        break;
                    case "-":
                        label_SAYI.Text = (sonuc - Double.Parse(label_SAYI.Text)).ToString();
                        break;
                    case "x":
                        label_SAYI.Text = (sonuc * Double.Parse(label_SAYI.Text)).ToString();
                        break;
                    case "/":
                        label_SAYI.Text = (sonuc / Double.Parse(label_SAYI.Text)).ToString();
                        break;
                    default:
                        break;
                }
                sonuc = Double.Parse(label_SAYI.Text);
                listBox_GECMIS.Items.Add(gecmis + sonuc);
                label_ISLEMLER.Text = "";
                label_ISLEMLER.Text = sonuc + " " + islem;
            }
        }

    }
}
