namespace Lab07_Entity_Framework
{
    partial class UpdateFoodForm
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
            this.lblMaSo = new System.Windows.Forms.Label();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.cbbFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodNotes = new System.Windows.Forms.RichTextBox();
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.lblThuocDanhMuc = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblDVT = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodUnit = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Location = new System.Drawing.Point(32, 22);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(56, 20);
            this.lblMaSo.TabIndex = 0;
            this.lblMaSo.Text = "Mã số:";
            // 
            // txtFoodId
            // 
            this.txtFoodId.Location = new System.Drawing.Point(189, 19);
            this.txtFoodId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.ReadOnly = true;
            this.txtFoodId.Size = new System.Drawing.Size(250, 26);
            this.txtFoodId.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(240, 398);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudFoodPrice
            // 
            this.nudFoodPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudFoodPrice.Location = new System.Drawing.Point(189, 192);
            this.nudFoodPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudFoodPrice.Name = "nudFoodPrice";
            this.nudFoodPrice.Size = new System.Drawing.Size(250, 26);
            this.nudFoodPrice.TabIndex = 3;
            this.nudFoodPrice.ThousandsSeparator = true;
            // 
            // cbbFoodCategory
            // 
            this.cbbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFoodCategory.FormattingEnabled = true;
            this.cbbFoodCategory.Location = new System.Drawing.Point(189, 104);
            this.cbbFoodCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbFoodCategory.Name = "cbbFoodCategory";
            this.cbbFoodCategory.Size = new System.Drawing.Size(250, 28);
            this.cbbFoodCategory.TabIndex = 4;
            // 
            // txtFoodNotes
            // 
            this.txtFoodNotes.Location = new System.Drawing.Point(189, 235);
            this.txtFoodNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFoodNotes.Name = "txtFoodNotes";
            this.txtFoodNotes.Size = new System.Drawing.Size(249, 119);
            this.txtFoodNotes.TabIndex = 5;
            this.txtFoodNotes.Text = "";
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.AutoSize = true;
            this.lblTenMonAn.Location = new System.Drawing.Point(32, 65);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(93, 20);
            this.lblTenMonAn.TabIndex = 0;
            this.lblTenMonAn.Text = "Tên món ăn";
            // 
            // lblThuocDanhMuc
            // 
            this.lblThuocDanhMuc.AutoSize = true;
            this.lblThuocDanhMuc.Location = new System.Drawing.Point(32, 108);
            this.lblThuocDanhMuc.Name = "lblThuocDanhMuc";
            this.lblThuocDanhMuc.Size = new System.Drawing.Size(127, 20);
            this.lblThuocDanhMuc.TabIndex = 0;
            this.lblThuocDanhMuc.Text = "Thuộc danh mục";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(32, 192);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(64, 20);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblDVT
            // 
            this.lblDVT.AutoSize = true;
            this.lblDVT.Location = new System.Drawing.Point(32, 150);
            this.lblDVT.Name = "lblDVT";
            this.lblDVT.Size = new System.Drawing.Size(83, 20);
            this.lblDVT.TabIndex = 0;
            this.lblDVT.Text = "Đơn vị tính";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(32, 235);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(106, 20);
            this.lblGhiChu.TabIndex = 0;
            this.lblGhiChu.Text = "Ghi chú khác:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(189, 58);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(250, 26);
            this.txtFoodName.TabIndex = 1;
            // 
            // txtFoodUnit
            // 
            this.txtFoodUnit.Location = new System.Drawing.Point(189, 150);
            this.txtFoodUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFoodUnit.Name = "txtFoodUnit";
            this.txtFoodUnit.Size = new System.Drawing.Size(250, 26);
            this.txtFoodUnit.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(354, 398);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 29);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // UpdateFoodForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(530, 472);
            this.ControlBox = false;
            this.Controls.Add(this.txtFoodNotes);
            this.Controls.Add(this.cbbFoodCategory);
            this.Controls.Add(this.nudFoodPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFoodUnit);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.txtFoodId);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblDVT);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblThuocDanhMuc);
            this.Controls.Add(this.lblTenMonAn);
            this.Controls.Add(this.lblMaSo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm/Cập nhật món ăn";
            this.Load += new System.EventHandler(this.UpdateFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudFoodPrice;
        private System.Windows.Forms.ComboBox cbbFoodCategory;
        private System.Windows.Forms.RichTextBox txtFoodNotes;
        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.Label lblThuocDanhMuc;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblDVT;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodUnit;
        private System.Windows.Forms.Button btnCancel;
    }
}