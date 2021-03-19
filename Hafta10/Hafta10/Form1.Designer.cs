namespace Hafta10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelUST = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.labelKapat = new System.Windows.Forms.Label();
            this.panelMENU = new System.Windows.Forms.Panel();
            this.labelYardim = new System.Windows.Forms.Label();
            this.labelAyarlar = new System.Windows.Forms.Label();
            this.labelFavoriler = new System.Windows.Forms.Label();
            this.labelRadyolar = new System.Windows.Forms.Label();
            this.labelAcKapat = new System.Windows.Forms.Label();
            this.timerMENU = new System.Windows.Forms.Timer(this.components);
            this.panelORTA = new System.Windows.Forms.Panel();
            this.panelAyarlar1 = new Hafta10.panelAyarlar();
            this.panelFavoriRadyolar1 = new Hafta10.panelFavoriRadyolar();
            this.panelTumRadyolar1 = new Hafta10.panelTumRadyolar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelUST.SuspendLayout();
            this.panelMENU.SuspendLayout();
            this.panelORTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUST
            // 
            this.panelUST.BackColor = System.Drawing.Color.Indigo;
            this.panelUST.Controls.Add(this.labelLogo);
            this.panelUST.Controls.Add(this.labelKapat);
            this.panelUST.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUST.Location = new System.Drawing.Point(5, 5);
            this.panelUST.Name = "panelUST";
            this.panelUST.Size = new System.Drawing.Size(889, 40);
            this.panelUST.TabIndex = 0;
            this.panelUST.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUST_MouseDown);
            this.panelUST.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUST_MouseMove);
            this.panelUST.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUST_MouseUp);
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelLogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLogo.Location = new System.Drawing.Point(0, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(192, 35);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "Radyo Uygulaması";
            // 
            // labelKapat
            // 
            this.labelKapat.AutoSize = true;
            this.labelKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelKapat.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKapat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKapat.Location = new System.Drawing.Point(860, 0);
            this.labelKapat.Name = "labelKapat";
            this.labelKapat.Size = new System.Drawing.Size(29, 33);
            this.labelKapat.TabIndex = 0;
            this.labelKapat.Text = "X";
            this.labelKapat.Click += new System.EventHandler(this.labelKapat_Click);
            // 
            // panelMENU
            // 
            this.panelMENU.BackColor = System.Drawing.Color.Purple;
            this.panelMENU.Controls.Add(this.labelYardim);
            this.panelMENU.Controls.Add(this.labelAyarlar);
            this.panelMENU.Controls.Add(this.labelFavoriler);
            this.panelMENU.Controls.Add(this.labelRadyolar);
            this.panelMENU.Controls.Add(this.labelAcKapat);
            this.panelMENU.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMENU.Location = new System.Drawing.Point(5, 45);
            this.panelMENU.Name = "panelMENU";
            this.panelMENU.Size = new System.Drawing.Size(180, 386);
            this.panelMENU.TabIndex = 1;
            // 
            // labelYardim
            // 
            this.labelYardim.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYardim.ForeColor = System.Drawing.Color.White;
            this.labelYardim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelYardim.Location = new System.Drawing.Point(9, 332);
            this.labelYardim.Name = "labelYardim";
            this.labelYardim.Size = new System.Drawing.Size(188, 60);
            this.labelYardim.TabIndex = 4;
            this.labelYardim.Text = "YARDIM";
            this.labelYardim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAyarlar
            // 
            this.labelAyarlar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAyarlar.ForeColor = System.Drawing.Color.White;
            this.labelAyarlar.Image = global::Hafta10.Properties.Resources.menuAyar;
            this.labelAyarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAyarlar.Location = new System.Drawing.Point(12, 177);
            this.labelAyarlar.Name = "labelAyarlar";
            this.labelAyarlar.Size = new System.Drawing.Size(165, 60);
            this.labelAyarlar.TabIndex = 3;
            this.labelAyarlar.Text = "AYARLAR";
            this.labelAyarlar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAyarlar.Click += new System.EventHandler(this.labelAyarlar_Click);
            this.labelAyarlar.MouseLeave += new System.EventHandler(this.labelAyarlar_MouseLeave);
            this.labelAyarlar.MouseHover += new System.EventHandler(this.labelAyarlar_MouseHover);
            // 
            // labelFavoriler
            // 
            this.labelFavoriler.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFavoriler.ForeColor = System.Drawing.Color.White;
            this.labelFavoriler.Image = global::Hafta10.Properties.Resources.menuFavori;
            this.labelFavoriler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelFavoriler.Location = new System.Drawing.Point(8, 117);
            this.labelFavoriler.Name = "labelFavoriler";
            this.labelFavoriler.Size = new System.Drawing.Size(172, 60);
            this.labelFavoriler.TabIndex = 2;
            this.labelFavoriler.Text = "FAVORİLER";
            this.labelFavoriler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelFavoriler.Click += new System.EventHandler(this.labelFavoriler_Click);
            this.labelFavoriler.MouseLeave += new System.EventHandler(this.labelFavoriler_MouseLeave);
            this.labelFavoriler.MouseHover += new System.EventHandler(this.labelFavoriler_MouseHover);
            // 
            // labelRadyolar
            // 
            this.labelRadyolar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRadyolar.ForeColor = System.Drawing.Color.White;
            this.labelRadyolar.Image = global::Hafta10.Properties.Resources.menuRadyo;
            this.labelRadyolar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRadyolar.Location = new System.Drawing.Point(8, 57);
            this.labelRadyolar.Name = "labelRadyolar";
            this.labelRadyolar.Size = new System.Drawing.Size(172, 60);
            this.labelRadyolar.TabIndex = 1;
            this.labelRadyolar.Text = "RADYOLAR";
            this.labelRadyolar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelRadyolar.Click += new System.EventHandler(this.labelRadyolar_Click);
            this.labelRadyolar.MouseLeave += new System.EventHandler(this.labelRadyolar_MouseLeave);
            this.labelRadyolar.MouseHover += new System.EventHandler(this.labelRadyolar_MouseHover);
            // 
            // labelAcKapat
            // 
            this.labelAcKapat.AutoSize = true;
            this.labelAcKapat.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAcKapat.ForeColor = System.Drawing.Color.White;
            this.labelAcKapat.Location = new System.Drawing.Point(12, 7);
            this.labelAcKapat.Name = "labelAcKapat";
            this.labelAcKapat.Size = new System.Drawing.Size(38, 58);
            this.labelAcKapat.TabIndex = 0;
            this.labelAcKapat.Text = "<";
            this.labelAcKapat.Click += new System.EventHandler(this.labelAcKapat_Click);
            this.labelAcKapat.MouseLeave += new System.EventHandler(this.labelAcKapat_MouseLeave);
            this.labelAcKapat.MouseHover += new System.EventHandler(this.labelAcKapat_MouseHover);
            // 
            // timerMENU
            // 
            this.timerMENU.Interval = 10;
            this.timerMENU.Tick += new System.EventHandler(this.timerMENU_Tick);
            // 
            // panelORTA
            // 
            this.panelORTA.Controls.Add(this.panelAyarlar1);
            this.panelORTA.Controls.Add(this.panelFavoriRadyolar1);
            this.panelORTA.Controls.Add(this.panelTumRadyolar1);
            this.panelORTA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelORTA.Location = new System.Drawing.Point(185, 45);
            this.panelORTA.Name = "panelORTA";
            this.panelORTA.Size = new System.Drawing.Size(386, 386);
            this.panelORTA.TabIndex = 2;
            // 
            // panelAyarlar1
            // 
            this.panelAyarlar1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelAyarlar1.Location = new System.Drawing.Point(-3, -2);
            this.panelAyarlar1.Name = "panelAyarlar1";
            this.panelAyarlar1.Size = new System.Drawing.Size(386, 386);
            this.panelAyarlar1.TabIndex = 5;
            // 
            // panelFavoriRadyolar1
            // 
            this.panelFavoriRadyolar1.BackColor = System.Drawing.Color.SlateBlue;
            this.panelFavoriRadyolar1.Location = new System.Drawing.Point(0, 0);
            this.panelFavoriRadyolar1.Name = "panelFavoriRadyolar1";
            this.panelFavoriRadyolar1.Size = new System.Drawing.Size(386, 386);
            this.panelFavoriRadyolar1.TabIndex = 4;
            // 
            // panelTumRadyolar1
            // 
            this.panelTumRadyolar1.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelTumRadyolar1.Location = new System.Drawing.Point(0, 3);
            this.panelTumRadyolar1.Name = "panelTumRadyolar1";
            this.panelTumRadyolar1.Size = new System.Drawing.Size(380, 383);
            this.panelTumRadyolar1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(571, 45);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(323, 386);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(899, 436);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panelORTA);
            this.Controls.Add(this.panelMENU);
            this.Controls.Add(this.panelUST);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.panelUST.ResumeLayout(false);
            this.panelUST.PerformLayout();
            this.panelMENU.ResumeLayout(false);
            this.panelMENU.PerformLayout();
            this.panelORTA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUST;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label labelKapat;
        private System.Windows.Forms.Panel panelMENU;
        private System.Windows.Forms.Label labelAyarlar;
        private System.Windows.Forms.Label labelFavoriler;
        private System.Windows.Forms.Label labelRadyolar;
        private System.Windows.Forms.Label labelAcKapat;
        private System.Windows.Forms.Label labelYardim;
        private System.Windows.Forms.Timer timerMENU;
        private System.Windows.Forms.Panel panelORTA;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private panelTumRadyolar panelTumRadyolar1;
        private panelFavoriRadyolar panelFavoriRadyolar1;
        private panelAyarlar panelAyarlar1;
    }
}

