namespace Hafta14
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NorthWindDataSet = new Hafta14.NorthWindDataSet();
            this.PersonellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonellerTableAdapter = new Hafta14.NorthWindDataSetTableAdapters.PersonellerTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.NorthWindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.NavajoWhite;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Top;
            reportDataSource1.Name = "DataSetPersonel";
            reportDataSource1.Value = this.PersonellerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Hafta14.ReportPersonel.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(800, 188);
            this.reportViewer1.TabIndex = 0;
            // 
            // NorthWindDataSet
            // 
            this.NorthWindDataSet.DataSetName = "NorthWindDataSet";
            this.NorthWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PersonellerBindingSource
            // 
            this.PersonellerBindingSource.DataMember = "Personeller";
            this.PersonellerBindingSource.DataSource = this.NorthWindDataSet;
            // 
            // PersonellerTableAdapter
            // 
            this.PersonellerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PersonellerBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Hafta14.ReportPersoneller.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 188);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(800, 262);
            this.reportViewer2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NorthWindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonellerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonellerBindingSource;
        private NorthWindDataSet NorthWindDataSet;
        private NorthWindDataSetTableAdapters.PersonellerTableAdapter PersonellerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}

