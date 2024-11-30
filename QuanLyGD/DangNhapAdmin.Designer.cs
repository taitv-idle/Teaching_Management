namespace QuanLyGD
{
    partial class DangNhapAdmin
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
            this.grbDangNhap = new System.Windows.Forms.GroupBox();
            this.btnAdminTL = new System.Windows.Forms.Button();
            this.btnAdminDN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminTK = new System.Windows.Forms.TextBox();
            this.grbDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDangNhap
            // 
            this.grbDangNhap.Controls.Add(this.btnAdminTL);
            this.grbDangNhap.Controls.Add(this.btnAdminDN);
            this.grbDangNhap.Controls.Add(this.label2);
            this.grbDangNhap.Controls.Add(this.txtAdminMK);
            this.grbDangNhap.Controls.Add(this.label3);
            this.grbDangNhap.Controls.Add(this.txtAdminTK);
            this.grbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbDangNhap.Location = new System.Drawing.Point(38, -2);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Size = new System.Drawing.Size(383, 213);
            this.grbDangNhap.TabIndex = 8;
            this.grbDangNhap.TabStop = false;
            this.grbDangNhap.Text = "Đăng Nhập";
            // 
            // btnAdminTL
            // 
            this.btnAdminTL.Location = new System.Drawing.Point(31, 167);
            this.btnAdminTL.Name = "btnAdminTL";
            this.btnAdminTL.Size = new System.Drawing.Size(128, 29);
            this.btnAdminTL.TabIndex = 9;
            this.btnAdminTL.Text = "Trở Lại";
            this.btnAdminTL.UseVisualStyleBackColor = true;
            this.btnAdminTL.Click += new System.EventHandler(this.btnGiangVienDN_Click);
            // 
            // btnAdminDN
            // 
            this.btnAdminDN.Location = new System.Drawing.Point(243, 167);
            this.btnAdminDN.Name = "btnAdminDN";
            this.btnAdminDN.Size = new System.Drawing.Size(128, 29);
            this.btnAdminDN.TabIndex = 10;
            this.btnAdminDN.Text = "Đăng Nhập";
            this.btnAdminDN.UseVisualStyleBackColor = true;
            this.btnAdminDN.Click += new System.EventHandler(this.btnAdminDN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản";
            // 
            // txtAdminMK
            // 
            this.txtAdminMK.Location = new System.Drawing.Point(147, 94);
            this.txtAdminMK.Name = "txtAdminMK";
            this.txtAdminMK.PasswordChar = '*';
            this.txtAdminMK.Size = new System.Drawing.Size(224, 26);
            this.txtAdminMK.TabIndex = 4;
            this.txtAdminMK.Text = "2010";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtAdminTK
            // 
            this.txtAdminTK.Location = new System.Drawing.Point(147, 56);
            this.txtAdminTK.Name = "txtAdminTK";
            this.txtAdminTK.Size = new System.Drawing.Size(224, 26);
            this.txtAdminTK.TabIndex = 3;
            this.txtAdminTK.Text = "admin";
            // 
            // DangNhapAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 248);
            this.Controls.Add(this.grbDangNhap);
            this.MaximizeBox = false;
            this.Name = "DangNhapAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhapAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhapAdmin_FormClosing);
            this.Load += new System.EventHandler(this.DangNhapAdmin_Load);
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDangNhap;
        private System.Windows.Forms.Button btnAdminTL;
        private System.Windows.Forms.Button btnAdminDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminTK;
    }
}