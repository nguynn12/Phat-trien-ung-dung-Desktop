namespace QLDVKS_Nhom6
{
    partial class frmChinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimDV = new System.Windows.Forms.Button();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.cboLocDV = new System.Windows.Forms.ComboBox();
            this.dgvKHSDDichVu = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDVSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhToan = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblTieuDeDV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupboxDV = new System.Windows.Forms.GroupBox();
            this.cboLoaiDV = new System.Windows.Forms.ComboBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoaiDV = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.msSapXepDV = new System.Windows.Forms.MenuStrip();
            this.tsmSapXepDV = new System.Windows.Forms.ToolStripMenuItem();
            this.theoTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.rdtheoTenDV = new System.Windows.Forms.RadioButton();
            this.rdTheoTenKH = new System.Windows.Forms.RadioButton();
            this.rdTheoMaKH = new System.Windows.Forms.RadioButton();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.msSapXepDVSD = new System.Windows.Forms.MenuStrip();
            this.tsmSapXepSDDV = new System.Windows.Forms.ToolStripMenuItem();
            this.theoGiáToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.theoTổngTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoSốLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHSDDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupboxDV.SuspendLayout();
            this.msSapXepDV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.msSapXepDVSD.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.ServiceName,
            this.TypeName,
            this.Price});
            this.dgvDichVu.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDichVu.Location = new System.Drawing.Point(12, 270);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 62;
            this.dgvDichVu.Size = new System.Drawing.Size(570, 371);
            this.dgvDichVu.TabIndex = 19;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // ServiceID
            // 
            this.ServiceID.DataPropertyName = "ServiceID";
            this.ServiceID.HeaderText = "Mã dịch vụ";
            this.ServiceID.MinimumWidth = 8;
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            this.ServiceID.Width = 122;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Tên dịch vụ";
            this.ServiceName.MinimumWidth = 8;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Width = 123;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "Loại";
            this.TypeName.MinimumWidth = 8;
            this.TypeName.Name = "TypeName";
            this.TypeName.Width = 75;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá dịch vụ";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.Width = 123;
            // 
            // btnTimDV
            // 
            this.btnTimDV.Location = new System.Drawing.Point(344, 40);
            this.btnTimDV.Name = "btnTimDV";
            this.btnTimDV.Size = new System.Drawing.Size(97, 51);
            this.btnTimDV.TabIndex = 20;
            this.btnTimDV.Text = "Tìm";
            this.btnTimDV.UseVisualStyleBackColor = true;
            this.btnTimDV.Click += new System.EventHandler(this.btnTimDV_Click);
            // 
            // txtTenDV
            // 
            this.txtTenDV.BackColor = System.Drawing.Color.White;
            this.txtTenDV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTenDV.Location = new System.Drawing.Point(118, 82);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(192, 29);
            this.txtTenDV.TabIndex = 2;
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Location = new System.Drawing.Point(24, 86);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(87, 21);
            this.lblTenDV.TabIndex = 9;
            this.lblTenDV.Text = "Tên dịch vụ";
            // 
            // cboLocDV
            // 
            this.cboLocDV.FormattingEnabled = true;
            this.cboLocDV.Location = new System.Drawing.Point(344, 172);
            this.cboLocDV.Name = "cboLocDV";
            this.cboLocDV.Size = new System.Drawing.Size(210, 29);
            this.cboLocDV.TabIndex = 26;
            this.cboLocDV.Text = "Lọc dịch vụ";
            this.cboLocDV.SelectedIndexChanged += new System.EventHandler(this.cboLocDV_SelectedIndexChanged);
            // 
            // dgvKHSDDichVu
            // 
            this.dgvKHSDDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKHSDDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKHSDDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKHSDDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.TenKH,
            this.LoaiDVSD,
            this.dataGridViewTextBoxColumn2,
            this.SoLuongDV,
            this.dataGridViewTextBoxColumn3,
            this.NgaySD,
            this.TongTien,
            this.ThanhToan});
            this.dgvKHSDDichVu.Location = new System.Drawing.Point(25, 270);
            this.dgvKHSDDichVu.Name = "dgvKHSDDichVu";
            this.dgvKHSDDichVu.RowHeadersWidth = 30;
            this.dgvKHSDDichVu.Size = new System.Drawing.Size(859, 371);
            this.dgvKHSDDichVu.TabIndex = 19;
            this.dgvKHSDDichVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKHSDDichVu_CellContentClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "BillID";
            this.MaHD.HeaderText = "Mã HD";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 94;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "CustomerID";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 92;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "FullName";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.MinimumWidth = 8;
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 93;
            // 
            // LoaiDVSD
            // 
            this.LoaiDVSD.DataPropertyName = "TypeName";
            this.LoaiDVSD.HeaderText = "Loại";
            this.LoaiDVSD.MinimumWidth = 8;
            this.LoaiDVSD.Name = "LoaiDVSD";
            this.LoaiDVSD.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ServiceName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dịch vụ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 98;
            // 
            // SoLuongDV
            // 
            this.SoLuongDV.DataPropertyName = "Quantity";
            this.SoLuongDV.HeaderText = "Số lượng";
            this.SoLuongDV.MinimumWidth = 8;
            this.SoLuongDV.Name = "SoLuongDV";
            this.SoLuongDV.Width = 109;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // NgaySD
            // 
            this.NgaySD.DataPropertyName = "CheckInDate";
            this.NgaySD.HeaderText = "Ngày";
            this.NgaySD.MinimumWidth = 8;
            this.NgaySD.Name = "NgaySD";
            this.NgaySD.Width = 83;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "Amount";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            this.TongTien.Width = 111;
            // 
            // ThanhToan
            // 
            this.ThanhToan.HeaderText = "Thanh toán";
            this.ThanhToan.MinimumWidth = 8;
            this.ThanhToan.Name = "ThanhToan";
            this.ThanhToan.Text = "Thanh toán ";
            this.ThanhToan.Width = 94;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(532, 14);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(247, 20);
            this.lblTieuDe.TabIndex = 27;
            this.lblTieuDe.Text = "QUẢN LÝ DỊCH VỤ KHÁCH SẠN";
            // 
            // lblTieuDeDV
            // 
            this.lblTieuDeDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeDV.Location = new System.Drawing.Point(184, 235);
            this.lblTieuDeDV.Name = "lblTieuDeDV";
            this.lblTieuDeDV.Size = new System.Drawing.Size(245, 27);
            this.lblTieuDeDV.TabIndex = 27;
            this.lblTieuDeDV.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG SỬ DỤNG DỊCH VỤ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupboxDV);
            this.splitContainer1.Panel1.Controls.Add(this.lblTieuDeDV);
            this.splitContainer1.Panel1.Controls.Add(this.dgvDichVu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvKHSDDichVu);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1508, 657);
            this.splitContainer1.SplitterDistance = 608;
            this.splitContainer1.TabIndex = 28;
            // 
            // groupboxDV
            // 
            this.groupboxDV.Controls.Add(this.cboLoaiDV);
            this.groupboxDV.Controls.Add(this.btnThemDV);
            this.groupboxDV.Controls.Add(this.btnSuaDV);
            this.groupboxDV.Controls.Add(this.btnTimDV);
            this.groupboxDV.Controls.Add(this.lblMaDV);
            this.groupboxDV.Controls.Add(this.label2);
            this.groupboxDV.Controls.Add(this.lblLoaiDV);
            this.groupboxDV.Controls.Add(this.lblTenDV);
            this.groupboxDV.Controls.Add(this.txtMaDV);
            this.groupboxDV.Controls.Add(this.txtGia);
            this.groupboxDV.Controls.Add(this.txtTenDV);
            this.groupboxDV.Controls.Add(this.cboLocDV);
            this.groupboxDV.Controls.Add(this.msSapXepDV);
            this.groupboxDV.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxDV.Location = new System.Drawing.Point(12, 14);
            this.groupboxDV.Name = "groupboxDV";
            this.groupboxDV.Size = new System.Drawing.Size(570, 218);
            this.groupboxDV.TabIndex = 28;
            this.groupboxDV.TabStop = false;
            this.groupboxDV.Text = "Thông tin dịch vụ";
            // 
            // cboLoaiDV
            // 
            this.cboLoaiDV.FormattingEnabled = true;
            this.cboLoaiDV.Location = new System.Drawing.Point(118, 128);
            this.cboLoaiDV.Name = "cboLoaiDV";
            this.cboLoaiDV.Size = new System.Drawing.Size(192, 29);
            this.cboLoaiDV.TabIndex = 27;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(459, 40);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(95, 51);
            this.btnThemDV.TabIndex = 20;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.Location = new System.Drawing.Point(459, 105);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.Size = new System.Drawing.Size(95, 51);
            this.btnSuaDV.TabIndex = 20;
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.UseVisualStyleBackColor = true;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Location = new System.Drawing.Point(28, 40);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(86, 21);
            this.lblMaDV.TabIndex = 9;
            this.lblMaDV.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Giá dịch vụ";
            // 
            // lblLoaiDV
            // 
            this.lblLoaiDV.AutoSize = true;
            this.lblLoaiDV.Location = new System.Drawing.Point(22, 134);
            this.lblLoaiDV.Name = "lblLoaiDV";
            this.lblLoaiDV.Size = new System.Drawing.Size(93, 21);
            this.lblLoaiDV.TabIndex = 9;
            this.lblLoaiDV.Text = "Loại dịch vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaDV.Location = new System.Drawing.Point(118, 36);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(192, 29);
            this.txtMaDV.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGia.Location = new System.Drawing.Point(118, 176);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(192, 29);
            this.txtGia.TabIndex = 2;
            // 
            // msSapXepDV
            // 
            this.msSapXepDV.Dock = System.Windows.Forms.DockStyle.None;
            this.msSapXepDV.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msSapXepDV.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msSapXepDV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSapXepDV});
            this.msSapXepDV.Location = new System.Drawing.Point(344, 108);
            this.msSapXepDV.Name = "msSapXepDV";
            this.msSapXepDV.Size = new System.Drawing.Size(102, 36);
            this.msSapXepDV.TabIndex = 28;
            this.msSapXepDV.Text = "menuStrip1";
            // 
            // tsmSapXepDV
            // 
            this.tsmSapXepDV.BackColor = System.Drawing.Color.White;
            this.tsmSapXepDV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoTênToolStripMenuItem,
            this.theoGiáToolStripMenuItem});
            this.tsmSapXepDV.Name = "tsmSapXepDV";
            this.tsmSapXepDV.Size = new System.Drawing.Size(91, 30);
            this.tsmSapXepDV.Text = "Sắp xếp";
            // 
            // theoTênToolStripMenuItem
            // 
            this.theoTênToolStripMenuItem.Name = "theoTênToolStripMenuItem";
            this.theoTênToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.theoTênToolStripMenuItem.Text = "Theo tên";
            this.theoTênToolStripMenuItem.Click += new System.EventHandler(this.theoTênToolStripMenuItem_Click);
            // 
            // theoGiáToolStripMenuItem
            // 
            this.theoGiáToolStripMenuItem.Name = "theoGiáToolStripMenuItem";
            this.theoGiáToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.theoGiáToolStripMenuItem.Text = "Theo giá";
            this.theoGiáToolStripMenuItem.Click += new System.EventHandler(this.theoGiáToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.rdtheoTenDV);
            this.groupBox1.Controls.Add(this.rdTheoTenKH);
            this.groupBox1.Controls.Add(this.rdTheoMaKH);
            this.groupBox1.Controls.Add(this.lblTim);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.msSapXepDVSD);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 218);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng sử dụng dịch vụ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(156, 152);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 40);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(378, 112);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(87, 40);
            this.btnTim.TabIndex = 29;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // rdtheoTenDV
            // 
            this.rdtheoTenDV.AutoSize = true;
            this.rdtheoTenDV.Location = new System.Drawing.Point(316, 53);
            this.rdtheoTenDV.Name = "rdtheoTenDV";
            this.rdtheoTenDV.Size = new System.Drawing.Size(149, 25);
            this.rdtheoTenDV.TabIndex = 30;
            this.rdtheoTenDV.Text = "Theo tên dịch vụ";
            this.rdtheoTenDV.UseVisualStyleBackColor = true;
            this.rdtheoTenDV.CheckedChanged += new System.EventHandler(this.rdtheoTenDV_CheckedChanged);
            // 
            // rdTheoTenKH
            // 
            this.rdTheoTenKH.AutoSize = true;
            this.rdTheoTenKH.Location = new System.Drawing.Point(174, 53);
            this.rdTheoTenKH.Name = "rdTheoTenKH";
            this.rdTheoTenKH.Size = new System.Drawing.Size(119, 25);
            this.rdTheoTenKH.TabIndex = 30;
            this.rdTheoTenKH.Text = "Theo tên KH";
            this.rdTheoTenKH.UseVisualStyleBackColor = true;
            this.rdTheoTenKH.CheckedChanged += new System.EventHandler(this.rdTheoTenKH_CheckedChanged);
            // 
            // rdTheoMaKH
            // 
            this.rdTheoMaKH.AutoSize = true;
            this.rdTheoMaKH.Checked = true;
            this.rdTheoMaKH.Location = new System.Drawing.Point(42, 53);
            this.rdTheoMaKH.Name = "rdTheoMaKH";
            this.rdTheoMaKH.Size = new System.Drawing.Size(119, 25);
            this.rdTheoMaKH.TabIndex = 30;
            this.rdTheoMaKH.TabStop = true;
            this.rdTheoMaKH.Text = "Theo mã KH";
            this.rdTheoMaKH.UseVisualStyleBackColor = true;
            this.rdTheoMaKH.CheckedChanged += new System.EventHandler(this.rdTheoMaKH_CheckedChanged);
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(38, 120);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(56, 21);
            this.lblTim.TabIndex = 9;
            this.lblTim.Text = "Mã KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaKH.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMaKH.Location = new System.Drawing.Point(156, 117);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(192, 29);
            this.txtMaKH.TabIndex = 2;
            // 
            // msSapXepDVSD
            // 
            this.msSapXepDVSD.Dock = System.Windows.Forms.DockStyle.None;
            this.msSapXepDVSD.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msSapXepDVSD.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msSapXepDVSD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSapXepSDDV});
            this.msSapXepDVSD.Location = new System.Drawing.Point(33, 158);
            this.msSapXepDVSD.Name = "msSapXepDVSD";
            this.msSapXepDVSD.Size = new System.Drawing.Size(102, 36);
            this.msSapXepDVSD.TabIndex = 28;
            this.msSapXepDVSD.Text = "menuStrip2";
            // 
            // tsmSapXepSDDV
            // 
            this.tsmSapXepSDDV.BackColor = System.Drawing.Color.White;
            this.tsmSapXepSDDV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoGiáToolStripMenuItem1,
            this.theoTổngTiềnToolStripMenuItem,
            this.theoNgàyToolStripMenuItem,
            this.theoSốLượngToolStripMenuItem});
            this.tsmSapXepSDDV.Name = "tsmSapXepSDDV";
            this.tsmSapXepSDDV.Size = new System.Drawing.Size(91, 30);
            this.tsmSapXepSDDV.Text = "Sắp xếp";
            // 
            // theoGiáToolStripMenuItem1
            // 
            this.theoGiáToolStripMenuItem1.Name = "theoGiáToolStripMenuItem1";
            this.theoGiáToolStripMenuItem1.Size = new System.Drawing.Size(230, 34);
            this.theoGiáToolStripMenuItem1.Text = "Theo giá";
            this.theoGiáToolStripMenuItem1.Click += new System.EventHandler(this.theoGiáToolStripMenuItem1_Click);
            // 
            // theoTổngTiềnToolStripMenuItem
            // 
            this.theoTổngTiềnToolStripMenuItem.Name = "theoTổngTiềnToolStripMenuItem";
            this.theoTổngTiềnToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.theoTổngTiềnToolStripMenuItem.Text = "Theo tổng tiền";
            this.theoTổngTiềnToolStripMenuItem.Click += new System.EventHandler(this.theoTổngTiềnToolStripMenuItem_Click);
            // 
            // theoNgàyToolStripMenuItem
            // 
            this.theoNgàyToolStripMenuItem.Name = "theoNgàyToolStripMenuItem";
            this.theoNgàyToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.theoNgàyToolStripMenuItem.Text = "Theo ngày";
            this.theoNgàyToolStripMenuItem.Click += new System.EventHandler(this.theoNgàyToolStripMenuItem_Click);
            // 
            // theoSốLượngToolStripMenuItem
            // 
            this.theoSốLượngToolStripMenuItem.Name = "theoSốLượngToolStripMenuItem";
            this.theoSốLượngToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.theoSốLượngToolStripMenuItem.Text = "Theo số lượng";
            this.theoSốLượngToolStripMenuItem.Click += new System.EventHandler(this.theoSốLượngToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 69);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 657);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msSapXepDVSD;
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dịch vụ khách sạn";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKHSDDichVu)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupboxDV.ResumeLayout(false);
            this.groupboxDV.PerformLayout();
            this.msSapXepDV.ResumeLayout(false);
            this.msSapXepDV.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.msSapXepDVSD.ResumeLayout(false);
            this.msSapXepDVSD.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Button btnTimDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.ComboBox cboLocDV;
        private System.Windows.Forms.DataGridView dgvKHSDDichVu;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTieuDeDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupboxDV;
        private System.Windows.Forms.ComboBox cboLoaiDV;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLoaiDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.MenuStrip msSapXepDV;
        private System.Windows.Forms.ToolStripMenuItem tsmSapXepDV;
        private System.Windows.Forms.ToolStripMenuItem theoTênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoGiáToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msSapXepDVSD;
        private System.Windows.Forms.ToolStripMenuItem tsmSapXepSDDV;
        private System.Windows.Forms.ToolStripMenuItem theoGiáToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem theoTổngTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoSốLượngToolStripMenuItem;
        // XÓA (REQUEST 4): Xóa 3 dòng khai báo 'msLocDVSD', 'lọcToolStripMenuItem', 'theoNgàyToolStripMenuItem1'
        private System.Windows.Forms.RadioButton rdtheoTenDV;
        private System.Windows.Forms.RadioButton rdTheoTenKH;
        private System.Windows.Forms.RadioButton rdTheoMaKH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDVSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewButtonColumn ThanhToan;
        // XÓA: Xóa 'MaHD'
    }
}