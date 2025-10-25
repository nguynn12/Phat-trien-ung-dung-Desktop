namespace Lab_Basic_Command
{
    partial class RoleListForm
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
            this.lblAccountName = new System.Windows.Forms.Label();
            this.dgvRoleList = new System.Windows.Forms.DataGridView();
            this.VaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(207, 66);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(13, 20);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = ".";
            // 
            // dgvRoleList
            // 
            this.dgvRoleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VaiTro,
            this.MoTa,
            this.TinhTrang});
            this.dgvRoleList.Location = new System.Drawing.Point(37, 126);
            this.dgvRoleList.Name = "dgvRoleList";
            this.dgvRoleList.RowHeadersWidth = 62;
            this.dgvRoleList.RowTemplate.Height = 28;
            this.dgvRoleList.Size = new System.Drawing.Size(729, 294);
            this.dgvRoleList.TabIndex = 1;
            // 
            // VaiTro
            // 
            this.VaiTro.DataPropertyName = "RoleName";
            this.VaiTro.HeaderText = "Tên vai trò";
            this.VaiTro.MinimumWidth = 8;
            this.VaiTro.Name = "VaiTro";
            this.VaiTro.Width = 150;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "Notes";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 8;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 150;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "Stat";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 8;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Width = 150;
            // 
            // RoleListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRoleList);
            this.Controls.Add(this.lblAccountName);
            this.Name = "RoleListForm";
            this.Text = "RoleListForm";
            this.Load += new System.EventHandler(this.RoleListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.DataGridView dgvRoleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
    }
}