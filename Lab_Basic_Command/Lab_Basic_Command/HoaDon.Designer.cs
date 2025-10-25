namespace Lab_Basic_Command
{
    partial class HoaDon
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
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupboxHoaDon = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblNhanVienLap = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.txtNhanVienLap = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtThucThu = new System.Windows.Forms.TextBox();
            this.lblTongTienHoaDon = new System.Windows.Forms.Label();
            this.lblThucThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.groupboxHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Location = new System.Drawing.Point(17, 30);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(93, 20);
            this.lblMaHoaDon.TabIndex = 0;
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(127, 24);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(196, 26);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(127, 182);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(196, 26);
            this.dtpNgayLap.TabIndex = 2;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(12, 252);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 62;
            this.dgvChiTietHoaDon.RowTemplate.Height = 28;
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(776, 195);
            this.dgvChiTietHoaDon.TabIndex = 4;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "FoodName";
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.MinimumWidth = 8;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "Quantity";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "Price";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 150;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "Total";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // groupboxHoaDon
            // 
            this.groupboxHoaDon.Controls.Add(this.cboTrangThai);
            this.groupboxHoaDon.Controls.Add(this.lblNgayLap);
            this.groupboxHoaDon.Controls.Add(this.lblTrangThai);
            this.groupboxHoaDon.Controls.Add(this.lblNhanVienLap);
            this.groupboxHoaDon.Controls.Add(this.lblThue);
            this.groupboxHoaDon.Controls.Add(this.lblTenBan);
            this.groupboxHoaDon.Controls.Add(this.lblGiamGia);
            this.groupboxHoaDon.Controls.Add(this.lblMaHoaDon);
            this.groupboxHoaDon.Controls.Add(this.txtNhanVienLap);
            this.groupboxHoaDon.Controls.Add(this.txtThue);
            this.groupboxHoaDon.Controls.Add(this.txtTenBan);
            this.groupboxHoaDon.Controls.Add(this.txtGiamGia);
            this.groupboxHoaDon.Controls.Add(this.txtMaHoaDon);
            this.groupboxHoaDon.Controls.Add(this.dtpNgayLap);
            this.groupboxHoaDon.Location = new System.Drawing.Point(12, 12);
            this.groupboxHoaDon.Name = "groupboxHoaDon";
            this.groupboxHoaDon.Size = new System.Drawing.Size(776, 223);
            this.groupboxHoaDon.TabIndex = 5;
            this.groupboxHoaDon.TabStop = false;
            this.groupboxHoaDon.Text = "Thông tin hóa đơn";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(477, 126);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(196, 28);
            this.cboTrangThai.TabIndex = 3;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(17, 188);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(70, 20);
            this.lblNgayLap.TabIndex = 0;
            this.lblNgayLap.Text = "Ngày lập";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(367, 134);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(80, 20);
            this.lblTrangThai.TabIndex = 0;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblNhanVienLap
            // 
            this.lblNhanVienLap.AutoSize = true;
            this.lblNhanVienLap.Location = new System.Drawing.Point(17, 134);
            this.lblNhanVienLap.Name = "lblNhanVienLap";
            this.lblNhanVienLap.Size = new System.Drawing.Size(104, 20);
            this.lblNhanVienLap.TabIndex = 0;
            this.lblNhanVienLap.Text = "Nhân viên lập";
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.Location = new System.Drawing.Point(367, 80);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(45, 20);
            this.lblThue.TabIndex = 0;
            this.lblThue.Text = "Thuế";
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Location = new System.Drawing.Point(17, 80);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(67, 20);
            this.lblTenBan.TabIndex = 0;
            this.lblTenBan.Text = "Tên bàn";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(367, 30);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(72, 20);
            this.lblGiamGia.TabIndex = 0;
            this.lblGiamGia.Text = "Giảm giá";
            // 
            // txtNhanVienLap
            // 
            this.txtNhanVienLap.Location = new System.Drawing.Point(127, 128);
            this.txtNhanVienLap.Name = "txtNhanVienLap";
            this.txtNhanVienLap.Size = new System.Drawing.Size(196, 26);
            this.txtNhanVienLap.TabIndex = 1;
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(477, 74);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(196, 26);
            this.txtThue.TabIndex = 1;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(127, 74);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(196, 26);
            this.txtTenBan.TabIndex = 1;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(477, 24);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(196, 26);
            this.txtGiamGia.TabIndex = 1;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(172, 477);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(196, 26);
            this.txtTongTien.TabIndex = 1;
            // 
            // txtThucThu
            // 
            this.txtThucThu.Location = new System.Drawing.Point(489, 477);
            this.txtThucThu.Name = "txtThucThu";
            this.txtThucThu.Size = new System.Drawing.Size(196, 26);
            this.txtThucThu.TabIndex = 1;
            // 
            // lblTongTienHoaDon
            // 
            this.lblTongTienHoaDon.AutoSize = true;
            this.lblTongTienHoaDon.Location = new System.Drawing.Point(29, 483);
            this.lblTongTienHoaDon.Name = "lblTongTienHoaDon";
            this.lblTongTienHoaDon.Size = new System.Drawing.Size(137, 20);
            this.lblTongTienHoaDon.TabIndex = 0;
            this.lblTongTienHoaDon.Text = "Tổng tiền hóa đơn";
            // 
            // lblThucThu
            // 
            this.lblThucThu.AutoSize = true;
            this.lblThucThu.Location = new System.Drawing.Point(384, 483);
            this.lblThucThu.Name = "lblThucThu";
            this.lblThucThu.Size = new System.Drawing.Size(75, 20);
            this.lblThucThu.TabIndex = 0;
            this.lblThucThu.Text = "Thực thu ";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.groupboxHoaDon);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.txtThucThu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTienHoaDon);
            this.Controls.Add(this.lblThucThu);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.groupboxHoaDon.ResumeLayout(false);
            this.groupboxHoaDon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.GroupBox groupboxHoaDon;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label lblNhanVienLap;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.TextBox txtNhanVienLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtThucThu;
        private System.Windows.Forms.Label lblTongTienHoaDon;
        private System.Windows.Forms.Label lblThucThu;
    }
}