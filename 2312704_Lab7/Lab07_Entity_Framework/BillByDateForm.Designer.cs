namespace Lab07_Entity_Framework
{
    partial class BillByDateForm
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
            this.components = new System.ComponentModel.Container();

            this.lstDates = new System.Windows.Forms.ListBox();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.colBillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();

            // 
            // lstDates
            // 
            this.lstDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDates.FormattingEnabled = true;
            this.lstDates.ItemHeight = 20;
            this.lstDates.Location = new System.Drawing.Point(0, 0);
            this.lstDates.Name = "lstDates";
            this.lstDates.Size = new System.Drawing.Size(250, 400);
            this.lstDates.TabIndex = 0;
        //    this.lstDates.SelectedIndexChanged += new System.EventHandler(this.lstDates_SelectedIndexChanged);

            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 10);
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Panel1MinSize = 200;
            this.splitContainer1.Panel2MinSize = 400;

            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstDates);

            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvBills);
            this.splitContainer1.Size = new System.Drawing.Size(760, 400);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 1;

            // 
            // dgvBills
            // 
            this.dgvBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colBillId,
                this.colBillName,
                this.colCheckoutDate,
                this.colAccount,
                this.colAmount,
                this.colDiscount,
                this.colTax,
                this.colTotal});
            this.dgvBills.Location = new System.Drawing.Point(0, 0);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.ReadOnly = true;
            this.dgvBills.Size = new System.Drawing.Size(506, 400);
            this.dgvBills.TabIndex = 0;
         //   this.dgvBills.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellDoubleClick);

            // 
            // colBillId
            // 
            this.colBillId.DataPropertyName = "Id";
            this.colBillId.HeaderText = "ID HĐ";
            this.colBillId.Name = "colBillId";
            this.colBillId.ReadOnly = true;
            this.colBillId.Width = 60;

            // 
            // colBillName
            // 
            this.colBillName.DataPropertyName = "Name";
            this.colBillName.HeaderText = "Tên hóa đơn";
            this.colBillName.Name = "colBillName";
            this.colBillName.ReadOnly = true;
            this.colBillName.FillWeight = 120F;

            // 
            // colCheckoutDate
            // 
            this.colCheckoutDate.DataPropertyName = "CheckoutDate";
            this.colCheckoutDate.HeaderText = "Ngày lập";
            this.colCheckoutDate.Name = "colCheckoutDate";
            this.colCheckoutDate.ReadOnly = true;
            // Format will be applied in code-behind (constructor) to avoid Designer parse issues
            this.colCheckoutDate.FillWeight = 100F;

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
            // Format applied in constructor
            this.colAmount.FillWeight = 90F;

            // 
            // colDiscount
            // 
            this.colDiscount.DataPropertyName = "Discount";
            this.colDiscount.HeaderText = "Giảm (%)";
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.ReadOnly = true;
            // Format applied in constructor
            this.colDiscount.FillWeight = 70F;

            // 
            // colTax
            // 
            this.colTax.DataPropertyName = "Tax";
            this.colTax.HeaderText = "Thuế (%)";
            this.colTax.Name = "colTax";
            this.colTax.ReadOnly = true;
            // Format applied in constructor
            this.colTax.FillWeight = 70F;

            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.HeaderText = "Thực thu";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // Format applied in constructor
            this.colTotal.FillWeight = 100F;

            // 
            // BillByDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BillByDateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn theo ngày";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lstDates;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckoutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
