using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta14
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NorthWindDataSetUrunler.Urunler' table. You can move, or remove it, as needed.
            this.UrunlerTableAdapter.Fill(this.NorthWindDataSetUrunler.Urunler);

            this.reportViewer1.RefreshReport();
        }
    }
}
