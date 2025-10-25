namespace Lab_Basic_Command
{
    partial class NhatKyHoaDon
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
            this.dgvNhatKy = new System.Windows.Forms.DataGridView();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTongGiamGia = new System.Windows.Forms.Label();
            this.lblTongThue = new System.Windows.Forms.Label();
            this.lblTongThucThu = new System.Windows.Forms.Label();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThucThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhatKy
            // 
            this.dgvNhatKy.AllowUserToAddRows = false;
            this.dgvNhatKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNhatKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhatKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLap,
            this.TenBan,
            this.NhanVien,
            this.TongTien,
            this.GiamGia,
            this.Thue,
            this.ThucThu});
            this.dgvNhatKy.Location = new System.Drawing.Point(12, 12);
            this.dgvNhatKy.Name = "dgvNhatKy";
            this.dgvNhatKy.RowHeadersWidth = 62;
            this.dgvNhatKy.RowTemplate.Height = 28;
            this.dgvNhatKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhatKy.Size = new System.Drawing.Size(762, 276);
            this.dgvNhatKy.TabIndex = 0;
            this.dgvNhatKy.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhatKy_CellFormatting);
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Location = new System.Drawing.Point(327, 303);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(13, 20);
            this.lblTongHoaDon.TabIndex = 1;
            this.lblTongHoaDon.Text = ".";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(63, 339);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(13, 20);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = ".";
            // 
            // lblTongGiamGia
            // 
            this.lblTongGiamGia.AutoSize = true;
            this.lblTongGiamGia.Location = new System.Drawing.Point(63, 399);
            this.lblTongGiamGia.Name = "lblTongGiamGia";
            this.lblTongGiamGia.Size = new System.Drawing.Size(13, 20);
            this.lblTongGiamGia.TabIndex = 1;
            this.lblTongGiamGia.Text = ".";
            // 
            // lblTongThue
            // 
            this.lblTongThue.AutoSize = true;
            this.lblTongThue.Location = new System.Drawing.Point(462, 351);
            this.lblTongThue.Name = "lblTongThue";
            this.lblTongThue.Size = new System.Drawing.Size(13, 20);
            this.lblTongThue.TabIndex = 1;
            this.lblTongThue.Text = ".";
            // 
            // lblTongThucThu
            // 
            this.lblTongThucThu.AutoSize = true;
            this.lblTongThucThu.Location = new System.Drawing.Point(462, 399);
            this.lblTongThucThu.Name = "lblTongThucThu";
            this.lblTongThucThu.Size = new System.Drawing.Size(13, 20);
            this.lblTongThucThu.TabIndex = 1;
            this.lblTongThucThu.Text = ".";
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "ID";
            this.MaHD.HeaderText = "Mã HĐ ";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 99;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "CheckoutDate";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 8;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Width = 106;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TableName";
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.MinimumWidth = 8;
            this.TenBan.Name = "TenBan";
            this.TenBan.Width = 103;
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "Account";
            this.NhanVien.HeaderText = "Nhân viên";
            this.NhanVien.MinimumWidth = 8;
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Width = 115;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "Amount";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 111;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "Discount";
            this.GiamGia.HeaderText = "Giảm giá (%)";
            this.GiamGia.MinimumWidth = 8;
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.Width = 136;
            // 
            // Thue
            // 
            this.Thue.DataPropertyName = "Tax";
            this.Thue.HeaderText = "Thuế (%)";
            this.Thue.MinimumWidth = 8;
            this.Thue.Name = "Thue";
            this.Thue.Width = 109;
            // 
            // ThucThu
            // 
            this.ThucThu.DataPropertyName = "Total";
            this.ThucThu.HeaderText = "Thực thu";
            this.ThucThu.MinimumWidth = 8;
            this.ThucThu.Name = "ThucThu";
            this.ThucThu.Width = 107;
            // 
            // NhatKyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTongGiamGia);
            this.Controls.Add(this.lblTongThucThu);
            this.Controls.Add(this.lblTongThue);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblTongHoaDon);
            this.Controls.Add(this.dgvNhatKy);
            this.Name = "NhatKyHoaDon";
            this.Text = "NhatKyHoaDon";
            this.Load += new System.EventHandler(this.NhatKyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhatKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhatKy;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTongGiamGia;
        private System.Windows.Forms.Label lblTongThue;
        private System.Windows.Forms.Label lblTongThucThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThucThu;
    }
}