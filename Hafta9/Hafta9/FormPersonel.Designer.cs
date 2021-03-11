namespace Hafta9
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
            System.Windows.Forms.Label adLabel;
            System.Windows.Forms.Label soyadLabel;
            System.Windows.Forms.Label yasLabel;
            System.Windows.Forms.Label cinsiyetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.personelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanDataSet = new Hafta9.VeritabanDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.personelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.yasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cinsiyetComboBox = new System.Windows.Forms.ComboBox();
            this.personelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTableAdapter = new Hafta9.VeritabanDataSetTableAdapters.PersonelTableAdapter();
            this.tableAdapterManager = new Hafta9.VeritabanDataSetTableAdapters.TableAdapterManager();
            adLabel = new System.Windows.Forms.Label();
            soyadLabel = new System.Windows.Forms.Label();
            yasLabel = new System.Windows.Forms.Label();
            cinsiyetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingNavigator)).BeginInit();
            this.personelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            adLabel.Location = new System.Drawing.Point(17, 37);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(36, 20);
            adLabel.TabIndex = 3;
            adLabel.Text = "Ad:";
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            soyadLabel.Location = new System.Drawing.Point(271, 34);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new System.Drawing.Size(64, 20);
            soyadLabel.TabIndex = 5;
            soyadLabel.Text = "Soyad:";
            // 
            // yasLabel
            // 
            yasLabel.AutoSize = true;
            yasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            yasLabel.Location = new System.Drawing.Point(17, 78);
            yasLabel.Name = "yasLabel";
            yasLabel.Size = new System.Drawing.Size(45, 20);
            yasLabel.TabIndex = 7;
            yasLabel.Text = "Yas:";
            // 
            // cinsiyetLabel
            // 
            cinsiyetLabel.AutoSize = true;
            cinsiyetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cinsiyetLabel.Location = new System.Drawing.Point(271, 82);
            cinsiyetLabel.Name = "cinsiyetLabel";
            cinsiyetLabel.Size = new System.Drawing.Size(77, 20);
            cinsiyetLabel.TabIndex = 9;
            cinsiyetLabel.Text = "Cinsiyet:";
            // 
            // personelBindingNavigator
            // 
            this.personelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personelBindingNavigator.BindingSource = this.personelBindingSource;
            this.personelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personelBindingNavigatorSaveItem});
            this.personelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personelBindingNavigator.Name = "personelBindingNavigator";
            this.personelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personelBindingNavigator.Size = new System.Drawing.Size(570, 25);
            this.personelBindingNavigator.TabIndex = 0;
            this.personelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.veritabanDataSet;
            // 
            // veritabanDataSet
            // 
            this.veritabanDataSet.DataSetName = "VeritabanDataSet";
            this.veritabanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // personelBindingNavigatorSaveItem
            // 
            this.personelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personelBindingNavigatorSaveItem.Image")));
            this.personelBindingNavigatorSaveItem.Name = "personelBindingNavigatorSaveItem";
            this.personelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.personelBindingNavigatorSaveItem.Text = "Save Data";
            this.personelBindingNavigatorSaveItem.Click += new System.EventHandler(this.personelBindingNavigatorSaveItem_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "Ad", true));
            this.adTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adTextBox.Location = new System.Drawing.Point(81, 34);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(175, 26);
            this.adTextBox.TabIndex = 4;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "Soyad", true));
            this.soyadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadTextBox.Location = new System.Drawing.Point(359, 31);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(175, 26);
            this.soyadTextBox.TabIndex = 6;
            // 
            // yasNumericUpDown
            // 
            this.yasNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personelBindingSource, "Yas", true));
            this.yasNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yasNumericUpDown.Location = new System.Drawing.Point(81, 76);
            this.yasNumericUpDown.Name = "yasNumericUpDown";
            this.yasNumericUpDown.Size = new System.Drawing.Size(68, 26);
            this.yasNumericUpDown.TabIndex = 8;
            // 
            // cinsiyetComboBox
            // 
            this.cinsiyetComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personelBindingSource, "Cinsiyet", true));
            this.cinsiyetComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cinsiyetComboBox.FormattingEnabled = true;
            this.cinsiyetComboBox.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cinsiyetComboBox.Location = new System.Drawing.Point(359, 82);
            this.cinsiyetComboBox.Name = "cinsiyetComboBox";
            this.cinsiyetComboBox.Size = new System.Drawing.Size(175, 28);
            this.cinsiyetComboBox.TabIndex = 10;
            // 
            // personelDataGridView
            // 
            this.personelDataGridView.AutoGenerateColumns = false;
            this.personelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.personelDataGridView.DataSource = this.personelBindingSource;
            this.personelDataGridView.Location = new System.Drawing.Point(12, 129);
            this.personelDataGridView.Name = "personelDataGridView";
            this.personelDataGridView.Size = new System.Drawing.Size(544, 161);
            this.personelDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Soyad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Soyad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Yas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Yas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cinsiyet";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cinsiyet";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonelTableAdapter = this.personelTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hafta9.VeritabanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 302);
            this.Controls.Add(this.personelDataGridView);
            this.Controls.Add(adLabel);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(soyadLabel);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(yasLabel);
            this.Controls.Add(this.yasNumericUpDown);
            this.Controls.Add(cinsiyetLabel);
            this.Controls.Add(this.cinsiyetComboBox);
            this.Controls.Add(this.personelBindingNavigator);
            this.Name = "Form1";
            this.Text = "Personel Kayıtları";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingNavigator)).EndInit();
            this.personelBindingNavigator.ResumeLayout(false);
            this.personelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VeritabanDataSet veritabanDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private VeritabanDataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private VeritabanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personelBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.NumericUpDown yasNumericUpDown;
        private System.Windows.Forms.ComboBox cinsiyetComboBox;
        private System.Windows.Forms.DataGridView personelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

