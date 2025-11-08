namespace Lab_Advanced_Command
{
    partial class AccountForm
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
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.txtUsermame = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.cmsAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmXemVaiTro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXemNhatKy = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTenDayDu = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.cmsAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(30, 24);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.RowHeadersWidth = 62;
            this.dgvAccounts.RowTemplate.Height = 28;
            this.dgvAccounts.Size = new System.Drawing.Size(704, 210);
            this.dgvAccounts.TabIndex = 0;
            this.dgvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccounts_CellClick);
            this.dgvAccounts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccounts_CellMouseDown);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(30, 384);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(99, 38);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(225, 384);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(107, 38);
            this.btnUpdateAccount.TabIndex = 1;
            this.btnUpdateAccount.Text = "Cập nhật";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(428, 384);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(131, 38);
            this.btnResetPassword.TabIndex = 1;
            this.btnResetPassword.Text = "Reset mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(624, 384);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(110, 38);
            this.btnAddRole.TabIndex = 1;
            this.btnAddRole.Text = "Thêm vai trò";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(26, 258);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(109, 20);
            this.lblTenTaiKhoan.TabIndex = 2;
            this.lblTenTaiKhoan.Text = "Tên tài khoản:";
            // 
            // txtUsermame
            // 
            this.txtUsermame.Location = new System.Drawing.Point(141, 255);
            this.txtUsermame.Name = "txtUsermame";
            this.txtUsermame.Size = new System.Drawing.Size(191, 26);
            this.txtUsermame.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(26, 299);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(141, 293);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(191, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(428, 258);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(59, 20);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Vai trò:";
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(543, 253);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(191, 28);
            this.cboRole.TabIndex = 6;
            // 
            // cmsAccount
            // 
            this.cmsAccount.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXemVaiTro,
            this.tsmXemNhatKy});
            this.cmsAccount.Name = "contextMenuStrip1";
            this.cmsAccount.Size = new System.Drawing.Size(291, 68);
            // 
            // tsmXemVaiTro
            // 
            this.tsmXemVaiTro.Name = "tsmXemVaiTro";
            this.tsmXemVaiTro.Size = new System.Drawing.Size(290, 32);
            this.tsmXemVaiTro.Text = "Xem danh sách các vai trò";
            this.tsmXemVaiTro.Click += new System.EventHandler(this.tsmXemVaiTro_Click);
            // 
            // tsmXemNhatKy
            // 
            this.tsmXemNhatKy.Name = "tsmXemNhatKy";
            this.tsmXemNhatKy.Size = new System.Drawing.Size(290, 32);
            this.tsmXemNhatKy.Text = "Xem nhật ký hoạt động";
            this.tsmXemNhatKy.Click += new System.EventHandler(this.tsmXemNhatKy_Click);
            // 
            // lblTenDayDu
            // 
            this.lblTenDayDu.AutoSize = true;
            this.lblTenDayDu.Location = new System.Drawing.Point(26, 337);
            this.lblTenDayDu.Name = "lblTenDayDu";
            this.lblTenDayDu.Size = new System.Drawing.Size(91, 20);
            this.lblTenDayDu.TabIndex = 2;
            this.lblTenDayDu.Text = "Tên đầy đủ:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(141, 334);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(191, 26);
            this.txtFullName.TabIndex = 3;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(428, 337);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(88, 20);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telephone:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(543, 334);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(191, 26);
            this.txtTel.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(543, 293);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(428, 299);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblTenDayDu);
            this.Controls.Add(this.txtUsermame);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnUpdateAccount);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.dgvAccounts);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.cmsAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.TextBox txtUsermame;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.ContextMenuStrip cmsAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmXemVaiTro;
        private System.Windows.Forms.ToolStripMenuItem tsmXemNhatKy;
        private System.Windows.Forms.Label lblTenDayDu;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}