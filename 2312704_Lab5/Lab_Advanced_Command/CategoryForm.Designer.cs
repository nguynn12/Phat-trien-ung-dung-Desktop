namespace Lab_Advanced_Command
{
    partial class CategoryForm
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
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.nudType = new System.Windows.Forms.NumericUpDown();
            this.lblLoai = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Location = new System.Drawing.Point(56, 48);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(111, 20);
            this.lblTenNhom.TabIndex = 0;
            this.lblTenNhom.Text = "Name of Type:";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(173, 42);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(128, 26);
            this.txtCatName.TabIndex = 1;
            // 
            // nudType
            // 
            this.nudType.Location = new System.Drawing.Point(173, 92);
            this.nudType.Name = "nudType";
            this.nudType.Size = new System.Drawing.Size(128, 26);
            this.nudType.TabIndex = 2;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(56, 98);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(47, 20);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Type:";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(60, 142);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(83, 37);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(218, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 251);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.nudType);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblLoai);
            this.Controls.Add(this.lblTenNhom);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenNhom;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.NumericUpDown nudType;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnCancel;
    }
}