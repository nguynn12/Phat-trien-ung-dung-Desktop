namespace _2312704_Lab3
{
    partial class frmReadJsonFile
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
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnDocFileXML = new System.Windows.Forms.Button();
            this.btnGhiDuLieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.Location = new System.Drawing.Point(255, 112);
            this.btnDocFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(251, 65);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc file JSON";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnDocFileXML
            // 
            this.btnDocFileXML.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFileXML.Location = new System.Drawing.Point(255, 207);
            this.btnDocFileXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDocFileXML.Name = "btnDocFileXML";
            this.btnDocFileXML.Size = new System.Drawing.Size(251, 65);
            this.btnDocFileXML.TabIndex = 1;
            this.btnDocFileXML.Text = "Đọc file XML";
            this.btnDocFileXML.UseVisualStyleBackColor = true;
            this.btnDocFileXML.Click += new System.EventHandler(this.btnDocFileXML_Click);
            // 
            // btnGhiDuLieu
            // 
            this.btnGhiDuLieu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiDuLieu.Location = new System.Drawing.Point(255, 299);
            this.btnGhiDuLieu.Name = "btnGhiDuLieu";
            this.btnGhiDuLieu.Size = new System.Drawing.Size(251, 65);
            this.btnGhiDuLieu.TabIndex = 2;
            this.btnGhiDuLieu.Text = "Ghi dữ liệu ra file";
            this.btnGhiDuLieu.UseVisualStyleBackColor = true;
            this.btnGhiDuLieu.Click += new System.EventHandler(this.btnGhiDuLieu_Click);
            // 
            // frmReadJsonFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGhiDuLieu);
            this.Controls.Add(this.btnDocFileXML);
            this.Controls.Add(this.btnDocFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReadJsonFile";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnDocFileXML;
        private System.Windows.Forms.Button btnGhiDuLieu;
    }
}

