namespace BaiTapThietKeForm
{
    partial class frmBai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemTuMoi = new System.Windows.Forms.Button();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nghĩa của từ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH TỪ MỚI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "NGHĨA CỦA TỪ";
            // 
            // btnThemTuMoi
            // 
            this.btnThemTuMoi.Location = new System.Drawing.Point(208, 147);
            this.btnThemTuMoi.Name = "btnThemTuMoi";
            this.btnThemTuMoi.Size = new System.Drawing.Size(98, 23);
            this.btnThemTuMoi.TabIndex = 2;
            this.btnThemTuMoi.Text = "Thêm từ mới";
            this.btnThemTuMoi.UseVisualStyleBackColor = true;
            this.btnThemTuMoi.Click += new System.EventHandler(this.btnThemTuMoi_Click);
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(186, 67);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(135, 22);
            this.txtTuMoi.TabIndex = 0;
            this.txtTuMoi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNghia
            // 
            this.txtNghia.Location = new System.Drawing.Point(186, 119);
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(173, 22);
            this.txtNghia.TabIndex = 1;
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(469, 218);
            this.txtHienThi.Multiline = true;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.ReadOnly = true;
            this.txtHienThi.Size = new System.Drawing.Size(202, 164);
            this.txtHienThi.TabIndex = 2;
            this.txtHienThi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(122, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 164);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.btnThemTuMoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemTuMoi;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghia;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.ListBox listBox1;
    }
}