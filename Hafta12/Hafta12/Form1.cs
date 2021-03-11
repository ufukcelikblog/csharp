using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace Hafta12
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        DataSet excelVeri;

        private void metroButtonEXCEL_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Dosyası|*.xlsx|Excel 97-2003 Dosyası|*.xls", ValidateNames = true })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    metroTextBoxEXCEL.Text = ofd.FileName;
                    var excelDosya = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader okuyucu = ExcelReaderFactory.CreateReader(excelDosya);
                    excelVeri = okuyucu.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    metroComboBoxEXCEL.Items.Clear();
                    foreach (DataTable dt in excelVeri.Tables)
                        metroComboBoxEXCEL.Items.Add(dt.TableName);
                    okuyucu.Close();
                }
            }
        }

        private void metroComboBoxEXCEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroGridEXCEL.DataSource = excelVeri.Tables[metroComboBoxEXCEL.SelectedIndex];
        }
    }
}
