
namespace Ders03
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
            this.components = new System.ComponentModel.Container();
            this.labelZaman = new System.Windows.Forms.Label();
            this.timerZaman = new System.Windows.Forms.Timer(this.components);
            this.labelYıl = new System.Windows.Forms.Label();
            this.labelAy = new System.Windows.Forms.Label();
            this.labelGün = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelZaman
            // 
            this.labelZaman.AutoSize = true;
            this.labelZaman.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelZaman.Location = new System.Drawing.Point(12, 9);
            this.labelZaman.Name = "labelZaman";
            this.labelZaman.Size = new System.Drawing.Size(219, 86);
            this.labelZaman.TabIndex = 0;
            this.labelZaman.Text = "label1";
            // 
            // timerZaman
            // 
            this.timerZaman.Enabled = true;
            this.timerZaman.Interval = 1000;
            this.timerZaman.Tick += new System.EventHandler(this.timerZaman_Tick);
            // 
            // labelYıl
            // 
            this.labelYıl.AutoSize = true;
            this.labelYıl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYıl.Location = new System.Drawing.Point(26, 120);
            this.labelYıl.Name = "labelYıl";
            this.labelYıl.Size = new System.Drawing.Size(97, 65);
            this.labelYıl.TabIndex = 1;
            this.labelYıl.Text = "YIL";
            // 
            // labelAy
            // 
            this.labelAy.AutoSize = true;
            this.labelAy.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAy.Location = new System.Drawing.Point(177, 120);
            this.labelAy.Name = "labelAy";
            this.labelAy.Size = new System.Drawing.Size(87, 65);
            this.labelAy.TabIndex = 2;
            this.labelAy.Text = "AY";
            // 
            // labelGün
            // 
            this.labelGün.AutoSize = true;
            this.labelGün.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGün.Location = new System.Drawing.Point(379, 120);
            this.labelGün.Name = "labelGün";
            this.labelGün.Size = new System.Drawing.Size(135, 65);
            this.labelGün.TabIndex = 3;
            this.labelGün.Text = "GÜN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 262);
            this.Controls.Add(this.labelGün);
            this.Controls.Add(this.labelAy);
            this.Controls.Add(this.labelYıl);
            this.Controls.Add(this.labelZaman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZaman;
        private System.Windows.Forms.Timer timerZaman;
        private System.Windows.Forms.Label labelYıl;
        private System.Windows.Forms.Label labelAy;
        private System.Windows.Forms.Label labelGün;
    }
}

