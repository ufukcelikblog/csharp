namespace Hafta14
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NorthWindDataSetUrunler = new Hafta14.NorthWindDataSetUrunler();
            this.UrunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UrunlerTableAdapter = new Hafta14.NorthWindDataSetUrunlerTableAdapters.UrunlerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NorthWindDataSetUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUrunListesi";
            reportDataSource1.Value = this.UrunlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hafta14.ReportUrunListesi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // NorthWindDataSetUrunler
            // 
            this.NorthWindDataSetUrunler.DataSetName = "NorthWindDataSetUrunler";
            this.NorthWindDataSetUrunler.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UrunlerBindingSource
            // 
            this.UrunlerBindingSource.DataMember = "Urunler";
            this.UrunlerBindingSource.DataSource = this.NorthWindDataSetUrunler;
            // 
            // UrunlerTableAdapter
            // 
            this.UrunlerTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NorthWindDataSetUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UrunlerBindingSource;
        private NorthWindDataSetUrunler NorthWindDataSetUrunler;
        private NorthWindDataSetUrunlerTableAdapters.UrunlerTableAdapter UrunlerTableAdapter;
    }
}