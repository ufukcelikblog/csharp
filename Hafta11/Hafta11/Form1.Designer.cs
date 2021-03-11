namespace Hafta11
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
            this.buttonOLUSTUR = new System.Windows.Forms.Button();
            this.buttonOKU = new System.Windows.Forms.Button();
            this.richTextBoxEXCEL = new System.Windows.Forms.RichTextBox();
            this.buttonGrafik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOLUSTUR
            // 
            this.buttonOLUSTUR.Location = new System.Drawing.Point(44, 37);
            this.buttonOLUSTUR.Name = "buttonOLUSTUR";
            this.buttonOLUSTUR.Size = new System.Drawing.Size(148, 47);
            this.buttonOLUSTUR.TabIndex = 0;
            this.buttonOLUSTUR.Text = "Excel Dosyası Oluştur";
            this.buttonOLUSTUR.UseVisualStyleBackColor = true;
            this.buttonOLUSTUR.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOKU
            // 
            this.buttonOKU.Location = new System.Drawing.Point(207, 37);
            this.buttonOKU.Name = "buttonOKU";
            this.buttonOKU.Size = new System.Drawing.Size(140, 47);
            this.buttonOKU.TabIndex = 1;
            this.buttonOKU.Text = "Excel Oku";
            this.buttonOKU.UseVisualStyleBackColor = true;
            this.buttonOKU.Click += new System.EventHandler(this.buttonOKU_Click);
            // 
            // richTextBoxEXCEL
            // 
            this.richTextBoxEXCEL.Location = new System.Drawing.Point(44, 104);
            this.richTextBoxEXCEL.Name = "richTextBoxEXCEL";
            this.richTextBoxEXCEL.Size = new System.Drawing.Size(303, 61);
            this.richTextBoxEXCEL.TabIndex = 2;
            this.richTextBoxEXCEL.Text = "";
            // 
            // buttonGrafik
            // 
            this.buttonGrafik.Location = new System.Drawing.Point(44, 185);
            this.buttonGrafik.Name = "buttonGrafik";
            this.buttonGrafik.Size = new System.Drawing.Size(148, 41);
            this.buttonGrafik.TabIndex = 3;
            this.buttonGrafik.Text = "Grafik Oluştur";
            this.buttonGrafik.UseVisualStyleBackColor = true;
            this.buttonGrafik.Click += new System.EventHandler(this.buttonGrafik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 331);
            this.Controls.Add(this.buttonGrafik);
            this.Controls.Add(this.richTextBoxEXCEL);
            this.Controls.Add(this.buttonOKU);
            this.Controls.Add(this.buttonOLUSTUR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOLUSTUR;
        private System.Windows.Forms.Button buttonOKU;
        private System.Windows.Forms.RichTextBox richTextBoxEXCEL;
        private System.Windows.Forms.Button buttonGrafik;
    }
}

