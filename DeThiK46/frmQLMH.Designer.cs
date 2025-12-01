namespace DeThiK46
{
    partial class frmQLMH
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
            this.groupboxCTDT = new System.Windows.Forms.GroupBox();
            this.rd2020 = new System.Windows.Forms.RadioButton();
            this.rd2017 = new System.Windows.Forms.RadioButton();
            this.rd2015 = new System.Windows.Forms.RadioButton();
            this.rdTatCa = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupboxTimKiem = new System.Windows.Forms.GroupBox();
            this.rdTheoMa = new System.Windows.Forms.RadioButton();
            this.rdTheoSTC = new System.Windows.Forms.RadioButton();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBoxDSMH = new System.Windows.Forms.GroupBox();
            this.cmsThaoTacMH = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXemDS = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.groupboxCTDT.SuspendLayout();
            this.groupboxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.groupBoxDSMH.SuspendLayout();
            this.cmsThaoTacMH.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxCTDT
            // 
            this.groupboxCTDT.Controls.Add(this.rd2020);
            this.groupboxCTDT.Controls.Add(this.rd2017);
            this.groupboxCTDT.Controls.Add(this.rd2015);
            this.groupboxCTDT.Controls.Add(this.rdTatCa);
            this.groupboxCTDT.Location = new System.Drawing.Point(67, 21);
            this.groupboxCTDT.Name = "groupboxCTDT";
            this.groupboxCTDT.Size = new System.Drawing.Size(983, 100);
            this.groupboxCTDT.TabIndex = 0;
            this.groupboxCTDT.TabStop = false;
            this.groupboxCTDT.Text = "Chọn chương trình đào tạo";
            // 
            // rd2020
            // 
            this.rd2020.AutoSize = true;
            this.rd2020.Location = new System.Drawing.Point(783, 40);
            this.rd2020.Name = "rd2020";
            this.rd2020.Size = new System.Drawing.Size(70, 24);
            this.rd2020.TabIndex = 0;
            this.rd2020.Text = "2020";
            this.rd2020.UseVisualStyleBackColor = true;
            this.rd2020.CheckedChanged += new System.EventHandler(this.rd2020_CheckedChanged);
            // 
            // rd2017
            // 
            this.rd2017.AutoSize = true;
            this.rd2017.Location = new System.Drawing.Point(536, 40);
            this.rd2017.Name = "rd2017";
            this.rd2017.Size = new System.Drawing.Size(70, 24);
            this.rd2017.TabIndex = 0;
            this.rd2017.Text = "2017";
            this.rd2017.UseVisualStyleBackColor = true;
            this.rd2017.CheckedChanged += new System.EventHandler(this.rd2017_CheckedChanged);
            // 
            // rd2015
            // 
            this.rd2015.AutoSize = true;
            this.rd2015.Location = new System.Drawing.Point(289, 40);
            this.rd2015.Name = "rd2015";
            this.rd2015.Size = new System.Drawing.Size(70, 24);
            this.rd2015.TabIndex = 0;
            this.rd2015.Text = "2015";
            this.rd2015.UseVisualStyleBackColor = true;
            this.rd2015.CheckedChanged += new System.EventHandler(this.rd2015_CheckedChanged);
            // 
            // rdTatCa
            // 
            this.rdTatCa.AutoSize = true;
            this.rdTatCa.Location = new System.Drawing.Point(42, 40);
            this.rdTatCa.Name = "rdTatCa";
            this.rdTatCa.Size = new System.Drawing.Size(78, 24);
            this.rdTatCa.TabIndex = 0;
            this.rdTatCa.Text = "Tất cả";
            this.rdTatCa.UseVisualStyleBackColor = true;
            this.rdTatCa.CheckedChanged += new System.EventHandler(this.rdTatCa_CheckedChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(446, 47);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(307, 26);
            this.txtTimKiem.TabIndex = 2;
            // 
            // groupboxTimKiem
            // 
            this.groupboxTimKiem.Controls.Add(this.txtTimKiem);
            this.groupboxTimKiem.Controls.Add(this.rdTheoMa);
            this.groupboxTimKiem.Controls.Add(this.rdTheoSTC);
            this.groupboxTimKiem.Location = new System.Drawing.Point(67, 144);
            this.groupboxTimKiem.Name = "groupboxTimKiem";
            this.groupboxTimKiem.Size = new System.Drawing.Size(983, 100);
            this.groupboxTimKiem.TabIndex = 0;
            this.groupboxTimKiem.TabStop = false;
            this.groupboxTimKiem.Text = "Tìm kiếm";
            // 
            // rdTheoMa
            // 
            this.rdTheoMa.AutoSize = true;
            this.rdTheoMa.Checked = true;
            this.rdTheoMa.Location = new System.Drawing.Point(42, 49);
            this.rdTheoMa.Name = "rdTheoMa";
            this.rdTheoMa.Size = new System.Drawing.Size(152, 24);
            this.rdTheoMa.TabIndex = 0;
            this.rdTheoMa.TabStop = true;
            this.rdTheoMa.Text = "Theo mã/tên MH";
            this.rdTheoMa.UseVisualStyleBackColor = true;
            // 
            // rdTheoSTC
            // 
            this.rdTheoSTC.AutoSize = true;
            this.rdTheoSTC.Location = new System.Drawing.Point(289, 49);
            this.rdTheoSTC.Name = "rdTheoSTC";
            this.rdTheoSTC.Size = new System.Drawing.Size(115, 24);
            this.rdTheoSTC.TabIndex = 0;
            this.rdTheoSTC.TabStop = true;
            this.rdTheoSTC.Text = "Theo số TC";
            this.rdTheoSTC.UseVisualStyleBackColor = true;
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.CTDT,
            this.SoTC});
            this.dgvMonHoc.ContextMenuStrip = this.cmsThaoTacMH;
            this.dgvMonHoc.Location = new System.Drawing.Point(6, 54);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowHeadersWidth = 62;
            this.dgvMonHoc.RowTemplate.Height = 28;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(959, 243);
            this.dgvMonHoc.TabIndex = 1;
            this.dgvMonHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellDoubleClick);
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.MinimumWidth = 8;
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 150;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên môn học";
            this.TenMH.MinimumWidth = 8;
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 150;
            // 
            // CTDT
            // 
            this.CTDT.DataPropertyName = "TenCTDT";
            this.CTDT.HeaderText = "Chương trình đào tạo";
            this.CTDT.MinimumWidth = 8;
            this.CTDT.Name = "CTDT";
            this.CTDT.Width = 150;
            // 
            // SoTC
            // 
            this.SoTC.DataPropertyName = "SoTC";
            this.SoTC.HeaderText = "Số tín chỉ ";
            this.SoTC.MinimumWidth = 8;
            this.SoTC.Name = "SoTC";
            this.SoTC.Width = 150;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(873, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "+";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBoxDSMH
            // 
            this.groupBoxDSMH.Controls.Add(this.btnThem);
            this.groupBoxDSMH.Controls.Add(this.dgvMonHoc);
            this.groupBoxDSMH.Location = new System.Drawing.Point(67, 288);
            this.groupBoxDSMH.Name = "groupBoxDSMH";
            this.groupBoxDSMH.Size = new System.Drawing.Size(983, 303);
            this.groupBoxDSMH.TabIndex = 0;
            this.groupBoxDSMH.TabStop = false;
            this.groupBoxDSMH.Text = "Danh sách môn học";
            // 
            // cmsThaoTacMH
            // 
            this.cmsThaoTacMH.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsThaoTacMH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXoa,
            this.tsmXemDS,
            this.tsmThongKe});
            this.cmsThaoTacMH.Name = "cmsThaoTacMH";
            this.cmsThaoTacMH.Size = new System.Drawing.Size(425, 133);
            // 
            // tsmXoa
            // 
            this.tsmXoa.Name = "tsmXoa";
            this.tsmXoa.Size = new System.Drawing.Size(424, 32);
            this.tsmXoa.Text = "Xóa";
            // 
            // tsmXemDS
            // 
            this.tsmXemDS.Name = "tsmXemDS";
            this.tsmXemDS.Size = new System.Drawing.Size(424, 32);
            this.tsmXemDS.Text = "Xem danh sách sinh viên đăng ký môn học";
            // 
            // tsmThongKe
            // 
            this.tsmThongKe.Name = "tsmThongKe";
            this.tsmThongKe.Size = new System.Drawing.Size(424, 32);
            this.tsmThongKe.Text = "Tổng số lượng SV đăng ký MH";
            this.tsmThongKe.Click += new System.EventHandler(this.tsmThongKe_Click);
            // 
            // frmQLMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 642);
            this.Controls.Add(this.groupBoxDSMH);
            this.Controls.Add(this.groupboxTimKiem);
            this.Controls.Add(this.groupboxCTDT);
            this.Name = "frmQLMH";
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.frmQLMH_Load);
            this.groupboxCTDT.ResumeLayout(false);
            this.groupboxCTDT.PerformLayout();
            this.groupboxTimKiem.ResumeLayout(false);
            this.groupboxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.groupBoxDSMH.ResumeLayout(false);
            this.cmsThaoTacMH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxCTDT;
        private System.Windows.Forms.RadioButton rd2020;
        private System.Windows.Forms.RadioButton rd2017;
        private System.Windows.Forms.RadioButton rd2015;
        private System.Windows.Forms.RadioButton rdTatCa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupboxTimKiem;
        private System.Windows.Forms.RadioButton rdTheoMa;
        private System.Windows.Forms.RadioButton rdTheoSTC;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBoxDSMH;
        private System.Windows.Forms.ContextMenuStrip cmsThaoTacMH;
        private System.Windows.Forms.ToolStripMenuItem tsmXoa;
        private System.Windows.Forms.ToolStripMenuItem tsmXemDS;
        private System.Windows.Forms.ToolStripMenuItem tsmThongKe;
    }
}