namespace Hafta12
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxEXCEL = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonEXCEL = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxEXCEL = new MetroFramework.Controls.MetroComboBox();
            this.metroGridEXCEL = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEXCEL)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Excel Dosyası :";
            // 
            // metroTextBoxEXCEL
            // 
            // 
            // 
            // 
            this.metroTextBoxEXCEL.CustomButton.Image = null;
            this.metroTextBoxEXCEL.CustomButton.Location = new System.Drawing.Point(349, 1);
            this.metroTextBoxEXCEL.CustomButton.Name = "";
            this.metroTextBoxEXCEL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEXCEL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEXCEL.CustomButton.TabIndex = 1;
            this.metroTextBoxEXCEL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEXCEL.CustomButton.UseSelectable = true;
            this.metroTextBoxEXCEL.CustomButton.Visible = false;
            this.metroTextBoxEXCEL.Lines = new string[] {
        "..."};
            this.metroTextBoxEXCEL.Location = new System.Drawing.Point(121, 55);
            this.metroTextBoxEXCEL.MaxLength = 32767;
            this.metroTextBoxEXCEL.Name = "metroTextBoxEXCEL";
            this.metroTextBoxEXCEL.PasswordChar = '\0';
            this.metroTextBoxEXCEL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEXCEL.SelectedText = "";
            this.metroTextBoxEXCEL.SelectionLength = 0;
            this.metroTextBoxEXCEL.SelectionStart = 0;
            this.metroTextBoxEXCEL.ShortcutsEnabled = true;
            this.metroTextBoxEXCEL.Size = new System.Drawing.Size(371, 23);
            this.metroTextBoxEXCEL.TabIndex = 1;
            this.metroTextBoxEXCEL.Text = "...";
            this.metroTextBoxEXCEL.UseSelectable = true;
            this.metroTextBoxEXCEL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEXCEL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonEXCEL
            // 
            this.metroButtonEXCEL.Location = new System.Drawing.Point(508, 55);
            this.metroButtonEXCEL.Name = "metroButtonEXCEL";
            this.metroButtonEXCEL.Size = new System.Drawing.Size(75, 23);
            this.metroButtonEXCEL.TabIndex = 2;
            this.metroButtonEXCEL.Text = "SEÇ";
            this.metroButtonEXCEL.UseSelectable = true;
            this.metroButtonEXCEL.Click += new System.EventHandler(this.metroButtonEXCEL_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Excel Sayfası :";
            // 
            // metroComboBoxEXCEL
            // 
            this.metroComboBoxEXCEL.FormattingEnabled = true;
            this.metroComboBoxEXCEL.ItemHeight = 23;
            this.metroComboBoxEXCEL.Location = new System.Drawing.Point(121, 91);
            this.metroComboBoxEXCEL.Name = "metroComboBoxEXCEL";
            this.metroComboBoxEXCEL.Size = new System.Drawing.Size(267, 29);
            this.metroComboBoxEXCEL.TabIndex = 4;
            this.metroComboBoxEXCEL.UseSelectable = true;
            this.metroComboBoxEXCEL.SelectedIndexChanged += new System.EventHandler(this.metroComboBoxEXCEL_SelectedIndexChanged);
            // 
            // metroGridEXCEL
            // 
            this.metroGridEXCEL.AllowUserToAddRows = false;
            this.metroGridEXCEL.AllowUserToDeleteRows = false;
            this.metroGridEXCEL.AllowUserToResizeRows = false;
            this.metroGridEXCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridEXCEL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEXCEL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridEXCEL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridEXCEL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEXCEL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGridEXCEL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridEXCEL.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGridEXCEL.EnableHeadersVisualStyles = false;
            this.metroGridEXCEL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridEXCEL.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridEXCEL.Location = new System.Drawing.Point(23, 141);
            this.metroGridEXCEL.Name = "metroGridEXCEL";
            this.metroGridEXCEL.ReadOnly = true;
            this.metroGridEXCEL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridEXCEL.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGridEXCEL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridEXCEL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridEXCEL.Size = new System.Drawing.Size(560, 191);
            this.metroGridEXCEL.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 355);
            this.Controls.Add(this.metroGridEXCEL);
            this.Controls.Add(this.metroComboBoxEXCEL);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButtonEXCEL);
            this.Controls.Add(this.metroTextBoxEXCEL);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Excel Veri Aktarma";
            ((System.ComponentModel.ISupportInitialize)(this.metroGridEXCEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEXCEL;
        private MetroFramework.Controls.MetroButton metroButtonEXCEL;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBoxEXCEL;
        private MetroFramework.Controls.MetroGrid metroGridEXCEL;
    }
}

