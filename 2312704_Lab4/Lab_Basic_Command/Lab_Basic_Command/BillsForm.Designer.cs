namespace Lab_Basic_Command
{
    partial class BillsForm
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
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToiNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.lblThucThu = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTongGiamGia = new System.Windows.Forms.TextBox();
            this.txtTongThue = new System.Windows.Forms.TextBox();
            this.txtThucThu = new System.Windows.Forms.TextBox();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuNgay.Location = new System.Drawing.Point(30, 25);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(72, 20);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // dgvBills
            // 
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBills.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TenBan,
            this.Ngay,
            this.GiamGia,
            this.Thue,
            this.TrangThai,
            this.TongTien,
            this.NhanVien});
            this.dgvBills.Location = new System.Drawing.Point(34, 71);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersWidth = 62;
            this.dgvBills.RowTemplate.Height = 28;
            this.dgvBills.Size = new System.Drawing.Size(738, 258);
            this.dgvBills.TabIndex = 1;
            this.dgvBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellDoubleClick);
            this.dgvBills.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBills_CellFormatting);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(101, 20);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(125, 26);
            this.dtpTuNgay.TabIndex = 2;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tới ngày";
            // 
            // dtpToiNgay
            // 
            this.dtpToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToiNgay.Location = new System.Drawing.Point(338, 20);
            this.dtpToiNgay.Name = "dtpToiNgay";
            this.dtpToiNgay.Size = new System.Drawing.Size(125, 26);
            this.dtpToiNgay.TabIndex = 3;
            this.dtpToiNgay.ValueChanged += new System.EventHandler(this.dtpToiNgay_ValueChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(30, 369);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(84, 20);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGia.Location = new System.Drawing.Point(382, 369);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(80, 20);
            this.lblGiamGia.TabIndex = 4;
            this.lblGiamGia.Text = "Giảm giá";
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThue.Location = new System.Drawing.Point(30, 426);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(49, 20);
            this.lblThue.TabIndex = 4;
            this.lblThue.Text = "Thuế";
            // 
            // lblThucThu
            // 
            this.lblThucThu.AutoSize = true;
            this.lblThucThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThucThu.Location = new System.Drawing.Point(382, 426);
            this.lblThucThu.Name = "lblThucThu";
            this.lblThucThu.Size = new System.Drawing.Size(79, 20);
            this.lblThucThu.TabIndex = 4;
            this.lblThucThu.Text = "Thực thu";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(120, 363);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(202, 26);
            this.txtTongTien.TabIndex = 5;
            // 
            // txtTongGiamGia
            // 
            this.txtTongGiamGia.Location = new System.Drawing.Point(479, 363);
            this.txtTongGiamGia.Name = "txtTongGiamGia";
            this.txtTongGiamGia.Size = new System.Drawing.Size(202, 26);
            this.txtTongGiamGia.TabIndex = 5;
            // 
            // txtTongThue
            // 
            this.txtTongThue.Location = new System.Drawing.Point(120, 420);
            this.txtTongThue.Name = "txtTongThue";
            this.txtTongThue.Size = new System.Drawing.Size(202, 26);
            this.txtTongThue.TabIndex = 5;
            // 
            // txtThucThu
            // 
            this.txtThucThu.Location = new System.Drawing.Point(479, 420);
            this.txtThucThu.Name = "txtThucThu";
            this.txtThucThu.Size = new System.Drawing.Size(202, 26);
            this.txtThucThu.TabIndex = 5;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "ID";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 129;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TableName";
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.MinimumWidth = 8;
            this.TenBan.Name = "TenBan";
            this.TenBan.Width = 103;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "CheckoutDate";
            this.Ngay.HeaderText = "Ngày thanh toán";
            this.Ngay.MinimumWidth = 8;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 149;
            // 
            // GiamGia
            // 
            this.GiamGia.DataPropertyName = "Discount";
            this.GiamGia.HeaderText = "Giảm giá";
            this.GiamGia.MinimumWidth = 8;
            this.GiamGia.Name = "GiamGia";
            // 
            // Thue
            // 
            this.Thue.DataPropertyName = "Tax";
            this.Thue.HeaderText = "Thuế";
            this.Thue.MinimumWidth = 8;
            this.Thue.Name = "Thue";
            this.Thue.Width = 81;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "Status";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 108;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "Amount";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 103;
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "Account";
            this.NhanVien.HeaderText = "Nhân viên";
            this.NhanVien.MinimumWidth = 8;
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Width = 107;
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.txtThucThu);
            this.Controls.Add(this.txtTongGiamGia);
            this.Controls.Add(this.txtTongThue);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblThucThu);
            this.Controls.Add(this.lblThue);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dtpToiNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTuNgay);
            this.Name = "BillsForm";
            this.Text = "BillsForm";
            this.Load += new System.EventHandler(this.BillsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToiNgay;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblThucThu;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTongGiamGia;
        private System.Windows.Forms.TextBox txtTongThue;
        private System.Windows.Forms.TextBox txtThucThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
    }
}