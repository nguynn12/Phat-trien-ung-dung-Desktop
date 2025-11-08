namespace RestaurantManagementProject
{
    partial class frmPayment
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
            this.grpBills = new System.Windows.Forms.GroupBox();
            this.lsvBills = new System.Windows.Forms.ListView();
            this.colBillName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.lsvDetails = new System.Windows.Forms.ListView();
            this.colFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFinalAmount = new System.Windows.Forms.TextBox();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.grpBills.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBills
            // 
            this.grpBills.Controls.Add(this.lsvBills);
            this.grpBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpBills.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpBills.Location = new System.Drawing.Point(12, 12);
            this.grpBills.Name = "grpBills";
            this.grpBills.Size = new System.Drawing.Size(380, 240);
            this.grpBills.TabIndex = 0;
            this.grpBills.TabStop = false;
            this.grpBills.Text = "HÓA ĐƠN CHƯA THANH TOÁN";
            // 
            // lsvBills
            // 
            this.lsvBills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvBills.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBillName,
            this.colTable,
            this.colDate,
            this.colAmount});
            this.lsvBills.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lsvBills.FullRowSelect = true;
            this.lsvBills.GridLines = true;
            this.lsvBills.HideSelection = false;
            this.lsvBills.Location = new System.Drawing.Point(15, 35);
            this.lsvBills.Name = "lsvBills";
            this.lsvBills.Size = new System.Drawing.Size(350, 190);
            this.lsvBills.TabIndex = 0;
            this.lsvBills.UseCompatibleStateImageBehavior = false;
            this.lsvBills.View = System.Windows.Forms.View.Details;
            this.lsvBills.SelectedIndexChanged += new System.EventHandler(this.lsvBills_SelectedIndexChanged);
            // 
            // colBillName
            // 
            this.colBillName.Text = "Hóa đơn";
            this.colBillName.Width = 100;
            // 
            // colTable
            // 
            this.colTable.Text = "Bàn";
            this.colTable.Width = 70;
            // 
            // colDate
            // 
            this.colDate.Text = "Thời gian";
            this.colDate.Width = 100;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Tổng tiền";
            this.colAmount.Width = 80;
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.lsvDetails);
            this.grpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDetails.Location = new System.Drawing.Point(12, 260);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(380, 190);
            this.grpDetails.TabIndex = 1;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "CHI TIẾT MÓN ĂN";
            // 
            // lsvDetails
            // 
            this.lsvDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFood,
            this.colQty,
            this.colPrice,
            this.colTotal});
            this.lsvDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lsvDetails.FullRowSelect = true;
            this.lsvDetails.GridLines = true;
            this.lsvDetails.HideSelection = false;
            this.lsvDetails.Location = new System.Drawing.Point(15, 35);
            this.lsvDetails.Name = "lsvDetails";
            this.lsvDetails.Size = new System.Drawing.Size(350, 140);
            this.lsvDetails.TabIndex = 0;
            this.lsvDetails.UseCompatibleStateImageBehavior = false;
            this.lsvDetails.View = System.Windows.Forms.View.Details;
            // 
            // colFood
            // 
            this.colFood.Text = "Món ăn";
            this.colFood.Width = 140;
            // 
            // colQty
            // 
            this.colQty.Text = "SL";
            this.colQty.Width = 50;
            // 
            // colPrice
            // 
            this.colPrice.Text = "Đơn giá";
            this.colPrice.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.Text = "Thành tiền";
            this.colTotal.Width = 80;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.btnExit);
            this.grpPayment.Controls.Add(this.btnPay);
            this.grpPayment.Controls.Add(this.label5);
            this.grpPayment.Controls.Add(this.label4);
            this.grpPayment.Controls.Add(this.label3);
            this.grpPayment.Controls.Add(this.label2);
            this.grpPayment.Controls.Add(this.label1);
            this.grpPayment.Controls.Add(this.txtFinalAmount);
            this.grpPayment.Controls.Add(this.txtTaxAmount);
            this.grpPayment.Controls.Add(this.txtTax);
            this.grpPayment.Controls.Add(this.txtDiscount);
            this.grpPayment.Controls.Add(this.txtSubtotal);
            this.grpPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPayment.Location = new System.Drawing.Point(400, 12);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(320, 438);
            this.grpPayment.TabIndex = 2;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "THANH TOÁN";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(170, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 45);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(40, 340);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(110, 45);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "TỔNG CỘNG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiền thuế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thuế (%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chiết khấu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tạm tính:";
            // 
            // txtFinalAmount
            // 
            this.txtFinalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.txtFinalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtFinalAmount.Location = new System.Drawing.Point(150, 200);
            this.txtFinalAmount.Name = "txtFinalAmount";
            this.txtFinalAmount.ReadOnly = true;
            this.txtFinalAmount.Size = new System.Drawing.Size(150, 39);
            this.txtFinalAmount.TabIndex = 11;
            this.txtFinalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTaxAmount.Location = new System.Drawing.Point(150, 160);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.ReadOnly = true;
            this.txtTaxAmount.Size = new System.Drawing.Size(150, 34);
            this.txtTaxAmount.TabIndex = 9;
            this.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(150, 120);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(150, 34);
            this.txtTax.TabIndex = 7;
            this.txtTax.Text = "10";
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(150, 80);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(150, 34);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSubtotal.Location = new System.Drawing.Point(150, 40);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(150, 34);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpBills);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THANH TOÁN HÓA ĐƠN";
            this.grpBills.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBills;
        private System.Windows.Forms.ListView lsvBills;
        private System.Windows.Forms.ColumnHeader colBillName;
        private System.Windows.Forms.ColumnHeader colTable;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ListView lsvDetails;
        private System.Windows.Forms.ColumnHeader colFood;
        private System.Windows.Forms.ColumnHeader colQty;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFinalAmount;
        private System.Windows.Forms.TextBox txtTaxAmount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnExit;
    }
}