namespace DeThiK46
{
    partial class Form1
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
            this.lblMaMH = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.nudSoTC = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblCTDT = new System.Windows.Forms.Label();
            this.lblSTC = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.cbbCTDT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaMH
            // 
            this.lblMaMH.AutoSize = true;
            this.lblMaMH.Location = new System.Drawing.Point(30, 39);
            this.lblMaMH.Name = "lblMaMH";
            this.lblMaMH.Size = new System.Drawing.Size(96, 20);
            this.lblMaMH.TabIndex = 0;
            this.lblMaMH.Text = "Mã môn học";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(173, 36);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(312, 26);
            this.txtMaMH.TabIndex = 1;
            // 
            // nudSoTC
            // 
            this.nudSoTC.Location = new System.Drawing.Point(173, 210);
            this.nudSoTC.Name = "nudSoTC";
            this.nudSoTC.Size = new System.Drawing.Size(312, 26);
            this.nudSoTC.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(192, 267);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 32);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Location = new System.Drawing.Point(30, 93);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(101, 20);
            this.lblTenMH.TabIndex = 0;
            this.lblTenMH.Text = "Tên môn học";
            // 
            // lblCTDT
            // 
            this.lblCTDT.AutoSize = true;
            this.lblCTDT.Location = new System.Drawing.Point(30, 153);
            this.lblCTDT.Name = "lblCTDT";
            this.lblCTDT.Size = new System.Drawing.Size(125, 20);
            this.lblCTDT.TabIndex = 0;
            this.lblCTDT.Text = "Chương trình ĐT";
            // 
            // lblSTC
            // 
            this.lblSTC.AutoSize = true;
            this.lblSTC.Location = new System.Drawing.Point(30, 216);
            this.lblSTC.Name = "lblSTC";
            this.lblSTC.Size = new System.Drawing.Size(74, 20);
            this.lblSTC.TabIndex = 0;
            this.lblSTC.Text = "Số tín chỉ";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(173, 87);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(312, 26);
            this.txtTenMH.TabIndex = 1;
            // 
            // cbbCTDT
            // 
            this.cbbCTDT.FormattingEnabled = true;
            this.cbbCTDT.Location = new System.Drawing.Point(173, 145);
            this.cbbCTDT.Name = "cbbCTDT";
            this.cbbCTDT.Size = new System.Drawing.Size(312, 28);
            this.cbbCTDT.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 342);
            this.Controls.Add(this.cbbCTDT);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.nudSoTC);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.lblSTC);
            this.Controls.Add(this.lblCTDT);
            this.Controls.Add(this.lblTenMH);
            this.Controls.Add(this.lblMaMH);
            this.Name = "Form1";
            this.Text = "Môn học";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.NumericUpDown nudSoTC;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblCTDT;
        private System.Windows.Forms.Label lblSTC;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.ComboBox cbbCTDT;
    }
}

