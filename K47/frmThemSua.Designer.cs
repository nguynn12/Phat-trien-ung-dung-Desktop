namespace K47
{
    partial class frmThemSua
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
            this.txtMaBan = new System.Windows.Forms.TextBox();
            this.lblMaBan = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.lblTenBan = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblSucChua = new System.Windows.Forms.Label();
            this.nudTrangThai = new System.Windows.Forms.NumericUpDown();
            this.nudSucChua = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrangThai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaBan
            // 
            this.txtMaBan.Location = new System.Drawing.Point(119, 44);
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.ReadOnly = true;
            this.txtMaBan.Size = new System.Drawing.Size(171, 26);
            this.txtMaBan.TabIndex = 0;
            // 
            // lblMaBan
            // 
            this.lblMaBan.AutoSize = true;
            this.lblMaBan.Location = new System.Drawing.Point(29, 47);
            this.lblMaBan.Name = "lblMaBan";
            this.lblMaBan.Size = new System.Drawing.Size(62, 20);
            this.lblMaBan.TabIndex = 1;
            this.lblMaBan.Text = "Mã bàn";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(74, 254);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 47);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(119, 95);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(171, 26);
            this.txtTenBan.TabIndex = 0;
            // 
            // lblTenBan
            // 
            this.lblTenBan.AutoSize = true;
            this.lblTenBan.Location = new System.Drawing.Point(29, 98);
            this.lblTenBan.Name = "lblTenBan";
            this.lblTenBan.Size = new System.Drawing.Size(67, 20);
            this.lblTenBan.TabIndex = 1;
            this.lblTenBan.Text = "Tên bàn";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(29, 146);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(80, 20);
            this.lblTrangThai.TabIndex = 1;
            this.lblTrangThai.Text = "Trạng thái";
            // 
            // lblSucChua
            // 
            this.lblSucChua.AutoSize = true;
            this.lblSucChua.Location = new System.Drawing.Point(29, 200);
            this.lblSucChua.Name = "lblSucChua";
            this.lblSucChua.Size = new System.Drawing.Size(76, 20);
            this.lblSucChua.TabIndex = 1;
            this.lblSucChua.Text = "Sức chứa";
            // 
            // nudTrangThai
            // 
            this.nudTrangThai.Location = new System.Drawing.Point(119, 146);
            this.nudTrangThai.Name = "nudTrangThai";
            this.nudTrangThai.Size = new System.Drawing.Size(171, 26);
            this.nudTrangThai.TabIndex = 3;
            // 
            // nudSucChua
            // 
            this.nudSucChua.Location = new System.Drawing.Point(119, 194);
            this.nudSucChua.Name = "nudSucChua";
            this.nudSucChua.Size = new System.Drawing.Size(171, 26);
            this.nudSucChua.TabIndex = 3;
            // 
            // frmThemSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 369);
            this.Controls.Add(this.nudSucChua);
            this.Controls.Add(this.nudTrangThai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lblSucChua);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.lblTenBan);
            this.Controls.Add(this.lblMaBan);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.txtMaBan);
            this.Name = "frmThemSua";
            this.Text = "frmThemSua";
            this.Load += new System.EventHandler(this.frmThemSua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTrangThai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSucChua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaBan;
        private System.Windows.Forms.Label lblMaBan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label lblTenBan;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblSucChua;
        private System.Windows.Forms.NumericUpDown nudTrangThai;
        private System.Windows.Forms.NumericUpDown nudSucChua;
    }
}