
namespace Ders04
{
    partial class FormSaat
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
            this.pictureBoxSAAT = new System.Windows.Forms.PictureBox();
            this.pictureBoxAKREP = new System.Windows.Forms.PictureBox();
            this.pictureBoxYELKOVAN = new System.Windows.Forms.PictureBox();
            this.pictureBoxSANIYE = new System.Windows.Forms.PictureBox();
            this.pictureBoxMILI = new System.Windows.Forms.PictureBox();
            this.timerSAAT = new System.Windows.Forms.Timer(this.components);
            this.labelSAAT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSAAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAKREP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYELKOVAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSANIYE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMILI)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSAAT
            // 
            this.pictureBoxSAAT.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSAAT.Image = global::Ders04.Properties.Resources.kadran;
            this.pictureBoxSAAT.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSAAT.Name = "pictureBoxSAAT";
            this.pictureBoxSAAT.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxSAAT.TabIndex = 0;
            this.pictureBoxSAAT.TabStop = false;
            // 
            // pictureBoxAKREP
            // 
            this.pictureBoxAKREP.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAKREP.Image = global::Ders04.Properties.Resources.akrep;
            this.pictureBoxAKREP.Location = new System.Drawing.Point(0, 92);
            this.pictureBoxAKREP.Name = "pictureBoxAKREP";
            this.pictureBoxAKREP.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxAKREP.TabIndex = 1;
            this.pictureBoxAKREP.TabStop = false;
            // 
            // pictureBoxYELKOVAN
            // 
            this.pictureBoxYELKOVAN.Image = global::Ders04.Properties.Resources.yelkovan;
            this.pictureBoxYELKOVAN.Location = new System.Drawing.Point(0, 234);
            this.pictureBoxYELKOVAN.Name = "pictureBoxYELKOVAN";
            this.pictureBoxYELKOVAN.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxYELKOVAN.TabIndex = 2;
            this.pictureBoxYELKOVAN.TabStop = false;
            // 
            // pictureBoxSANIYE
            // 
            this.pictureBoxSANIYE.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSANIYE.Image = global::Ders04.Properties.Resources.saniye;
            this.pictureBoxSANIYE.Location = new System.Drawing.Point(0, 345);
            this.pictureBoxSANIYE.Name = "pictureBoxSANIYE";
            this.pictureBoxSANIYE.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxSANIYE.TabIndex = 3;
            this.pictureBoxSANIYE.TabStop = false;
            // 
            // pictureBoxMILI
            // 
            this.pictureBoxMILI.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMILI.Image = global::Ders04.Properties.Resources.mili;
            this.pictureBoxMILI.Location = new System.Drawing.Point(0, 456);
            this.pictureBoxMILI.Name = "pictureBoxMILI";
            this.pictureBoxMILI.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxMILI.TabIndex = 4;
            this.pictureBoxMILI.TabStop = false;
            // 
            // timerSAAT
            // 
            this.timerSAAT.Enabled = true;
            this.timerSAAT.Interval = 1;
            this.timerSAAT.Tick += new System.EventHandler(this.timerSAAT_Tick);
            // 
            // labelSAAT
            // 
            this.labelSAAT.AutoSize = true;
            this.labelSAAT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSAAT.Location = new System.Drawing.Point(173, 325);
            this.labelSAAT.Name = "labelSAAT";
            this.labelSAAT.Size = new System.Drawing.Size(161, 32);
            this.labelSAAT.TabIndex = 5;
            this.labelSAAT.Text = "00:00:00:000";
            // 
            // FormSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 583);
            this.Controls.Add(this.labelSAAT);
            this.Controls.Add(this.pictureBoxSAAT);
            this.Controls.Add(this.pictureBoxMILI);
            this.Controls.Add(this.pictureBoxSANIYE);
            this.Controls.Add(this.pictureBoxYELKOVAN);
            this.Controls.Add(this.pictureBoxAKREP);
            this.Name = "FormSaat";
            this.Text = "FormSaat";
            this.Load += new System.EventHandler(this.FormSaat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSAAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAKREP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYELKOVAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSANIYE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMILI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSAAT;
        private System.Windows.Forms.PictureBox pictureBoxAKREP;
        private System.Windows.Forms.PictureBox pictureBoxYELKOVAN;
        private System.Windows.Forms.PictureBox pictureBoxSANIYE;
        private System.Windows.Forms.PictureBox pictureBoxMILI;
        private System.Windows.Forms.Timer timerSAAT;
        private System.Windows.Forms.Label labelSAAT;
    }
}