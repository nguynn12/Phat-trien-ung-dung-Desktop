namespace Lab07_Entity_Framework
{
    partial class FormChinh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFood = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLy,
            this.mnuHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFood,
            this.mnuCategory,
            this.mnuTable,
            this.mnuBill});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(89, 29);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuFood
            // 
            this.mnuFood.Name = "mnuFood";
            this.mnuFood.Size = new System.Drawing.Size(270, 34);
            this.mnuFood.Text = "Món ăn";
            this.mnuFood.Click += new System.EventHandler(this.mnuFood_Click);
            // 
            // mnuCategory
            // 
            this.mnuCategory.Name = "mnuCategory";
            this.mnuCategory.Size = new System.Drawing.Size(270, 34);
            this.mnuCategory.Text = "Nhóm món";
            this.mnuCategory.Click += new System.EventHandler(this.mnuCategory_Click);
            // 
            // mnuTable
            // 
            this.mnuTable.Name = "mnuTable";
            this.mnuTable.Size = new System.Drawing.Size(270, 34);
            this.mnuTable.Text = "Bàn ăn";
            this.mnuTable.Click += new System.EventHandler(this.mnuTable_Click);
            // 
            // mnuBill
            // 
            this.mnuBill.Name = "mnuBill";
            this.mnuBill.Size = new System.Drawing.Size(270, 34);
            this.mnuBill.Text = "Hóa đơn";
            this.mnuBill.Click += new System.EventHandler(this.mnuBill_Click);
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(103, 29);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(270, 34);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng - Lab07";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuFood;
        private System.Windows.Forms.ToolStripMenuItem mnuCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuTable;
        private System.Windows.Forms.ToolStripMenuItem mnuBill;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
    }
}