namespace Lab07_Entity_Framework
{
    partial class SalesLogForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSummary = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvLog
            // 
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colName,
                this.colDate,
                this.colAccount,
                this.colAmount,
                this.colDiscount,
                this.colTax,
                this.colTotal});
            this.dgvLog.Location = new System.Drawing.Point(12, 12);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersWidth = 51;
            this.dgvLog.Size = new System.Drawing.Size(760, 350);
            this.dgvLog.TabIndex = 0;

            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID HĐ";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 60;

            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên hóa đơn";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.FillWeight = 120F;

            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "CheckoutDate";
            this.colDate.HeaderText = "Ngày lập";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            this.colDate.FillWeight = 100F;

            // 
            // colAccount
            // 
            this.colAccount.DataPropertyName = "Account";
            this.colAccount.HeaderText = "Nhân viên";
            this.colAccount.Name = "colAccount";
            this.colAccount.ReadOnly = true;
            this.colAccount.FillWeight = 100F;

            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "Tiền hàng";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.DefaultCellStyle.Format = "N0";
            this.colAmount.FillWeight = 90F;

            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "Discount";
            this.colDiscount.HeaderText = "Giảm (%)";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            this.colDiscount.DefaultCellStyle.Format = "P0";
            this.colDiscount.FillWeight = 70F;

            // 
            // colTax
            // 
            this.colTax.DataPropertyName = "Tax";
            this.colTax.HeaderText = "Thuế (%)";
            this.colTax.Name = "colTax";
            this.colTax.ReadOnly = true;
            this.colTax.DefaultCellStyle.Format = "P0";
            this.colTax.FillWeight = 70F;

            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.HeaderText = "Thực thu";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.DefaultCellStyle.Format = "N0";
            this.colTotal.FillWeight = 100F;

            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSummary.Location = new System.Drawing.Point(12, 370);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(760, 20);
            this.lblSummary.TabIndex = 1;
            this.lblSummary.Text = "Tổng: ...";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // SalesLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 400);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.dgvLog);
            this.Name = "SalesLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhật ký bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblSummary;
    }
}