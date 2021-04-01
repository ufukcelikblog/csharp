
namespace Ders04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxSAAT = new System.Windows.Forms.PictureBox();
            this.buttonCEVIR = new System.Windows.Forms.Button();
            this.pictureBoxAKREP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSAAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAKREP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSAAT
            // 
            this.pictureBoxSAAT.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSAAT.Image = global::Ders04.Properties.Resources.kadran;
            this.pictureBoxSAAT.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxSAAT.Name = "pictureBoxSAAT";
            this.pictureBoxSAAT.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxSAAT.TabIndex = 0;
            this.pictureBoxSAAT.TabStop = false;
            // 
            // buttonCEVIR
            // 
            this.buttonCEVIR.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCEVIR.Location = new System.Drawing.Point(526, 24);
            this.buttonCEVIR.Name = "buttonCEVIR";
            this.buttonCEVIR.Size = new System.Drawing.Size(94, 52);
            this.buttonCEVIR.TabIndex = 1;
            this.buttonCEVIR.Text = "ÇEVİR";
            this.buttonCEVIR.UseVisualStyleBackColor = true;
            this.buttonCEVIR.Click += new System.EventHandler(this.buttonCEVIR_Click);
            // 
            // pictureBoxAKREP
            // 
            this.pictureBoxAKREP.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAKREP.Image = global::Ders04.Properties.Resources.akrep;
            this.pictureBoxAKREP.Location = new System.Drawing.Point(27, 223);
            this.pictureBoxAKREP.Name = "pictureBoxAKREP";
            this.pictureBoxAKREP.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxAKREP.TabIndex = 2;
            this.pictureBoxAKREP.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 523);
            this.Controls.Add(this.pictureBoxAKREP);
            this.Controls.Add(this.buttonCEVIR);
            this.Controls.Add(this.pictureBoxSAAT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSAAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAKREP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSAAT;
        private System.Windows.Forms.Button buttonCEVIR;
        private System.Windows.Forms.PictureBox pictureBoxAKREP;
    }
}

