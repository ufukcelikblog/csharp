namespace Hafta9
{
    partial class FormAnasayfa
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Liste");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Raporlar");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Personel", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Liste");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Stoklar", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Anasayfa", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPersonel,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemPersonel
            // 
            this.toolStripMenuItemPersonel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlarToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.toolStripMenuItemPersonel.Name = "toolStripMenuItemPersonel";
            this.toolStripMenuItemPersonel.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItemPersonel.Text = "Personel";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.toolStripMenuItem1.Text = "Stok";
            // 
            // kayıtlarToolStripMenuItem
            // 
            this.kayıtlarToolStripMenuItem.Name = "kayıtlarToolStripMenuItem";
            this.kayıtlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayıtlarToolStripMenuItem.Text = "Kayıtlar";
            this.kayıtlarToolStripMenuItem.Click += new System.EventHandler(this.kayıtlarToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NodePersonelListe";
            treeNode1.Text = "Liste";
            treeNode2.Name = "NodePersonelRaporlar";
            treeNode2.Text = "Raporlar";
            treeNode3.Name = "NodePersonel";
            treeNode3.Text = "Personel";
            treeNode4.Name = "NodeStokListe";
            treeNode4.Text = "Liste";
            treeNode5.Name = "NodeStok";
            treeNode5.Text = "Stoklar";
            treeNode6.Name = "NodeAnasayfa";
            treeNode6.Text = "Anasayfa";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(214, 426);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAnasayfa";
            this.Text = "FormAnasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPersonel;
        private System.Windows.Forms.ToolStripMenuItem kayıtlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TreeView treeView1;
    }
}