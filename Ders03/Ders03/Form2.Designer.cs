
namespace Ders03
{
    partial class Form2
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
            this.labelKronometre = new System.Windows.Forms.Label();
            this.buttonBASLA = new System.Windows.Forms.Button();
            this.buttonBEKLE = new System.Windows.Forms.Button();
            this.buttonTEKRAR = new System.Windows.Forms.Button();
            this.timerKronometre = new System.Windows.Forms.Timer(this.components);
            this.buttonKAYDET = new System.Windows.Forms.Button();
            this.listBoxKAYITLAR = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelKronometre
            // 
            this.labelKronometre.AutoSize = true;
            this.labelKronometre.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKronometre.Location = new System.Drawing.Point(12, 9);
            this.labelKronometre.Name = "labelKronometre";
            this.labelKronometre.Size = new System.Drawing.Size(512, 86);
            this.labelKronometre.TabIndex = 0;
            this.labelKronometre.Text = "00:00:00:00:000";
            // 
            // buttonBASLA
            // 
            this.buttonBASLA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBASLA.Location = new System.Drawing.Point(12, 109);
            this.buttonBASLA.Name = "buttonBASLA";
            this.buttonBASLA.Size = new System.Drawing.Size(96, 48);
            this.buttonBASLA.TabIndex = 1;
            this.buttonBASLA.Text = "BAŞLA";
            this.buttonBASLA.UseVisualStyleBackColor = true;
            this.buttonBASLA.Click += new System.EventHandler(this.buttonBASLA_Click);
            // 
            // buttonBEKLE
            // 
            this.buttonBEKLE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBEKLE.Location = new System.Drawing.Point(133, 109);
            this.buttonBEKLE.Name = "buttonBEKLE";
            this.buttonBEKLE.Size = new System.Drawing.Size(99, 48);
            this.buttonBEKLE.TabIndex = 2;
            this.buttonBEKLE.Text = "BEKLE";
            this.buttonBEKLE.UseVisualStyleBackColor = true;
            this.buttonBEKLE.Click += new System.EventHandler(this.buttonBEKLE_Click);
            // 
            // buttonTEKRAR
            // 
            this.buttonTEKRAR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTEKRAR.Location = new System.Drawing.Point(248, 109);
            this.buttonTEKRAR.Name = "buttonTEKRAR";
            this.buttonTEKRAR.Size = new System.Drawing.Size(121, 48);
            this.buttonTEKRAR.TabIndex = 3;
            this.buttonTEKRAR.Text = "TEKRAR";
            this.buttonTEKRAR.UseVisualStyleBackColor = true;
            this.buttonTEKRAR.Click += new System.EventHandler(this.buttonTEKRAR_Click);
            // 
            // timerKronometre
            // 
            this.timerKronometre.Enabled = true;
            this.timerKronometre.Interval = 1;
            this.timerKronometre.Tick += new System.EventHandler(this.timerKronometre_Tick);
            // 
            // buttonKAYDET
            // 
            this.buttonKAYDET.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonKAYDET.Location = new System.Drawing.Point(387, 109);
            this.buttonKAYDET.Name = "buttonKAYDET";
            this.buttonKAYDET.Size = new System.Drawing.Size(121, 48);
            this.buttonKAYDET.TabIndex = 4;
            this.buttonKAYDET.Text = "KAYDET";
            this.buttonKAYDET.UseVisualStyleBackColor = true;
            this.buttonKAYDET.Click += new System.EventHandler(this.buttonKAYDET_Click);
            // 
            // listBoxKAYITLAR
            // 
            this.listBoxKAYITLAR.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxKAYITLAR.FormattingEnabled = true;
            this.listBoxKAYITLAR.ItemHeight = 40;
            this.listBoxKAYITLAR.Location = new System.Drawing.Point(12, 174);
            this.listBoxKAYITLAR.Name = "listBoxKAYITLAR";
            this.listBoxKAYITLAR.Size = new System.Drawing.Size(496, 164);
            this.listBoxKAYITLAR.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 353);
            this.Controls.Add(this.listBoxKAYITLAR);
            this.Controls.Add(this.buttonKAYDET);
            this.Controls.Add(this.buttonTEKRAR);
            this.Controls.Add(this.buttonBEKLE);
            this.Controls.Add(this.buttonBASLA);
            this.Controls.Add(this.labelKronometre);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKronometre;
        private System.Windows.Forms.Button buttonBASLA;
        private System.Windows.Forms.Button buttonBEKLE;
        private System.Windows.Forms.Button buttonTEKRAR;
        private System.Windows.Forms.Timer timerKronometre;
        private System.Windows.Forms.Button buttonKAYDET;
        private System.Windows.Forms.ListBox listBoxKAYITLAR;
    }
}