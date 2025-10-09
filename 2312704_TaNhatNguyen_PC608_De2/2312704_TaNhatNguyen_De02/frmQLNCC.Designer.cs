namespace _2312704_TaNhatNguyen_De02
{
    partial class frmQLNCC
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
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.lblTenNCC = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupboxTimKiem = new System.Windows.Forms.GroupBox();
            this.rdTheoTen = new System.Windows.Forms.RadioButton();
            this.rdTheoSDT = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblDSNCC = new System.Windows.Forms.Label();
            this.lvNCC = new System.Windows.Forms.ListView();
            this.MaNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenNCC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.groupboxTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(284, 162);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(84, 33);
            this.btnMacDinh.TabIndex = 0;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(166, 30);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(202, 22);
            this.txtMaNCC.TabIndex = 1;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(35, 36);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(109, 16);
            this.lblMaNCC.TabIndex = 2;
            this.lblMaNCC.Text = "Mã nhà cung cấp";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(166, 77);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(202, 22);
            this.txtTenNCC.TabIndex = 3;
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.AutoSize = true;
            this.lblTenNCC.Location = new System.Drawing.Point(35, 83);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(114, 16);
            this.lblTenNCC.TabIndex = 4;
            this.lblTenNCC.Text = "Tên nhà cung cấp";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(35, 126);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 16);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(166, 120);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(202, 22);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(520, 80);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(236, 62);
            this.txtMoTa.TabIndex = 7;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(520, 36);
            this.mtxtSDT.Mask = "0000000000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(236, 22);
            this.mtxtSDT.TabIndex = 8;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(415, 83);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(40, 16);
            this.lblMoTa.TabIndex = 9;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(415, 36);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(85, 16);
            this.lblSDT.TabIndex = 10;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(418, 162);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 33);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupboxTimKiem
            // 
            this.groupboxTimKiem.Controls.Add(this.txtTimKiem);
            this.groupboxTimKiem.Controls.Add(this.rdTheoSDT);
            this.groupboxTimKiem.Controls.Add(this.rdTheoTen);
            this.groupboxTimKiem.Location = new System.Drawing.Point(320, 211);
            this.groupboxTimKiem.Name = "groupboxTimKiem";
            this.groupboxTimKiem.Size = new System.Drawing.Size(436, 68);
            this.groupboxTimKiem.TabIndex = 11;
            this.groupboxTimKiem.TabStop = false;
            this.groupboxTimKiem.Text = "Tìm kiếm";
            // 
            // rdTheoTen
            // 
            this.rdTheoTen.AutoSize = true;
            this.rdTheoTen.Checked = true;
            this.rdTheoTen.Location = new System.Drawing.Point(26, 31);
            this.rdTheoTen.Name = "rdTheoTen";
            this.rdTheoTen.Size = new System.Drawing.Size(81, 20);
            this.rdTheoTen.TabIndex = 12;
            this.rdTheoTen.TabStop = true;
            this.rdTheoTen.Text = "Theo tên";
            this.rdTheoTen.UseVisualStyleBackColor = true;
            // 
            // rdTheoSDT
            // 
            this.rdTheoSDT.AutoSize = true;
            this.rdTheoSDT.Location = new System.Drawing.Point(126, 31);
            this.rdTheoSDT.Name = "rdTheoSDT";
            this.rdTheoSDT.Size = new System.Drawing.Size(91, 20);
            this.rdTheoSDT.TabIndex = 12;
            this.rdTheoSDT.TabStop = true;
            this.rdTheoSDT.Text = "Theo SDT";
            this.rdTheoSDT.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(223, 30);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(195, 22);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblDSNCC
            // 
            this.lblDSNCC.AutoSize = true;
            this.lblDSNCC.Location = new System.Drawing.Point(35, 288);
            this.lblDSNCC.Name = "lblDSNCC";
            this.lblDSNCC.Size = new System.Drawing.Size(154, 16);
            this.lblDSNCC.TabIndex = 12;
            this.lblDSNCC.Text = "Danh sách nhà cung cấp";
            // 
            // lvNCC
            // 
            this.lvNCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.SDT,
            this.MoTa});
            this.lvNCC.FullRowSelect = true;
            this.lvNCC.HideSelection = false;
            this.lvNCC.Location = new System.Drawing.Point(38, 316);
            this.lvNCC.Name = "lvNCC";
            this.lvNCC.Size = new System.Drawing.Size(718, 122);
            this.lvNCC.TabIndex = 13;
            this.lvNCC.UseCompatibleStateImageBehavior = false;
            this.lvNCC.View = System.Windows.Forms.View.Details;
            this.lvNCC.SelectedIndexChanged += new System.EventHandler(this.lvNCC_SelectedIndexChanged);
            this.lvNCC.DoubleClick += new System.EventHandler(this.lvNCC_DoubleClick);
            // 
            // MaNCC
            // 
            this.MaNCC.Text = "Mã nhà cc";
            this.MaNCC.Width = 104;
            // 
            // TenNCC
            // 
            this.TenNCC.Text = "Tên nhà cung cấp";
            this.TenNCC.Width = 172;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa chỉ";
            this.DiaChi.Width = 124;
            // 
            // SDT
            // 
            this.SDT.Text = "Số ĐT";
            this.SDT.Width = 106;
            // 
            // MoTa
            // 
            this.MoTa.Text = "Mô tả";
            this.MoTa.Width = 184;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Location = new System.Drawing.Point(667, 444);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(89, 29);
            this.btnXuatFile.TabIndex = 14;
            this.btnXuatFile.Text = "Xuất JSON";
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // frmQLNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.lvNCC);
            this.Controls.Add(this.lblDSNCC);
            this.Controls.Add(this.groupboxTimKiem);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenNCC);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.lblMaNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMacDinh);
            this.Name = "frmQLNCC";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmQLNCC_Load);
            this.groupboxTimKiem.ResumeLayout(false);
            this.groupboxTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label lblTenNCC;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupboxTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTheoSDT;
        private System.Windows.Forms.RadioButton rdTheoTen;
        private System.Windows.Forms.Label lblDSNCC;
        private System.Windows.Forms.ListView lvNCC;
        private System.Windows.Forms.ColumnHeader MaNCC;
        private System.Windows.Forms.ColumnHeader TenNCC;
        private System.Windows.Forms.ColumnHeader DiaChi;
        private System.Windows.Forms.ColumnHeader SDT;
        private System.Windows.Forms.ColumnHeader MoTa;
        private System.Windows.Forms.Button btnXuatFile;
    }
}

