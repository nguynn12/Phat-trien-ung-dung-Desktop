namespace QLDVKS_Nhom6
{
    partial class frmPhongKH
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
            this.grpPhong = new System.Windows.Forms.GroupBox();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnSuaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblMaPhong = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.colRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomNameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.grpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPhong
            // 
            this.grpPhong.Controls.Add(this.btnXoaPhong);
            this.grpPhong.Controls.Add(this.btnSuaPhong);
            this.grpPhong.Controls.Add(this.btnThemPhong);
            this.grpPhong.Controls.Add(this.txtTenPhong);
            this.grpPhong.Controls.Add(this.lblTenPhong);
            this.grpPhong.Controls.Add(this.txtMaPhong);
            this.grpPhong.Controls.Add(this.lblMaPhong);
            this.grpPhong.Controls.Add(this.dgvPhong);
            this.grpPhong.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhong.Location = new System.Drawing.Point(15, 13);
            this.grpPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPhong.Name = "grpPhong";
            this.grpPhong.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpPhong.Size = new System.Drawing.Size(469, 520);
            this.grpPhong.TabIndex = 1;
            this.grpPhong.TabStop = false;
            this.grpPhong.Text = "Quản lý phòng";
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Location = new System.Drawing.Point(361, 52);
            this.btnXoaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(90, 44);
            this.btnXoaPhong.TabIndex = 7;
            this.btnXoaPhong.Text = "Xóa";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnSuaPhong
            // 
            this.btnSuaPhong.Location = new System.Drawing.Point(265, 81);
            this.btnSuaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaPhong.Name = "btnSuaPhong";
            this.btnSuaPhong.Size = new System.Drawing.Size(90, 44);
            this.btnSuaPhong.TabIndex = 6;
            this.btnSuaPhong.Text = "Sửa";
            this.btnSuaPhong.UseVisualStyleBackColor = true;
            this.btnSuaPhong.Click += new System.EventHandler(this.btnSuaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(265, 31);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(90, 44);
            this.btnThemPhong.TabIndex = 5;
            this.btnThemPhong.Text = "Thêm";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(135, 88);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(112, 29);
            this.txtTenPhong.TabIndex = 4;
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(22, 91);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(85, 21);
            this.lblTenPhong.TabIndex = 3;
            this.lblTenPhong.Text = "Tên phòng:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(135, 38);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(112, 29);
            this.txtMaPhong.TabIndex = 2;
            // 
            // lblMaPhong
            // 
            this.lblMaPhong.AutoSize = true;
            this.lblMaPhong.Location = new System.Drawing.Point(22, 41);
            this.lblMaPhong.Name = "lblMaPhong";
            this.lblMaPhong.Size = new System.Drawing.Size(84, 21);
            this.lblMaPhong.TabIndex = 1;
            this.lblMaPhong.Text = "Mã phòng:";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomID,
            this.colRoomNameRoom,
            this.colStatus});
            this.dgvPhong.Location = new System.Drawing.Point(26, 133);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 62;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(425, 360);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            this.dgvPhong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhong_CellFormatting);
            // 
            // colRoomID
            // 
            this.colRoomID.HeaderText = "Mã phòng";
            this.colRoomID.MinimumWidth = 8;
            this.colRoomID.Name = "colRoomID";
            this.colRoomID.ReadOnly = true;
            this.colRoomID.Width = 117;
            // 
            // colRoomNameRoom
            // 
            this.colRoomNameRoom.HeaderText = "Tên phòng";
            this.colRoomNameRoom.MinimumWidth = 8;
            this.colRoomNameRoom.Name = "colRoomNameRoom";
            this.colRoomNameRoom.ReadOnly = true;
            this.colRoomNameRoom.Width = 118;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 8;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 115;
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKhachHang.Controls.Add(this.btnXoaKH);
            this.grpKhachHang.Controls.Add(this.btnSuaKH);
            this.grpKhachHang.Controls.Add(this.btnThemKH);
            this.grpKhachHang.Controls.Add(this.txtDiaChi);
            this.grpKhachHang.Controls.Add(this.lblDiaChi);
            this.grpKhachHang.Controls.Add(this.txtSoDienThoai);
            this.grpKhachHang.Controls.Add(this.lblSoDienThoai);
            this.grpKhachHang.Controls.Add(this.txtTenKhachHang);
            this.grpKhachHang.Controls.Add(this.lblTenKhachHang);
            this.grpKhachHang.Controls.Add(this.txtMaKhachHang);
            this.grpKhachHang.Controls.Add(this.lblMaKhachHang);
            this.grpKhachHang.Controls.Add(this.cmbPhong);
            this.grpKhachHang.Controls.Add(this.lblPhong);
            this.grpKhachHang.Controls.Add(this.dgvKhachHang);
            this.grpKhachHang.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKhachHang.Location = new System.Drawing.Point(490, 13);
            this.grpKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKhachHang.Size = new System.Drawing.Size(618, 520);
            this.grpKhachHang.TabIndex = 2;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "Quản lý khách hàng";
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(483, 125);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(90, 44);
            this.btnXoaKH.TabIndex = 13;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(387, 160);
            this.btnSuaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(90, 44);
            this.btnSuaKH.TabIndex = 12;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(387, 99);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(90, 44);
            this.btnThemKH.TabIndex = 11;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(135, 188);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(224, 29);
            this.txtDiaChi.TabIndex = 10;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(22, 191);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 21);
            this.lblDiaChi.TabIndex = 9;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(135, 138);
            this.txtSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(224, 29);
            this.txtSoDienThoai.TabIndex = 8;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(22, 141);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(84, 21);
            this.lblSoDienThoai.TabIndex = 7;
            this.lblSoDienThoai.Text = "Điện thoại:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(135, 88);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(224, 29);
            this.txtTenKhachHang.TabIndex = 6;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(22, 91);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(83, 21);
            this.lblTenKhachHang.TabIndex = 5;
            this.lblTenKhachHang.Text = "Họ tên KH:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(135, 38);
            this.txtMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(224, 29);
            this.txtMaKhachHang.TabIndex = 4;
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Location = new System.Drawing.Point(22, 41);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(59, 21);
            this.lblMaKhachHang.TabIndex = 3;
            this.lblMaKhachHang.Text = "Mã KH:";
            // 
            // cmbPhong
            // 
            this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhong.Location = new System.Drawing.Point(451, 41);
            this.cmbPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPhong.Name = "cmbPhong";
            this.cmbPhong.Size = new System.Drawing.Size(122, 29);
            this.cmbPhong.TabIndex = 2;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(373, 44);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(58, 21);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "Phòng:";
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerID,
            this.colFullName,
            this.colPhone,
            this.colAddress,
            this.colRoomName});
            this.dgvKhachHang.Location = new System.Drawing.Point(26, 236);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersWidth = 62;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(551, 257);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // colCustomerID
            // 
            this.colCustomerID.HeaderText = "Mã KH";
            this.colCustomerID.MinimumWidth = 8;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.ReadOnly = true;
            this.colCustomerID.Width = 92;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Họ tên";
            this.colFullName.MinimumWidth = 8;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 92;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Điện thoại";
            this.colPhone.MinimumWidth = 8;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Width = 117;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Địa chỉ";
            this.colAddress.MinimumWidth = 8;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 93;
            // 
            // colRoomName
            // 
            this.colRoomName.HeaderText = "Phòng";
            this.colRoomName.MinimumWidth = 8;
            this.colRoomName.Name = "colRoomName";
            this.colRoomName.ReadOnly = true;
            this.colRoomName.Width = 91;
            // 
            // frmPhongKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 556);
            this.Controls.Add(this.grpKhachHang);
            this.Controls.Add(this.grpPhong);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhongKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng & Khách hàng";
            this.Load += new System.EventHandler(this.frmPhongKH_Load);
            this.grpPhong.ResumeLayout(false);
            this.grpPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnSuaPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
        // XÓA: private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNameKH;
    }
}