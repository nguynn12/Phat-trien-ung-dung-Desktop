// File: RestaurantManagementProject/frmMain.Designer.cs
namespace RestaurantManagementProject
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnBillDetails = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnRoleAccount = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.pnlMenu.Controls.Add(this.lblTitle);
            this.pnlMenu.Controls.Add(this.btnAccount);
            this.pnlMenu.Controls.Add(this.btnCategory);
            this.pnlMenu.Controls.Add(this.btnFood);
            this.pnlMenu.Controls.Add(this.btnBillDetails);
            this.pnlMenu.Controls.Add(this.btnBills);
            this.pnlMenu.Controls.Add(this.btnRole);
            this.pnlMenu.Controls.Add(this.btnRoleAccount);
            this.pnlMenu.Controls.Add(this.btnTable);
            this.pnlMenu.Controls.Add(this.btnOrder);
            this.pnlMenu.Controls.Add(this.btnPayment);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(244, 774);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 97);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "QUẢN LÝ NHÀ HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(20, 100);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(210, 50);
            this.btnAccount.TabIndex = 0;
            this.btnAccount.Text = "Quản lý tài khoản";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(20, 160);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(210, 50);
            this.btnCategory.TabIndex = 1;
            this.btnCategory.Text = "Quản lý nhóm món";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFood.ForeColor = System.Drawing.Color.White;
            this.btnFood.Location = new System.Drawing.Point(20, 220);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(210, 50);
            this.btnFood.TabIndex = 2;
            this.btnFood.Text = "Quản lý món ăn";
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnBillDetails
            // 
            this.btnBillDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnBillDetails.FlatAppearance.BorderSize = 0;
            this.btnBillDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillDetails.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBillDetails.ForeColor = System.Drawing.Color.White;
            this.btnBillDetails.Location = new System.Drawing.Point(20, 280);
            this.btnBillDetails.Name = "btnBillDetails";
            this.btnBillDetails.Size = new System.Drawing.Size(210, 50);
            this.btnBillDetails.TabIndex = 3;
            this.btnBillDetails.Text = "Chi tiết hóa đơn";
            this.btnBillDetails.UseVisualStyleBackColor = false;
            this.btnBillDetails.Click += new System.EventHandler(this.btnBillDetails_Click);
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Location = new System.Drawing.Point(20, 340);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(210, 50);
            this.btnBills.TabIndex = 4;
            this.btnBills.Text = "Quản lý hóa đơn";
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnRole
            // 
            this.btnRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnRole.FlatAppearance.BorderSize = 0;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRole.ForeColor = System.Drawing.Color.White;
            this.btnRole.Location = new System.Drawing.Point(20, 400);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(210, 50);
            this.btnRole.TabIndex = 5;
            this.btnRole.Text = "Quản lý quyền";
            this.btnRole.UseVisualStyleBackColor = false;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnRoleAccount
            // 
            this.btnRoleAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnRoleAccount.FlatAppearance.BorderSize = 0;
            this.btnRoleAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRoleAccount.ForeColor = System.Drawing.Color.White;
            this.btnRoleAccount.Location = new System.Drawing.Point(20, 460);
            this.btnRoleAccount.Name = "btnRoleAccount";
            this.btnRoleAccount.Size = new System.Drawing.Size(210, 50);
            this.btnRoleAccount.TabIndex = 6;
            this.btnRoleAccount.Text = "Phân quyền tài khoản";
            this.btnRoleAccount.UseVisualStyleBackColor = false;
            this.btnRoleAccount.Click += new System.EventHandler(this.btnRoleAccount_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Location = new System.Drawing.Point(20, 520);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(210, 50);
            this.btnTable.TabIndex = 7;
            this.btnTable.Text = "Quản lý bàn ăn";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(20, 580);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(210, 50);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Đặt món";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(20, 640);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(210, 50);
            this.btnPayment.TabIndex = 11;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(20, 700);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 774);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ NHÀ HÀNG";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnBillDetails;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnRoleAccount;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnOrder;     // THÊM
        private System.Windows.Forms.Button btnPayment;   // THÊM
        private System.Windows.Forms.Button btnExit;
    }
}