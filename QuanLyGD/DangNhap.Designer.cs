namespace QuanLyGD
{
    partial class DangNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaSinhVienDN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSinhVienDN = new System.Windows.Forms.Button();
            this.txtMatKhauSVDN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbDangNhap = new System.Windows.Forms.GroupBox();
            this.txtMaGVDN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiangVienDN = new System.Windows.Forms.Button();
            this.txtMatKhauGVDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenGVDK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAdminDN = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grbDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chào mừng đến chương trình quản lý giảng dạy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSinhVienDN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSinhVienDN);
            this.groupBox1.Controls.Add(this.txtMatKhauSVDN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(441, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sinh Viên Đăng Nhập";
            // 
            // txtMaSinhVienDN
            // 
            this.txtMaSinhVienDN.Location = new System.Drawing.Point(147, 44);
            this.txtMaSinhVienDN.Name = "txtMaSinhVienDN";
            this.txtMaSinhVienDN.Size = new System.Drawing.Size(224, 26);
            this.txtMaSinhVienDN.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Sinh Viên";
            // 
            // btnSinhVienDN
            // 
            this.btnSinhVienDN.Location = new System.Drawing.Point(243, 173);
            this.btnSinhVienDN.Name = "btnSinhVienDN";
            this.btnSinhVienDN.Size = new System.Drawing.Size(128, 29);
            this.btnSinhVienDN.TabIndex = 6;
            this.btnSinhVienDN.Text = "Đăng Nhập";
            this.btnSinhVienDN.UseVisualStyleBackColor = true;
            this.btnSinhVienDN.Click += new System.EventHandler(this.btnSinhVienDN_Click);
            // 
            // txtMatKhauSVDN
            // 
            this.txtMatKhauSVDN.Location = new System.Drawing.Point(147, 123);
            this.txtMatKhauSVDN.Name = "txtMatKhauSVDN";
            this.txtMatKhauSVDN.Size = new System.Drawing.Size(224, 26);
            this.txtMatKhauSVDN.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mật khẩu:";
            // 
            // grbDangNhap
            // 
            this.grbDangNhap.Controls.Add(this.txtMaGVDN);
            this.grbDangNhap.Controls.Add(this.label4);
            this.grbDangNhap.Controls.Add(this.btnGiangVienDN);
            this.grbDangNhap.Controls.Add(this.txtMatKhauGVDN);
            this.grbDangNhap.Controls.Add(this.label3);
            this.grbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbDangNhap.Location = new System.Drawing.Point(48, 54);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Size = new System.Drawing.Size(383, 228);
            this.grbDangNhap.TabIndex = 9;
            this.grbDangNhap.TabStop = false;
            this.grbDangNhap.Text = "Giảng Viên Đăng Nhập";
            // 
            // txtMaGVDN
            // 
            this.txtMaGVDN.Location = new System.Drawing.Point(147, 44);
            this.txtMaGVDN.Name = "txtMaGVDN";
            this.txtMaGVDN.Size = new System.Drawing.Size(224, 26);
            this.txtMaGVDN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã Giảng Viên";
            // 
            // btnGiangVienDN
            // 
            this.btnGiangVienDN.Location = new System.Drawing.Point(243, 173);
            this.btnGiangVienDN.Name = "btnGiangVienDN";
            this.btnGiangVienDN.Size = new System.Drawing.Size(128, 29);
            this.btnGiangVienDN.TabIndex = 6;
            this.btnGiangVienDN.Text = "Đăng Nhập";
            this.btnGiangVienDN.UseVisualStyleBackColor = true;
            this.btnGiangVienDN.Click += new System.EventHandler(this.btnGiangVienDN_Click);
            // 
            // txtMatKhauGVDN
            // 
            this.txtMatKhauGVDN.Location = new System.Drawing.Point(147, 123);
            this.txtMatKhauGVDN.Name = "txtMatKhauGVDN";
            this.txtMatKhauGVDN.Size = new System.Drawing.Size(224, 26);
            this.txtMatKhauGVDN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // btnOpenGVDK
            // 
            this.btnOpenGVDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenGVDK.Location = new System.Drawing.Point(48, 288);
            this.btnOpenGVDK.Name = "btnOpenGVDK";
            this.btnOpenGVDK.Size = new System.Drawing.Size(128, 29);
            this.btnOpenGVDK.TabIndex = 6;
            this.btnOpenGVDK.Text = "Đăng Ký";
            this.btnOpenGVDK.UseVisualStyleBackColor = true;
            this.btnOpenGVDK.Click += new System.EventHandler(this.btnOpenGVDK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(552, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Đăng nhập với tư cách quản trị: ";
            // 
            // lblAdminDN
            // 
            this.lblAdminDN.AutoSize = true;
            this.lblAdminDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminDN.Location = new System.Drawing.Point(737, 326);
            this.lblAdminDN.Name = "lblAdminDN";
            this.lblAdminDN.Size = new System.Drawing.Size(75, 16);
            this.lblAdminDN.TabIndex = 11;
            this.lblAdminDN.Text = "Đăng Nhập";
            this.lblAdminDN.Click += new System.EventHandler(this.lblAdminDN_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 362);
            this.Controls.Add(this.lblAdminDN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpenGVDK);
            this.Controls.Add(this.grbDangNhap);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Giảng Dạy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaSinhVienDN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSinhVienDN;
        private System.Windows.Forms.TextBox txtMatKhauSVDN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbDangNhap;
        private System.Windows.Forms.TextBox txtMaGVDN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenGVDK;
        private System.Windows.Forms.TextBox txtMatKhauGVDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiangVienDN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAdminDN;
    }
}

