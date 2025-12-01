namespace K47
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
            this.flpDSBan = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cmsDanhMuc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXoaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.TenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsmXemHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhMuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpDSBan
            // 
            this.flpDSBan.AutoScroll = true;
            this.flpDSBan.Location = new System.Drawing.Point(12, 12);
            this.flpDSBan.Name = "flpDSBan";
            this.flpDSBan.Size = new System.Drawing.Size(708, 738);
            this.flpDSBan.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(740, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 57);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Thêm";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmsDanhMuc
            // 
            this.cmsDanhMuc.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDanhMuc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCapNhat,
            this.tsmXoaBan,
            this.tsmXemHoaDon});
            this.cmsDanhMuc.Name = "cmsDanhMuc";
            this.cmsDanhMuc.Size = new System.Drawing.Size(277, 133);
            // 
            // tsmCapNhat
            // 
            this.tsmCapNhat.Name = "tsmCapNhat";
            this.tsmCapNhat.Size = new System.Drawing.Size(276, 32);
            this.tsmCapNhat.Text = "Cập nhật thông tin bàn";
            this.tsmCapNhat.Click += new System.EventHandler(this.tsmCapNhat_Click);
            // 
            // tsmXoaBan
            // 
            this.tsmXoaBan.Name = "tsmXoaBan";
            this.tsmXoaBan.Size = new System.Drawing.Size(276, 32);
            this.tsmXoaBan.Text = "Xóa bàn";
            this.tsmXoaBan.Click += new System.EventHandler(this.tsmXoaBan_Click);
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenMon,
            this.DVT,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.lvHoaDon.FullRowSelect = true;
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(740, 87);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(594, 229);
            this.lvHoaDon.TabIndex = 2;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // TenMon
            // 
            this.TenMon.Text = "Tên món";
            // 
            // DVT
            // 
            this.DVT.Text = "ĐVT";
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành tiền";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName});
            this.dataGridView1.Location = new System.Drawing.Point(740, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(594, 249);
            this.dataGridView1.TabIndex = 3;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "Column1";
            this.FoodName.MinimumWidth = 8;
            this.FoodName.Name = "FoodName";
            this.FoodName.Width = 150;
            // 
            // tsmXemHoaDon
            // 
            this.tsmXemHoaDon.Name = "tsmXemHoaDon";
            this.tsmXemHoaDon.Size = new System.Drawing.Size(276, 32);
            this.tsmXemHoaDon.Text = "Xem danh mục hóa đơn";
            this.tsmXemHoaDon.Click += new System.EventHandler(this.tsmXemHoaDon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 762);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.flpDSBan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsDanhMuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpDSBan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ContextMenuStrip cmsDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tsmCapNhat;
        private System.Windows.Forms.ToolStripMenuItem tsmXoaBan;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader TenMon;
        private System.Windows.Forms.ColumnHeader DVT;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.ToolStripMenuItem tsmXemHoaDon;
    }
}

