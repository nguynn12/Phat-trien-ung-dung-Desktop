using System.Windows.Forms;

namespace Lab07_Entity_Framework
{
    partial class BillDetailsForm
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
            this.lblBillInfo = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalFromDetails = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.colFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBillInfo
            // 
            this.lblBillInfo.AutoSize = true;
            this.lblBillInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBillInfo.Location = new System.Drawing.Point(12, 15);
            this.lblBillInfo.Name = "lblBillInfo";
            this.lblBillInfo.Size = new System.Drawing.Size(300, 23);
            this.lblBillInfo.TabIndex = 0;
            this.lblBillInfo.Text = "Bàn: ... | Ngày: ... | Nhân viên: ...";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 50);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 20);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Tổng tiền: ...";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(200, 50);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(100, 20);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Giảm giá: ...";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(380, 50);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(80, 20);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Thuế: ...";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(12, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 23);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Thực thu: ...";
            // 
            // dgvDetails
            // 
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFoodName,
            this.colQuantity,
            this.colPrice,
            this.colTotal});
            this.dgvDetails.Location = new System.Drawing.Point(12, 110);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.Size = new System.Drawing.Size(760, 280);
            this.dgvDetails.TabIndex = 5;
            // 
            // lblTotalFromDetails
            // 
            this.lblTotalFromDetails.AutoSize = true;
            this.lblTotalFromDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblTotalFromDetails.Location = new System.Drawing.Point(12, 400);
            this.lblTotalFromDetails.Name = "lblTotalFromDetails";
            this.lblTotalFromDetails.Size = new System.Drawing.Size(150, 20);
            this.lblTotalFromDetails.TabIndex = 6;
            this.lblTotalFromDetails.Text = "Tổng từ chi tiết: ...";
            // 
            // colFoodName
            // 
            this.colFoodName.DataPropertyName = "FoodName";
            this.colFoodName.HeaderText = "Món ăn";
            this.colFoodName.MinimumWidth = 6;
            this.colFoodName.Name = "colFoodName";
            this.colFoodName.ReadOnly = true;
            this.colFoodName.FillWeight = 120F;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "SL";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.FillWeight = 80F;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.FillWeight = 100F;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "Total";
            this.colTotal.HeaderText = "Thành tiền";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.FillWeight = 100F;
            // 
            // BillDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.lblTotalFromDetails);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblBillInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BillDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBillInfo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalFromDetails;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}
