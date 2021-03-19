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
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void kayıtlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmPersonel = new Form1();
            frmPersonel.Name = "ufuk";
            if(Application.OpenForms["ufuk"] == null)
            {
                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Name == "NodePersonelListe")
            {
                Form1 frmPersonel = new Form1();
                frmPersonel.Name = "ufuk";
                if (Application.OpenForms["ufuk"] == null)
                {
                    frmPersonel.MdiParent = this;
                    frmPersonel.Show();
                }
            }
        }
    }
}
