namespace _2312704_Lab3_PhanC
{
    partial class FormTimKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTheoMSSV = new System.Windows.Forms.RadioButton();
            this.rdTheoTen = new System.Windows.Forms.RadioButton();
            this.rdTheoLop = new System.Windows.Forms.RadioButton();
            this.txtTimSV = new System.Windows.Forms.TextBox();
            this.btnTimSV = new System.Windows.Forms.Button();
            this.lblTimSV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTimSV);
            this.groupBox1.Controls.Add(this.btnTimSV);
            this.groupBox1.Controls.Add(this.txtTimSV);
            this.groupBox1.Controls.Add(this.rdTheoLop);
            this.groupBox1.Controls.Add(this.rdTheoTen);
            this.groupBox1.Controls.Add(this.rdTheoMSSV);
            this.groupBox1.Location = new System.Drawing.Point(46, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sinh viên";
            // 
            // rdTheoMSSV
            // 
            this.rdTheoMSSV.AutoSize = true;
            this.rdTheoMSSV.Checked = true;
            this.rdTheoMSSV.Location = new System.Drawing.Point(35, 37);
            this.rdTheoMSSV.Name = "rdTheoMSSV";
            this.rdTheoMSSV.Size = new System.Drawing.Size(120, 24);
            this.rdTheoMSSV.TabIndex = 0;
            this.rdTheoMSSV.TabStop = true;
            this.rdTheoMSSV.Text = "Theo MSSV";
            this.rdTheoMSSV.UseVisualStyleBackColor = true;
            // 
            // rdTheoTen
            // 
            this.rdTheoTen.AutoSize = true;
            this.rdTheoTen.Location = new System.Drawing.Point(198, 37);
            this.rdTheoTen.Name = "rdTheoTen";
            this.rdTheoTen.Size = new System.Drawing.Size(97, 24);
            this.rdTheoTen.TabIndex = 0;
            this.rdTheoTen.Text = "Theo tên";
            this.rdTheoTen.UseVisualStyleBackColor = true;
            // 
            // rdTheoLop
            // 
            this.rdTheoLop.AutoSize = true;
            this.rdTheoLop.Location = new System.Drawing.Point(347, 37);
            this.rdTheoLop.Name = "rdTheoLop";
            this.rdTheoLop.Size = new System.Drawing.Size(95, 24);
            this.rdTheoLop.TabIndex = 0;
            this.rdTheoLop.Text = "Theo lớp";
            this.rdTheoLop.UseVisualStyleBackColor = true;
            // 
            // txtTimSV
            // 
            this.txtTimSV.Location = new System.Drawing.Point(139, 101);
            this.txtTimSV.Name = "txtTimSV";
            this.txtTimSV.Size = new System.Drawing.Size(184, 26);
            this.txtTimSV.TabIndex = 1;
            // 
            // btnTimSV
            // 
            this.btnTimSV.Location = new System.Drawing.Point(347, 98);
            this.btnTimSV.Name = "btnTimSV";
            this.btnTimSV.Size = new System.Drawing.Size(95, 32);
            this.btnTimSV.TabIndex = 2;
            this.btnTimSV.Text = "Tìm";
            this.btnTimSV.UseVisualStyleBackColor = true;
            this.btnTimSV.Click += new System.EventHandler(this.btnTimSV_Click);
            // 
            // lblTimSV
            // 
            this.lblTimSV.AutoSize = true;
            this.lblTimSV.Location = new System.Drawing.Point(31, 104);
            this.lblTimSV.Name = "lblTimSV";
            this.lblTimSV.Size = new System.Drawing.Size(55, 20);
            this.lblTimSV.TabIndex = 1;
            this.lblTimSV.Text = "MSSV";
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 389);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTimKiem";
            this.Text = "FormTimKiem";
            this.Load += new System.EventHandler(this.FormTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTheoLop;
        private System.Windows.Forms.RadioButton rdTheoTen;
        private System.Windows.Forms.RadioButton rdTheoMSSV;
        private System.Windows.Forms.Label lblTimSV;
        private System.Windows.Forms.Button btnTimSV;
        private System.Windows.Forms.TextBox txtTimSV;
    }
}