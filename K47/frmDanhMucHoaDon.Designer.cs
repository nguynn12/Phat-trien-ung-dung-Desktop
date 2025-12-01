namespace K47
{
    partial class frmDanhMucHoaDon
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbNgayHD = new System.Windows.Forms.ListBox();
            this.dgvChiTietHD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbNgayHD);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvChiTietHD);
            this.splitContainer1.Size = new System.Drawing.Size(1106, 732);
            this.splitContainer1.SplitterDistance = 368;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbNgayHD
            // 
            this.lbNgayHD.FormattingEnabled = true;
            this.lbNgayHD.ItemHeight = 20;
            this.lbNgayHD.Location = new System.Drawing.Point(12, 12);
            this.lbNgayHD.Name = "lbNgayHD";
            this.lbNgayHD.Size = new System.Drawing.Size(222, 224);
            this.lbNgayHD.TabIndex = 0;
            this.lbNgayHD.SelectedIndexChanged += new System.EventHandler(this.lbNgayHD_SelectedIndexChanged);
            // 
            // dgvChiTietHD
            // 
            this.dgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHD.Location = new System.Drawing.Point(12, 12);
            this.dgvChiTietHD.Name = "dgvChiTietHD";
            this.dgvChiTietHD.RowHeadersWidth = 62;
            this.dgvChiTietHD.RowTemplate.Height = 28;
            this.dgvChiTietHD.Size = new System.Drawing.Size(701, 512);
            this.dgvChiTietHD.TabIndex = 0;
            // 
            // frmDanhMucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 732);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmDanhMucHoaDon";
            this.Text = "frmDanhMucHoaDon";
            this.Load += new System.EventHandler(this.frmDanhMucHoaDon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbNgayHD;
        private System.Windows.Forms.DataGridView dgvChiTietHD;
    }
}