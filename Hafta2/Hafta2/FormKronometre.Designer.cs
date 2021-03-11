namespace Hafta2
{
    partial class FormKronometre
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Sure = new System.Windows.Forms.TextBox();
            this.comboBox_Interval = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_KalanSure = new System.Windows.Forms.Label();
            this.button_Baslat = new System.Windows.Forms.Button();
            this.button_Durdur = new System.Windows.Forms.Button();
            this.listBox_Kayit = new System.Windows.Forms.ListBox();
            this.timer_Kronometre = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kronometre Uygulaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Süre";
            // 
            // textBox_Sure
            // 
            this.textBox_Sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Sure.Location = new System.Drawing.Point(71, 55);
            this.textBox_Sure.Name = "textBox_Sure";
            this.textBox_Sure.Size = new System.Drawing.Size(100, 26);
            this.textBox_Sure.TabIndex = 2;
            // 
            // comboBox_Interval
            // 
            this.comboBox_Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Interval.FormattingEnabled = true;
            this.comboBox_Interval.Items.AddRange(new object[] {
            "1000",
            "2000",
            "3000",
            "4000"});
            this.comboBox_Interval.Location = new System.Drawing.Point(19, 96);
            this.comboBox_Interval.Name = "comboBox_Interval";
            this.comboBox_Interval.Size = new System.Drawing.Size(152, 28);
            this.comboBox_Interval.TabIndex = 3;
            this.comboBox_Interval.Text = "Hızınızı seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(205, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalan Süre";
            // 
            // label_KalanSure
            // 
            this.label_KalanSure.AutoSize = true;
            this.label_KalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_KalanSure.Location = new System.Drawing.Point(213, 86);
            this.label_KalanSure.Name = "label_KalanSure";
            this.label_KalanSure.Size = new System.Drawing.Size(37, 39);
            this.label_KalanSure.TabIndex = 5;
            this.label_KalanSure.Text = "0";
            // 
            // button_Baslat
            // 
            this.button_Baslat.BackColor = System.Drawing.Color.SpringGreen;
            this.button_Baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Baslat.Location = new System.Drawing.Point(19, 139);
            this.button_Baslat.Name = "button_Baslat";
            this.button_Baslat.Size = new System.Drawing.Size(152, 39);
            this.button_Baslat.TabIndex = 6;
            this.button_Baslat.Text = "BAŞLAT";
            this.button_Baslat.UseVisualStyleBackColor = false;
            this.button_Baslat.Click += new System.EventHandler(this.button_Baslat_Click);
            // 
            // button_Durdur
            // 
            this.button_Durdur.BackColor = System.Drawing.Color.Red;
            this.button_Durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Durdur.ForeColor = System.Drawing.Color.White;
            this.button_Durdur.Location = new System.Drawing.Point(19, 193);
            this.button_Durdur.Name = "button_Durdur";
            this.button_Durdur.Size = new System.Drawing.Size(152, 39);
            this.button_Durdur.TabIndex = 7;
            this.button_Durdur.Text = "DURDUR";
            this.button_Durdur.UseVisualStyleBackColor = false;
            this.button_Durdur.Click += new System.EventHandler(this.button_Durdur_Click);
            // 
            // listBox_Kayit
            // 
            this.listBox_Kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_Kayit.FormattingEnabled = true;
            this.listBox_Kayit.ItemHeight = 16;
            this.listBox_Kayit.Location = new System.Drawing.Point(199, 132);
            this.listBox_Kayit.Name = "listBox_Kayit";
            this.listBox_Kayit.Size = new System.Drawing.Size(232, 100);
            this.listBox_Kayit.TabIndex = 8;
            // 
            // timer_Kronometre
            // 
            this.timer_Kronometre.Tick += new System.EventHandler(this.timer_Kronometre_Tick);
            // 
            // FormKronometre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.listBox_Kayit);
            this.Controls.Add(this.button_Durdur);
            this.Controls.Add(this.button_Baslat);
            this.Controls.Add(this.label_KalanSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Interval);
            this.Controls.Add(this.textBox_Sure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKronometre";
            this.Text = "Kronometre Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Sure;
        private System.Windows.Forms.ComboBox comboBox_Interval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_KalanSure;
        private System.Windows.Forms.Button button_Baslat;
        private System.Windows.Forms.Button button_Durdur;
        private System.Windows.Forms.ListBox listBox_Kayit;
        private System.Windows.Forms.Timer timer_Kronometre;
    }
}

