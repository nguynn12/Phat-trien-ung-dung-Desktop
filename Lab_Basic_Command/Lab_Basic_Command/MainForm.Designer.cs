namespace Lab_Basic_Command
{
    partial class MainForm
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
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.MaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupboxTable = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtSucChua = new System.Windows.Forms.TextBox();
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.lblMaBan = new System.Windows.Forms.Label();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.btnCapNhatBan = new System.Windows.Forms.Button();
            this.btnLayThongTinBan = new System.Windows.Forms.Button();
            this.btnXemHoaDon = new System.Windows.Forms.Button();
            this.contextMenuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmXoaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXemDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXemNhatKy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaBan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.groupboxTable.SuspendLayout();
            this.contextMenuTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBan,
            this.TenBan,
            this.TrangThai,
            this.SucChua});
            this.dgvTable.ContextMenuStrip = this.contextMenuTable;
            this.dgvTable.Location = new System.Drawing.Point(12, 248);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 62;
            this.dgvTable.RowTemplate.Height = 28;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(776, 304);
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            this.dgvTable.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_CellMouseDown);
            // 
            // MaBan
            // 
            this.MaBan.DataPropertyName = "ID";
            this.MaBan.HeaderText = "Mã bàn";
            this.MaBan.MinimumWidth = 8;
            this.MaBan.Name = "MaBan";
            this.MaBan.Width = 150;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TableName";
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.MinimumWidth = 8;
            this.TenBan.Name = "TenBan";
            this.TenBan.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "Status";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 150;
            // 
            // SucChua
            // 
            this.SucChua.DataPropertyName = "Capacity";
            this.SucChua.HeaderText = "Sức chứa";
            this.SucChua.MinimumWidth = 8;
            this.SucChua.Name = "SucChua";
            this.SucChua.Width = 150;
            // 
            // groupboxTable
            // 
            this.groupboxTable.Controls.Add(this.cboTrangThai);
            this.groupboxTable.Controls.Add(this.lblSucChua);
            this.groupboxTable.Controls.Add(this.lblTrangThai);
            this.groupboxTable.Controls.Add(this.txtTenBan);
            this.groupboxTable.Controls.Add(this.txtSucChua);
            this.groupboxTable.Controls.Add(this.txtMaBan);
            this.groupboxTable.Controls.Add(this.lblTenBan);
            this.groupboxTable.Controls.Add(this.lblMaBan);
            this.groupboxTable.Location = new System.Drawing.Point(12, 12);
            this.groupboxTable.Name = "groupboxTable";
            this.groupboxTable.Size = new System.Drawing.Size(776, 146);
            this.groupboxTable.TabIndex = 1;
            this.groupboxTable.TabStop = false;
            this.groupboxTable.Text = "Bàn";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(464, 22);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(184, 28);
            this.cboTrangThai.TabIndex = 3;
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Location = new System.Drawing.Point(367, 85);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(76, 20);
            this.lblSucChua.TabIndex = 2;
            this.lblSucChua.Text = "Sức chứa";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(367, 30);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(80, 20);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(104, 82);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(184, 26);
            this.txtTenBan.TabIndex = 2;
            // 
            // txtSucChua
            // 
            this.txtSucChua.Location = new System.Drawing.Point(464, 82);
            this.txtSucChua.Name = "txtSucChua";
            this.txtSucChua.Size = new System.Drawing.Size(184, 26);
            this.txtSucChua.TabIndex = 2;
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(104, 29);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.Size = new System.Drawing.Size(184, 26);
            this.txtMaBan.TabIndex = 2;
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Location = new System.Drawing.Point(27, 88);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(67, 20);
            this.lblTenBan.TabIndex = 2;
            this.lblTenBan.Text = "Tên bàn";
            // 
            // lblMaBan
            // 
            this.lblMaBan.AutoSize = true;
            this.lblMaBan.Location = new System.Drawing.Point(27, 32);
            this.lblMaBan.Name = "lblMaBan";
            this.lblMaBan.Size = new System.Drawing.Size(62, 20);
            this.lblMaBan.TabIndex = 2;
            this.lblMaBan.Text = "Mã bàn";
            // 
            // btnThemBan
            // 
            this.btnThemBan.Location = new System.Drawing.Point(156, 173);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(124, 36);
            this.btnThemBan.TabIndex = 2;
            this.btnThemBan.Text = "Thêm bàn";
            this.btnThemBan.UseVisualStyleBackColor = true;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // btnCapNhatBan
            // 
            this.btnCapNhatBan.Location = new System.Drawing.Point(326, 173);
            this.btnCapNhatBan.Name = "btnCapNhatBan";
            this.btnCapNhatBan.Size = new System.Drawing.Size(129, 36);
            this.btnCapNhatBan.TabIndex = 3;
            this.btnCapNhatBan.Text = "Cập nhật bàn";
            this.btnCapNhatBan.UseVisualStyleBackColor = true;
            this.btnCapNhatBan.Click += new System.EventHandler(this.btnCapNhatBan_Click);
            // 
            // btnLayThongTinBan
            // 
            this.btnLayThongTinBan.Location = new System.Drawing.Point(12, 173);
            this.btnLayThongTinBan.Name = "btnLayThongTinBan";
            this.btnLayThongTinBan.Size = new System.Drawing.Size(117, 36);
            this.btnLayThongTinBan.TabIndex = 4;
            this.btnLayThongTinBan.Text = "Lấy thông tin";
            this.btnLayThongTinBan.UseVisualStyleBackColor = true;
            this.btnLayThongTinBan.Click += new System.EventHandler(this.btnLayThongTinBan_Click);
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.Location = new System.Drawing.Point(500, 173);
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.Size = new System.Drawing.Size(130, 36);
            this.btnXemHoaDon.TabIndex = 5;
            this.btnXemHoaDon.Text = "Xem hóa đơn";
            this.btnXemHoaDon.UseVisualStyleBackColor = true;
            this.btnXemHoaDon.Click += new System.EventHandler(this.btnXemHoaDon_Click);
            // 
            // contextMenuTable
            // 
            this.contextMenuTable.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXoaBan,
            this.tsmXemDanhMuc,
            this.tsmXemNhatKy});
            this.contextMenuTable.Name = "contextMenuTable";
            this.contextMenuTable.Size = new System.Drawing.Size(277, 133);
            this.contextMenuTable.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuTable_ItemClicked);
            // 
            // tsmXoaBan
            // 
            this.tsmXoaBan.Name = "tsmXoaBan";
            this.tsmXoaBan.Size = new System.Drawing.Size(276, 32);
            this.tsmXoaBan.Text = "Xóa bàn";
            // 
            // tsmXemDanhMuc
            // 
            this.tsmXemDanhMuc.Name = "tsmXemDanhMuc";
            this.tsmXemDanhMuc.Size = new System.Drawing.Size(276, 32);
            this.tsmXemDanhMuc.Text = "Xem danh mục hóa đơn";
            // 
            // tsmXemNhatKy
            // 
            this.tsmXemNhatKy.Name = "tsmXemNhatKy";
            this.tsmXemNhatKy.Size = new System.Drawing.Size(276, 32);
            this.tsmXemNhatKy.Text = "Xem nhật ký hóa đơn";
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.Location = new System.Drawing.Point(675, 173);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(113, 36);
            this.btnXoaBan.TabIndex = 6;
            this.btnXoaBan.Text = "Xóa bàn";
            this.btnXoaBan.UseVisualStyleBackColor = true;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnXemHoaDon);
            this.Controls.Add(this.btnLayThongTinBan);
            this.Controls.Add(this.btnCapNhatBan);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.groupboxTable);
            this.Controls.Add(this.dgvTable);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.groupboxTable.ResumeLayout(false);
            this.groupboxTable.PerformLayout();
            this.contextMenuTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.GroupBox groupboxTable;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label lblMaBan;
        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtSucChua;
        private System.Windows.Forms.Button btnThemBan;
        private System.Windows.Forms.Button btnCapNhatBan;
        private System.Windows.Forms.Button btnLayThongTinBan;
        private System.Windows.Forms.Button btnXemHoaDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuTable;
        private System.Windows.Forms.ToolStripMenuItem tsmXoaBan;
        private System.Windows.Forms.ToolStripMenuItem tsmXemDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tsmXemNhatKy;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChua;
    }
}