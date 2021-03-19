namespace Hafta10
{
    partial class RadyoPanel
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
            this.labelIsim = new System.Windows.Forms.Label();
            this.labelFrekans = new System.Windows.Forms.Label();
            this.labelTur = new System.Windows.Forms.Label();
            this.buttonFavori = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIsim
            // 
            this.labelIsim.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIsim.ForeColor = System.Drawing.Color.Black;
            this.labelIsim.Location = new System.Drawing.Point(114, 20);
            this.labelIsim.Name = "labelIsim";
            this.labelIsim.Size = new System.Drawing.Size(191, 38);
            this.labelIsim.TabIndex = 1;
            this.labelIsim.Text = "Radyo İsimi";
            // 
            // labelFrekans
            // 
            this.labelFrekans.AutoSize = true;
            this.labelFrekans.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFrekans.ForeColor = System.Drawing.Color.Black;
            this.labelFrekans.Location = new System.Drawing.Point(241, 62);
            this.labelFrekans.Name = "labelFrekans";
            this.labelFrekans.Size = new System.Drawing.Size(110, 36);
            this.labelFrekans.TabIndex = 2;
            this.labelFrekans.Text = "100.0";
            // 
            // labelTur
            // 
            this.labelTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTur.ForeColor = System.Drawing.Color.DimGray;
            this.labelTur.Location = new System.Drawing.Point(118, 71);
            this.labelTur.Name = "labelTur";
            this.labelTur.Size = new System.Drawing.Size(117, 27);
            this.labelTur.TabIndex = 3;
            this.labelTur.Text = "Yabancı Pop";
            // 
            // buttonFavori
            // 
            this.buttonFavori.BackColor = System.Drawing.Color.Indigo;
            this.buttonFavori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFavori.Image = global::Hafta10.Properties.Resources.menuFavori;
            this.buttonFavori.Location = new System.Drawing.Point(314, 10);
            this.buttonFavori.Name = "buttonFavori";
            this.buttonFavori.Size = new System.Drawing.Size(37, 33);
            this.buttonFavori.TabIndex = 4;
            this.buttonFavori.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Hafta10.Properties.Resources.radyoBest;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // RadyoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.buttonFavori);
            this.Controls.Add(this.labelTur);
            this.Controls.Add(this.labelFrekans);
            this.Controls.Add(this.labelIsim);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "RadyoPanel";
            this.Size = new System.Drawing.Size(363, 120);
            this.MouseLeave += new System.EventHandler(this.RadyoPanel_MouseLeave);
            this.MouseHover += new System.EventHandler(this.RadyoPanel_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelIsim;
        private System.Windows.Forms.Label labelFrekans;
        private System.Windows.Forms.Label labelTur;
        private System.Windows.Forms.Button buttonFavori;
    }
}
