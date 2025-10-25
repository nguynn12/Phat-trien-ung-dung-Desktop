namespace Lab_Basic_Command
{
    partial class AccountManager
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
            this.groupboxTaiKhoan = new System.Windows.Forms.GroupBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.btnLayThongTin = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.btnCapNhatTaiKhoan = new System.Windows.Forms.Button();
            this.btnResetMatKhau = new System.Windows.Forms.Button();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.contextMenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchVaiTròToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupboxTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.contextMenuAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxTaiKhoan
            // 
            this.groupboxTaiKhoan.Controls.Add(this.dtpNgayTao);
            this.groupboxTaiKhoan.Controls.Add(this.txtMatKhau);
            this.groupboxTaiKhoan.Controls.Add(this.txtSoDienThoai);
            this.groupboxTaiKhoan.Controls.Add(this.txtHoVaTen);
            this.groupboxTaiKhoan.Controls.Add(this.txtEmail);
            this.groupboxTaiKhoan.Controls.Add(this.txtTenDangNhap);
            this.groupboxTaiKhoan.Controls.Add(this.lblNgayTao);
            this.groupboxTaiKhoan.Controls.Add(this.lblMatKhau);
            this.groupboxTaiKhoan.Controls.Add(this.lblSoDienThoai);
            this.groupboxTaiKhoan.Controls.Add(this.lblHoVaTen);
            this.groupboxTaiKhoan.Controls.Add(this.lblEmail);
            this.groupboxTaiKhoan.Controls.Add(this.lblTenDangNhap);
            this.groupboxTaiKhoan.Location = new System.Drawing.Point(12, 12);
            this.groupboxTaiKhoan.Name = "groupboxTaiKhoan";
            this.groupboxTaiKhoan.Size = new System.Drawing.Size(776, 171);
            this.groupboxTaiKhoan.TabIndex = 0;
            this.groupboxTaiKhoan.TabStop = false;
            this.groupboxTaiKhoan.Text = "Tài khoản";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(506, 126);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(196, 26);
            this.dtpNgayTao.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(152, 125);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(196, 26);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(506, 79);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(196, 26);
            this.txtSoDienThoai.TabIndex = 1;
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(152, 79);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(196, 26);
            this.txtHoVaTen.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(506, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 26);
            this.txtEmail.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(152, 33);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(196, 26);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(384, 131);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(72, 20);
            this.lblNgayTao.TabIndex = 1;
            this.lblNgayTao.Text = "Ngày tạo";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(30, 131);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(75, 20);
            this.lblMatKhau.TabIndex = 1;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(384, 85);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(102, 20);
            this.lblSoDienThoai.TabIndex = 1;
            this.lblSoDienThoai.Text = "Số điện thoại";
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Location = new System.Drawing.Point(30, 85);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(77, 20);
            this.lblHoVaTen.TabIndex = 1;
            this.lblHoVaTen.Text = "Họ và tên";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(384, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(30, 39);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(116, 20);
            this.lblTenDangNhap.TabIndex = 1;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // btnLayThongTin
            // 
            this.btnLayThongTin.Location = new System.Drawing.Point(12, 198);
            this.btnLayThongTin.Name = "btnLayThongTin";
            this.btnLayThongTin.Size = new System.Drawing.Size(126, 38);
            this.btnLayThongTin.TabIndex = 1;
            this.btnLayThongTin.Text = "Lấy thông tin";
            this.btnLayThongTin.UseVisualStyleBackColor = true;
            this.btnLayThongTin.Click += new System.EventHandler(this.btnLayThongTin_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(213, 198);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(126, 38);
            this.btnThemTaiKhoan.TabIndex = 1;
            this.btnThemTaiKhoan.Text = "Thêm tài khoản";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // btnCapNhatTaiKhoan
            // 
            this.btnCapNhatTaiKhoan.Location = new System.Drawing.Point(414, 198);
            this.btnCapNhatTaiKhoan.Name = "btnCapNhatTaiKhoan";
            this.btnCapNhatTaiKhoan.Size = new System.Drawing.Size(156, 38);
            this.btnCapNhatTaiKhoan.TabIndex = 1;
            this.btnCapNhatTaiKhoan.Text = "Cập nhật tài khoản";
            this.btnCapNhatTaiKhoan.UseVisualStyleBackColor = true;
            this.btnCapNhatTaiKhoan.Click += new System.EventHandler(this.btnCapNhatTaiKhoan_Click);
            // 
            // btnResetMatKhau
            // 
            this.btnResetMatKhau.Location = new System.Drawing.Point(645, 198);
            this.btnResetMatKhau.Name = "btnResetMatKhau";
            this.btnResetMatKhau.Size = new System.Drawing.Size(141, 38);
            this.btnResetMatKhau.TabIndex = 1;
            this.btnResetMatKhau.Text = "Reset mật khẩu";
            this.btnResetMatKhau.UseVisualStyleBackColor = true;
            this.btnResetMatKhau.Click += new System.EventHandler(this.btnResetMatKhau_Click);
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiKhoan,
            this.HoVaTen,
            this.Mail,
            this.SoDienThoai,
            this.NgayTao,
            this.TinhTrang});
            this.dgvAccount.ContextMenuStrip = this.contextMenuAccount;
            this.dgvAccount.Location = new System.Drawing.Point(12, 260);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.RowTemplate.Height = 28;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(776, 289);
            this.dgvAccount.TabIndex = 2;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            this.dgvAccount.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_CellMouseClick);
            // 
            // contextMenuAccount
            // 
            this.contextMenuAccount.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaTàiKhoảnToolStripMenuItem,
            this.xemDanhSáchVaiTròToolStripMenuItem});
            this.contextMenuAccount.Name = "contextMenuStrip1";
            this.contextMenuAccount.Size = new System.Drawing.Size(261, 68);
            // 
            // xóaTàiKhoảnToolStripMenuItem
            // 
            this.xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
            this.xóaTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.xóaTàiKhoảnToolStripMenuItem.Text = "Xóa tài khoản";
            this.xóaTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.xóaTàiKhoảnToolStripMenuItem_Click);
            // 
            // xemDanhSáchVaiTròToolStripMenuItem
            // 
            this.xemDanhSáchVaiTròToolStripMenuItem.Name = "xemDanhSáchVaiTròToolStripMenuItem";
            this.xemDanhSáchVaiTròToolStripMenuItem.Size = new System.Drawing.Size(260, 32);
            this.xemDanhSáchVaiTròToolStripMenuItem.Text = "Xem danh sách vai trò";
            this.xemDanhSáchVaiTròToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchVaiTròToolStripMenuItem_Click);
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.DataPropertyName = "AccountName";
            this.TenTaiKhoan.HeaderText = "Tên tài khoản";
            this.TenTaiKhoan.MinimumWidth = 8;
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.Width = 141;
            // 
            // HoVaTen
            // 
            this.HoVaTen.DataPropertyName = "FullName";
            this.HoVaTen.HeaderText = "Họ và tên";
            this.HoVaTen.MinimumWidth = 8;
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.Width = 113;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Email";
            this.Mail.HeaderText = "Email";
            this.Mail.MinimumWidth = 8;
            this.Mail.Name = "Mail";
            this.Mail.Width = 84;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "Tell";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.MinimumWidth = 8;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 138;
            // 
            // NgayTao
            // 
            this.NgayTao.DataPropertyName = "DateCreated";
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 8;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.Width = 108;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "Stat";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 116;
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.btnResetMatKhau);
            this.Controls.Add(this.btnCapNhatTaiKhoan);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.btnLayThongTin);
            this.Controls.Add(this.groupboxTaiKhoan);
            this.Name = "AccountManager";
            this.Text = "AccountManager";
            this.groupboxTaiKhoan.ResumeLayout(false);
            this.groupboxTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.contextMenuAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxTaiKhoan;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLayThongTin;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Button btnCapNhatTaiKhoan;
        private System.Windows.Forms.Button btnResetMatKhau;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuAccount;
        private System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchVaiTròToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}