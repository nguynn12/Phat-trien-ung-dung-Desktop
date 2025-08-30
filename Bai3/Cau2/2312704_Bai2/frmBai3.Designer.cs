namespace _2312704_Bai2
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
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhGiaiThua = new System.Windows.Forms.RadioButton();
            this.rdNoiHoTen = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(147, 30);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(130, 26);
            this.txtHo.TabIndex = 0;
            this.txtHo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập họ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(147, 75);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(130, 26);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số n:";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(147, 123);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(130, 26);
            this.txtSoN.TabIndex = 2;
            this.txtSoN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhGiaiThua);
            this.groupBox1.Controls.Add(this.rdNoiHoTen);
            this.groupBox1.Location = new System.Drawing.Point(77, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng";
            // 
            // rdTinhGiaiThua
            // 
            this.rdTinhGiaiThua.AutoSize = true;
            this.rdTinhGiaiThua.Location = new System.Drawing.Point(22, 67);
            this.rdTinhGiaiThua.Name = "rdTinhGiaiThua";
            this.rdTinhGiaiThua.Size = new System.Drawing.Size(128, 24);
            this.rdTinhGiaiThua.TabIndex = 1;
            this.rdTinhGiaiThua.TabStop = true;
            this.rdTinhGiaiThua.Text = "Tính giai thừa";
            this.rdTinhGiaiThua.UseVisualStyleBackColor = true;
            // 
            // rdNoiHoTen
            // 
            this.rdNoiHoTen.AutoSize = true;
            this.rdNoiHoTen.Location = new System.Drawing.Point(22, 26);
            this.rdNoiHoTen.Name = "rdNoiHoTen";
            this.rdNoiHoTen.Size = new System.Drawing.Size(126, 24);
            this.rdNoiHoTen.TabIndex = 0;
            this.rdNoiHoTen.TabStop = true;
            this.rdNoiHoTen.Text = "Nối họ và tên";
            this.rdNoiHoTen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xem kết quả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(134, 330);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 25);
            this.lblKetQua.TabIndex = 1;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHo);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhGiaiThua;
        private System.Windows.Forms.RadioButton rdNoiHoTen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
    }
}