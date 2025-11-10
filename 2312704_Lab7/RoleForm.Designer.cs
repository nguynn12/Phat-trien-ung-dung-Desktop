namespace Lab07_Entity_Framework
{
    partial class RoleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvwRoles = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lvwUsers = new System.Windows.Forms.ListView();
            this.colUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(14, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Danh sách vai trò";
            // 
            // lvwRoles
            // 
            this.lvwRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colName,
            this.colPath});
            this.lvwRoles.FullRowSelect = true;
            this.lvwRoles.GridLines = true;
            this.lvwRoles.HideSelection = false;
            this.lvwRoles.Location = new System.Drawing.Point(14, 50);
            this.lvwRoles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvwRoles.Name = "lvwRoles";
            this.lvwRoles.Size = new System.Drawing.Size(517, 274);
            this.lvwRoles.TabIndex = 1;
            this.lvwRoles.UseCompatibleStateImageBehavior = false;
            this.lvwRoles.View = System.Windows.Forms.View.Details;
            this.lvwRoles.SelectedIndexChanged += new System.EventHandler(this.lvwRoles_SelectedIndexChanged_1);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            // 
            // colName
            // 
            this.colName.Text = "Tên vai trò";
            this.colName.Width = 180;
            // 
            // colPath
            // 
            this.colPath.Text = "Đường dẫn";
            this.colPath.Width = 150;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(538, 50);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(538, 95);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 38);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(538, 141);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(14, 338);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(275, 28);
            this.lblUsers.TabIndex = 5;
            this.lblUsers.Text = "Người dùng thuộc vai trò này:";
            // 
            // lvwUsers
            // 
            this.lvwUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserName});
            this.lvwUsers.FullRowSelect = true;
            this.lvwUsers.GridLines = true;
            this.lvwUsers.HideSelection = false;
            this.lvwUsers.Location = new System.Drawing.Point(14, 370);
            this.lvwUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvwUsers.Name = "lvwUsers";
            this.lvwUsers.Size = new System.Drawing.Size(608, 162);
            this.lvwUsers.TabIndex = 6;
            this.lvwUsers.UseCompatibleStateImageBehavior = false;
            this.lvwUsers.View = System.Windows.Forms.View.Details;
            // 
            // colUserName
            // 
            this.colUserName.Text = "Tên người dùng";
            this.colUserName.Width = 200;
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 550);
            this.Controls.Add(this.lvwUsers);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvwRoles);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý vai trò (Role)";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView lvwRoles;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ListView lvwUsers;
        private System.Windows.Forms.ColumnHeader colUserName;
    }
}