namespace _2312704_Bai2
{
    partial class frmBai2
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
            this.btnKetQua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(180, 300);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(138, 41);
            this.btnKetQua.TabIndex = 2;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số thứ nhất: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChia);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Location = new System.Drawing.Point(152, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán:";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(152, 27);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(142, 26);
            this.txtSoThuNhat.TabIndex = 0;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(152, 84);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(142, 26);
            this.txtSoThuHai.TabIndex = 1;
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Location = new System.Drawing.Point(16, 25);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(72, 24);
            this.rdCong.TabIndex = 0;
            this.rdCong.TabStop = true;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Location = new System.Drawing.Point(16, 55);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(57, 24);
            this.rdTru.TabIndex = 1;
            this.rdTru.TabStop = true;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(16, 85);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(72, 24);
            this.rdNhan.TabIndex = 2;
            this.rdNhan.TabStop = true;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            this.rdNhan.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(16, 115);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(66, 24);
            this.rdChia.TabIndex = 3;
            this.rdChia.TabStop = true;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kết quả là: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(256, 369);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 25);
            this.lblKetQua.TabIndex = 1;
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKetQua);
            this.Name = "frmBai2";
            this.Text = "frmBai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKetQua;
    }
}