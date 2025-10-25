namespace Lab_Basic_Command
{
    partial class FormChinh
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
            this.btnFood = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(93, 81);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(207, 119);
            this.btnFood.TabIndex = 0;
            this.btnFood.Text = "Món ăn";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnBills
            // 
            this.btnBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.Location = new System.Drawing.Point(471, 81);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(207, 119);
            this.btnBills.TabIndex = 0;
            this.btnBills.Text = "Hóa đơn";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(93, 273);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(207, 119);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnBan
            // 
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.Location = new System.Drawing.Point(471, 273);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(207, 119);
            this.btnBan.TabIndex = 2;
            this.btnBan.Text = "Bàn";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnBills);
            this.Controls.Add(this.btnFood);
            this.Name = "FormChinh";
            this.Text = "FormChinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnBan;
    }
}