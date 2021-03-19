using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veritabanDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veritabanDataSet.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.veritabanDataSet.Personel);

        }
    }
}
