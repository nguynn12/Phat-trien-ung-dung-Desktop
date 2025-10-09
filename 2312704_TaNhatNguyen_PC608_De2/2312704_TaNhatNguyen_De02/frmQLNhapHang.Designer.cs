namespace _2312704_TaNhatNguyen_De02
{
    partial class frmQLNhapHang
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
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNhaCC = new System.Windows.Forms.Label();
            this.txtNhaCC = new System.Windows.Forms.TextBox();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.nudGiamGIa = new System.Windows.Forms.NumericUpDown();
            this.lblPhaiTra = new System.Windows.Forms.Label();
            this.txtPhaiTra = new System.Windows.Forms.TextBox();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.btnChonHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGIa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(153, 9);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(457, 46);
            this.lblHoaDon.TabIndex = 0;
            this.lblHoaDon.Text = "HÓA ĐƠN NHẬP HÀNG";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Location = new System.Drawing.Point(36, 75);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(73, 16);
            this.lblNgayNhap.TabIndex = 1;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(115, 70);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayNhap.TabIndex = 2;
            // 
            // lblNhaCC
            // 
            this.lblNhaCC.AutoSize = true;
            this.lblNhaCC.Location = new System.Drawing.Point(411, 70);
            this.lblNhaCC.Name = "lblNhaCC";
            this.lblNhaCC.Size = new System.Drawing.Size(90, 16);
            this.lblNhaCC.TabIndex = 3;
            this.lblNhaCC.Text = "Nhà cung cấp";
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Location = new System.Drawing.Point(507, 67);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.ReadOnly = true;
            this.txtNhaCC.Size = new System.Drawing.Size(119, 22);
            this.txtNhaCC.TabIndex = 4;
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.Location = new System.Drawing.Point(632, 67);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(31, 23);
            this.btnThemNCC.TabIndex = 5;
            this.btnThemNCC.Text = "+";
            this.btnThemNCC.UseVisualStyleBackColor = true;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.Location = new System.Drawing.Point(36, 120);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(112, 16);
            this.lblChiTiet.TabIndex = 6;
            this.lblChiTiet.Text = "Chi tiết hàng nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHang,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dataGridView1.Location = new System.Drawing.Point(39, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(36, 337);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(63, 16);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(115, 331);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(128, 22);
            this.txtTongTien.TabIndex = 9;
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá nhập";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 125;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Location = new System.Drawing.Point(288, 334);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(76, 16);
            this.lblGiamGia.TabIndex = 10;
            this.lblGiamGia.Text = "% Giảm giá";
            // 
            // nudGiamGIa
            // 
            this.nudGiamGIa.Location = new System.Drawing.Point(370, 332);
            this.nudGiamGIa.Name = "nudGiamGIa";
            this.nudGiamGIa.Size = new System.Drawing.Size(120, 22);
            this.nudGiamGIa.TabIndex = 11;
            // 
            // lblPhaiTra
            // 
            this.lblPhaiTra.AutoSize = true;
            this.lblPhaiTra.Location = new System.Drawing.Point(528, 334);
            this.lblPhaiTra.Name = "lblPhaiTra";
            this.lblPhaiTra.Size = new System.Drawing.Size(52, 16);
            this.lblPhaiTra.TabIndex = 12;
            this.lblPhaiTra.Text = "Phải trả";
            // 
            // txtPhaiTra
            // 
            this.txtPhaiTra.Location = new System.Drawing.Point(586, 328);
            this.txtPhaiTra.Name = "txtPhaiTra";
            this.txtPhaiTra.ReadOnly = true;
            this.txtPhaiTra.Size = new System.Drawing.Size(100, 22);
            this.txtPhaiTra.TabIndex = 13;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Location = new System.Drawing.Point(414, 382);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(75, 23);
            this.btnLuuHD.TabIndex = 14;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.UseVisualStyleBackColor = true;
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Location = new System.Drawing.Point(495, 382);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(94, 23);
            this.btnHuyHD.TabIndex = 14;
            this.btnHuyHD.Text = "Hủy hóa đơn";
            this.btnHuyHD.UseVisualStyleBackColor = true;
            // 
            // btnChonHD
            // 
            this.btnChonHD.Location = new System.Drawing.Point(595, 382);
            this.btnChonHD.Name = "btnChonHD";
            this.btnChonHD.Size = new System.Drawing.Size(94, 23);
            this.btnChonHD.TabIndex = 14;
            this.btnChonHD.Text = "Chọn HĐ Nhập";
            this.btnChonHD.UseVisualStyleBackColor = true;
            // 
            // frmQLNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChonHD);
            this.Controls.Add(this.btnHuyHD);
            this.Controls.Add(this.btnLuuHD);
            this.Controls.Add(this.txtPhaiTra);
            this.Controls.Add(this.lblPhaiTra);
            this.Controls.Add(this.nudGiamGIa);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblChiTiet);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.txtNhaCC);
            this.Controls.Add(this.lblNhaCC);
            this.Controls.Add(this.dtpNgayNhap);
            this.Controls.Add(this.lblNgayNhap);
            this.Controls.Add(this.lblHoaDon);
            this.Name = "frmQLNhapHang";
            this.Text = "frmQLNhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGIa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lblNhaCC;
        private System.Windows.Forms.TextBox txtNhaCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Label lblChiTiet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.NumericUpDown nudGiamGIa;
        private System.Windows.Forms.Label lblPhaiTra;
        private System.Windows.Forms.TextBox txtPhaiTra;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.Button btnChonHD;
    }
}