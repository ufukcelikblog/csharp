using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EXCEL = Microsoft.Office.Interop.Excel;

namespace Hafta11
{
    public partial class Form1 : Form
    {
        EXCEL.Application excelOrnek;
        EXCEL.Workbook excelKitap;
        EXCEL.Worksheet excelSayfa;
        EXCEL.Range excelAlan;
        object kayipDeger = System.Reflection.Missing.Value;
        string hucreDegeri, sonuc=""; 
        int satirSayisi, sütunSayisi, satir = 0, sütun = 0;

        private void buttonGrafik_Click(object sender, EventArgs e)
        {
            excelOrnek = new EXCEL.Application();
            excelKitap = excelOrnek.Workbooks.Add(kayipDeger);
            excelSayfa = (EXCEL.Worksheet)excelKitap.Worksheets.get_Item(1);
            excelSayfa.Cells[1, 1] = ""; excelSayfa.Cells[1, 2] = "İstanbul"; excelSayfa.Cells[1, 3] = "Ankara";
            excelSayfa.Cells[2, 1] = "Ocak"; excelSayfa.Cells[2, 2] = "350"; excelSayfa.Cells[2, 3] = "500";
            excelSayfa.Cells[3, 1] = "Şubat"; excelSayfa.Cells[3, 2] = "300"; excelSayfa.Cells[3, 3] = "450";
            excelSayfa.Cells[4, 1] = "Mart"; excelSayfa.Cells[4, 2] = "400"; excelSayfa.Cells[4, 3] = "600";

    
            EXCEL.ChartObjects excelGrafikler = (EXCEL.ChartObjects)excelSayfa.ChartObjects(Type.Missing);
            EXCEL.ChartObject excelGrafik = (EXCEL.ChartObject)excelGrafikler.Add(10, 80, 300, 250);
            EXCEL.Chart grafikSayfa = excelGrafik.Chart;
            EXCEL.Range grafikAlan = excelSayfa.get_Range("A1","C4");
            grafikSayfa.SetSourceData(grafikAlan, kayipDeger);
            grafikSayfa.ChartType = EXCEL.XlChartType.xlColumnClustered;
            
            excelKitap.SaveAs("C:\\Users\\ufukcelik\\OneDrive\\ornekGrafik.xlsx",
                EXCEL.XlFileFormat.xlWorkbookNormal,
                kayipDeger, kayipDeger, kayipDeger, kayipDeger,
                EXCEL.XlSaveAsAccessMode.xlExclusive,
                kayipDeger, kayipDeger, kayipDeger, kayipDeger, kayipDeger);
            excelKitap.Close(true, kayipDeger, kayipDeger);
            excelOrnek.Quit();
            richTextBoxEXCEL.Text = "Excel Grafik Dosyası oluşturuldu";

            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelOrnek);
            excelOrnek = null;
            GC.Collect();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excelOrnek = new EXCEL.Application();
            if(excelOrnek == null)
            {
                richTextBoxEXCEL.Text = "Excel Yüklü Değil";
                return;
            }
            excelKitap = excelOrnek.Workbooks.Add(kayipDeger);
            excelSayfa = (EXCEL.Worksheet)excelKitap.Worksheets.get_Item(1);
            excelSayfa.Cells[1, 1] = "AD"; excelSayfa.Cells[1, 2] = "SOYAD";
            excelSayfa.Cells[2, 1] = "Ali"; excelSayfa.Cells[2, 2] = "KARA";
            excelSayfa.Cells[3, 1] = "Ayşe"; excelSayfa.Cells[3, 2] = "CAN";
            excelKitap.SaveAs("C:\\Users\\ufukcelik\\OneDrive\\ornek.xlsx", 
                EXCEL.XlFileFormat.xlWorkbookNormal, 
                kayipDeger, kayipDeger, kayipDeger, kayipDeger, 
                EXCEL.XlSaveAsAccessMode.xlExclusive, 
                kayipDeger, kayipDeger, kayipDeger, kayipDeger, kayipDeger);
            excelKitap.Close(true, kayipDeger, kayipDeger);
            excelOrnek.Quit();
            richTextBoxEXCEL.Text = "Excel Dosyası oluşturuldu";

            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelOrnek);
            excelOrnek = null;
            GC.Collect();
        }

        private void buttonOKU_Click(object sender, EventArgs e)
        {
            excelOrnek = new EXCEL.Application();
            excelKitap = excelOrnek.Workbooks.Open(
                @"C:\\Users\\ufukcelik\\OneDrive\\ornek.xlsx",
                0, true, EXCEL.XlPlatform.xlWindows,
                "\t", false,false, 0, true, 1, 0);
            excelSayfa = (EXCEL.Worksheet)excelKitap.Worksheets.get_Item(1);
            excelAlan = excelSayfa.UsedRange; // dolu hücreleri buluyor
            satirSayisi = excelAlan.Rows.Count;
            sütunSayisi = excelAlan.Columns.Count;
            for(satir = 1; satir <= satirSayisi; satir++)
            {
                for(sütun = 1; sütun <= sütunSayisi; sütun++)
                {
                    hucreDegeri = (string)(excelAlan.Cells[satir, sütun] as EXCEL.Range).Value2;
                    sonuc += hucreDegeri + " - ";
                }
                sonuc += "\n";
            }
            richTextBoxEXCEL.Text = sonuc;
            excelKitap.Close(true, null, null);
            excelOrnek.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelSayfa);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelKitap);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelOrnek);
        }
    }
}
