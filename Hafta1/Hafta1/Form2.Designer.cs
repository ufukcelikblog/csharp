namespace Hafta1
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
            this.label_SANTIGRAT = new System.Windows.Forms.Label();
            this.label_FAHRENHEIT = new System.Windows.Forms.Label();
            this.textBox_SANTIGRAT = new System.Windows.Forms.TextBox();
            this.textBox_FAHRENHEIT = new System.Windows.Forms.TextBox();
            this.button_FAHRSANT = new System.Windows.Forms.Button();
            this.button_SANTFAHR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_SANTIGRAT
            // 
            this.label_SANTIGRAT.AutoSize = true;
            this.label_SANTIGRAT.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_SANTIGRAT.Location = new System.Drawing.Point(12, 32);
            this.label_SANTIGRAT.Name = "label_SANTIGRAT";
            this.label_SANTIGRAT.Size = new System.Drawing.Size(85, 22);
            this.label_SANTIGRAT.TabIndex = 0;
            this.label_SANTIGRAT.Text = "Santigrat";
            // 
            // label_FAHRENHEIT
            // 
            this.label_FAHRENHEIT.AutoSize = true;
            this.label_FAHRENHEIT.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_FAHRENHEIT.Location = new System.Drawing.Point(503, 32);
            this.label_FAHRENHEIT.Name = "label_FAHRENHEIT";
            this.label_FAHRENHEIT.Size = new System.Drawing.Size(95, 22);
            this.label_FAHRENHEIT.TabIndex = 1;
            this.label_FAHRENHEIT.Text = "Fahrenheit";
            // 
            // textBox_SANTIGRAT
            // 
            this.textBox_SANTIGRAT.Location = new System.Drawing.Point(107, 33);
            this.textBox_SANTIGRAT.Name = "textBox_SANTIGRAT";
            this.textBox_SANTIGRAT.Size = new System.Drawing.Size(100, 20);
            this.textBox_SANTIGRAT.TabIndex = 2;
            // 
            // textBox_FAHRENHEIT
            // 
            this.textBox_FAHRENHEIT.Location = new System.Drawing.Point(393, 33);
            this.textBox_FAHRENHEIT.Name = "textBox_FAHRENHEIT";
            this.textBox_FAHRENHEIT.Size = new System.Drawing.Size(100, 20);
            this.textBox_FAHRENHEIT.TabIndex = 3;
            // 
            // button_FAHRSANT
            // 
            this.button_FAHRSANT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_FAHRSANT.Image = global::Hafta1.Properties.Resources.solOk;
            this.button_FAHRSANT.Location = new System.Drawing.Point(306, 7);
            this.button_FAHRSANT.Name = "button_FAHRSANT";
            this.button_FAHRSANT.Size = new System.Drawing.Size(77, 72);
            this.button_FAHRSANT.TabIndex = 5;
            this.button_FAHRSANT.UseVisualStyleBackColor = true;
            this.button_FAHRSANT.Click += new System.EventHandler(this.button_FAHRSANT_Click);
            // 
            // button_SANTFAHR
            // 
            this.button_SANTFAHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_SANTFAHR.Image = global::Hafta1.Properties.Resources.sagOk;
            this.button_SANTFAHR.Location = new System.Drawing.Point(217, 8);
            this.button_SANTFAHR.Name = "button_SANTFAHR";
            this.button_SANTFAHR.Size = new System.Drawing.Size(79, 70);
            this.button_SANTFAHR.TabIndex = 4;
            this.button_SANTFAHR.UseVisualStyleBackColor = true;
            this.button_SANTFAHR.Click += new System.EventHandler(this.button_SANTFAHR_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 99);
            this.Controls.Add(this.button_FAHRSANT);
            this.Controls.Add(this.button_SANTFAHR);
            this.Controls.Add(this.textBox_FAHRENHEIT);
            this.Controls.Add(this.textBox_SANTIGRAT);
            this.Controls.Add(this.label_FAHRENHEIT);
            this.Controls.Add(this.label_SANTIGRAT);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SANTIGRAT;
        private System.Windows.Forms.Label label_FAHRENHEIT;
        private System.Windows.Forms.TextBox textBox_SANTIGRAT;
        private System.Windows.Forms.TextBox textBox_FAHRENHEIT;
        private System.Windows.Forms.Button button_SANTFAHR;
        private System.Windows.Forms.Button button_FAHRSANT;
    }
}