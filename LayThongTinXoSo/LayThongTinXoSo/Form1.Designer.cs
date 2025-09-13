namespace LayThongTinXoSo
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Miền Bắc");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Miền Trung");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Miền Nam");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Xổ số", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tvXoSo = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGiaiThuong = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(415, 54);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(25, 38);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = ".";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // tvXoSo
            // 
            this.tvXoSo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvXoSo.Location = new System.Drawing.Point(24, 54);
            this.tvXoSo.Name = "tvXoSo";
            treeNode9.Name = "tnMienBac";
            treeNode9.Text = "Miền Bắc";
            treeNode10.Name = "tnMienTrung";
            treeNode10.Text = "Miền Trung";
            treeNode11.Name = "tnMienNam";
            treeNode11.Text = "Miền Nam";
            treeNode12.Name = "Node1";
            treeNode12.Text = "Xổ số";
            this.tvXoSo.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.tvXoSo.Size = new System.Drawing.Size(214, 189);
            this.tvXoSo.TabIndex = 2;
            this.tvXoSo.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.tvXoSo);
            this.groupBox1.Controls.Add(this.lblGiaiThuong);
            this.groupBox1.Controls.Add(this.lblTieuDe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 637);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LẤY THÔNG TIN XỔ SỐ";
            // 
            // lblGiaiThuong
            // 
            this.lblGiaiThuong.AutoSize = true;
            this.lblGiaiThuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaiThuong.Location = new System.Drawing.Point(417, 149);
            this.lblGiaiThuong.Name = "lblGiaiThuong";
            this.lblGiaiThuong.Size = new System.Drawing.Size(17, 28);
            this.lblGiaiThuong.TabIndex = 0;
            this.lblGiaiThuong.Text = ".";
            this.lblGiaiThuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGiaiThuong.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Location = new System.Drawing.Point(24, 279);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(200, 34);
            this.dtpNgay.TabIndex = 3;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 637);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TreeView tvXoSo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGiaiThuong;
        private System.Windows.Forms.DateTimePicker dtpNgay;
    }
}

