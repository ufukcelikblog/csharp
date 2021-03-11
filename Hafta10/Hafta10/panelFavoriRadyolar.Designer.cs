namespace Hafta10
{
    partial class panelFavoriRadyolar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radyoPanelBestFM = new Hafta10.RadyoPanel();
            this.radyoPanelJoyFM = new Hafta10.RadyoPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.radyoPanelBestFM);
            this.flowLayoutPanel1.Controls.Add(this.radyoPanelJoyFM);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(386, 386);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radyoPanelBestFM
            // 
            this.radyoPanelBestFM.BackColor = System.Drawing.Color.Thistle;
            this.radyoPanelBestFM.Frekans = "98.2";
            this.radyoPanelBestFM.Isim = "Best FM";
            this.radyoPanelBestFM.Location = new System.Drawing.Point(3, 3);
            this.radyoPanelBestFM.Logo = global::Hafta10.Properties.Resources.radyoBest;
            this.radyoPanelBestFM.Name = "radyoPanelBestFM";
            this.radyoPanelBestFM.Size = new System.Drawing.Size(363, 120);
            this.radyoPanelBestFM.TabIndex = 6;
            this.radyoPanelBestFM.Tur = "Türkçe Pop";
            // 
            // radyoPanelJoyFM
            // 
            this.radyoPanelJoyFM.BackColor = System.Drawing.Color.Thistle;
            this.radyoPanelJoyFM.Frekans = "101.2";
            this.radyoPanelJoyFM.Isim = "Joy FM";
            this.radyoPanelJoyFM.Location = new System.Drawing.Point(3, 129);
            this.radyoPanelJoyFM.Logo = global::Hafta10.Properties.Resources.radyoJoy;
            this.radyoPanelJoyFM.Name = "radyoPanelJoyFM";
            this.radyoPanelJoyFM.Size = new System.Drawing.Size(363, 120);
            this.radyoPanelJoyFM.TabIndex = 10;
            this.radyoPanelJoyFM.Tur = "Karışık";
            // 
            // panelFavoriRadyolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "panelFavoriRadyolar";
            this.Size = new System.Drawing.Size(386, 386);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RadyoPanel radyoPanelBestFM;
        private RadyoPanel radyoPanelJoyFM;
    }
}
