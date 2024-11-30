namespace QuanLyGD
{
    partial class KhoaLopHoc
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
            this.grpLopHoc = new System.Windows.Forms.GroupBox();
            this.btnTimKiemKhoa = new System.Windows.Forms.Button();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.txtQLTimKiemK = new System.Windows.Forms.TextBox();
            this.txtQLDiaChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQLTenKhoa = new System.Windows.Forms.TextBox();
            this.txtQLMaKhoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstKhoa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbKhoa = new System.Windows.Forms.GroupBox();
            this.btnTimKiemLop = new System.Windows.Forms.Button();
            this.txtQLMaKhoaLH = new System.Windows.Forms.TextBox();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.lstLopHoc = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQLTimKiemL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSuaLop = new System.Windows.Forms.Button();
            this.btnThemLop = new System.Windows.Forms.Button();
            this.txtQLTenLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQLMaLop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.grpLopHoc.SuspendLayout();
            this.grbKhoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLopHoc
            // 
            this.grpLopHoc.Controls.Add(this.btnTimKiemKhoa);
            this.grpLopHoc.Controls.Add(this.btnXoaKhoa);
            this.grpLopHoc.Controls.Add(this.btnSuaKhoa);
            this.grpLopHoc.Controls.Add(this.btnThemKhoa);
            this.grpLopHoc.Controls.Add(this.txtQLTimKiemK);
            this.grpLopHoc.Controls.Add(this.txtQLDiaChi);
            this.grpLopHoc.Controls.Add(this.label8);
            this.grpLopHoc.Controls.Add(this.txtQLTenKhoa);
            this.grpLopHoc.Controls.Add(this.txtQLMaKhoa);
            this.grpLopHoc.Controls.Add(this.label3);
            this.grpLopHoc.Controls.Add(this.label2);
            this.grpLopHoc.Controls.Add(this.label1);
            this.grpLopHoc.Controls.Add(this.lstKhoa);
            this.grpLopHoc.Location = new System.Drawing.Point(12, 12);
            this.grpLopHoc.Name = "grpLopHoc";
            this.grpLopHoc.Size = new System.Drawing.Size(613, 522);
            this.grpLopHoc.TabIndex = 0;
            this.grpLopHoc.TabStop = false;
            this.grpLopHoc.Text = "Quản Lý Khoa";
            this.grpLopHoc.Enter += new System.EventHandler(this.grpLopHoc_Enter);
            // 
            // btnTimKiemKhoa
            // 
            this.btnTimKiemKhoa.Location = new System.Drawing.Point(339, 471);
            this.btnTimKiemKhoa.Name = "btnTimKiemKhoa";
            this.btnTimKiemKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemKhoa.TabIndex = 8;
            this.btnTimKiemKhoa.Text = "Tìm Kiếm";
            this.btnTimKiemKhoa.UseVisualStyleBackColor = true;
            this.btnTimKiemKhoa.Click += new System.EventHandler(this.btnTimKiemKhoa_Click);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Location = new System.Drawing.Point(448, 423);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKhoa.TabIndex = 7;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = true;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Location = new System.Drawing.Point(448, 381);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnSuaKhoa.TabIndex = 6;
            this.btnSuaKhoa.Text = "Sửa";
            this.btnSuaKhoa.UseVisualStyleBackColor = true;
            this.btnSuaKhoa.Click += new System.EventHandler(this.btnSuaKhoa_Click);
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(448, 341);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(75, 23);
            this.btnThemKhoa.TabIndex = 5;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // txtQLTimKiemK
            // 
            this.txtQLTimKiemK.Location = new System.Drawing.Point(125, 471);
            this.txtQLTimKiemK.Name = "txtQLTimKiemK";
            this.txtQLTimKiemK.Size = new System.Drawing.Size(169, 20);
            this.txtQLTimKiemK.TabIndex = 4;
            // 
            // txtQLDiaChi
            // 
            this.txtQLDiaChi.Location = new System.Drawing.Point(128, 433);
            this.txtQLDiaChi.Name = "txtQLDiaChi";
            this.txtQLDiaChi.Size = new System.Drawing.Size(169, 20);
            this.txtQLDiaChi.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tìm kiếm khoa";
            // 
            // txtQLTenKhoa
            // 
            this.txtQLTenKhoa.Location = new System.Drawing.Point(128, 391);
            this.txtQLTenKhoa.Name = "txtQLTenKhoa";
            this.txtQLTenKhoa.Size = new System.Drawing.Size(169, 20);
            this.txtQLTenKhoa.TabIndex = 2;
            // 
            // txtQLMaKhoa
            // 
            this.txtQLMaKhoa.Location = new System.Drawing.Point(128, 352);
            this.txtQLMaKhoa.Name = "txtQLMaKhoa";
            this.txtQLMaKhoa.Size = new System.Drawing.Size(169, 20);
            this.txtQLMaKhoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa Chỉ Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Khoa";
            // 
            // lstKhoa
            // 
            this.lstKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstKhoa.FullRowSelect = true;
            this.lstKhoa.GridLines = true;
            this.lstKhoa.HideSelection = false;
            this.lstKhoa.Location = new System.Drawing.Point(6, 19);
            this.lstKhoa.Name = "lstKhoa";
            this.lstKhoa.Size = new System.Drawing.Size(601, 299);
            this.lstKhoa.TabIndex = 0;
            this.lstKhoa.UseCompatibleStateImageBehavior = false;
            this.lstKhoa.View = System.Windows.Forms.View.Details;
            this.lstKhoa.SelectedIndexChanged += new System.EventHandler(this.lstKhoa_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Khoa";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Khoa";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Địa Chỉ Khoa";
            this.columnHeader3.Width = 120;
            // 
            // grbKhoa
            // 
            this.grbKhoa.Controls.Add(this.btnTimKiemLop);
            this.grbKhoa.Controls.Add(this.txtQLMaKhoaLH);
            this.grbKhoa.Controls.Add(this.btnXoaLop);
            this.grbKhoa.Controls.Add(this.lstLopHoc);
            this.grbKhoa.Controls.Add(this.txtQLTimKiemL);
            this.grbKhoa.Controls.Add(this.label7);
            this.grbKhoa.Controls.Add(this.btnSuaLop);
            this.grbKhoa.Controls.Add(this.btnThemLop);
            this.grbKhoa.Controls.Add(this.txtQLTenLop);
            this.grbKhoa.Controls.Add(this.label4);
            this.grbKhoa.Controls.Add(this.txtQLMaLop);
            this.grbKhoa.Controls.Add(this.label5);
            this.grbKhoa.Controls.Add(this.label6);
            this.grbKhoa.Location = new System.Drawing.Point(716, 12);
            this.grbKhoa.Name = "grbKhoa";
            this.grbKhoa.Size = new System.Drawing.Size(613, 522);
            this.grbKhoa.TabIndex = 1;
            this.grbKhoa.TabStop = false;
            this.grbKhoa.Text = "Quản Lý Lớp Học";
            // 
            // btnTimKiemLop
            // 
            this.btnTimKiemLop.Location = new System.Drawing.Point(340, 471);
            this.btnTimKiemLop.Name = "btnTimKiemLop";
            this.btnTimKiemLop.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemLop.TabIndex = 8;
            this.btnTimKiemLop.Text = "Tìm Kiếm";
            this.btnTimKiemLop.UseVisualStyleBackColor = true;
            this.btnTimKiemLop.Click += new System.EventHandler(this.btnTimKiemLop_Click);
            // 
            // txtQLMaKhoaLH
            // 
            this.txtQLMaKhoaLH.Location = new System.Drawing.Point(128, 433);
            this.txtQLMaKhoaLH.Name = "txtQLMaKhoaLH";
            this.txtQLMaKhoaLH.Size = new System.Drawing.Size(169, 20);
            this.txtQLMaKhoaLH.TabIndex = 2;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(449, 423);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLop.TabIndex = 7;
            this.btnXoaLop.Text = "Xóa";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // lstLopHoc
            // 
            this.lstLopHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstLopHoc.FullRowSelect = true;
            this.lstLopHoc.GridLines = true;
            this.lstLopHoc.HideSelection = false;
            this.lstLopHoc.Location = new System.Drawing.Point(6, 19);
            this.lstLopHoc.Name = "lstLopHoc";
            this.lstLopHoc.Size = new System.Drawing.Size(601, 299);
            this.lstLopHoc.TabIndex = 0;
            this.lstLopHoc.UseCompatibleStateImageBehavior = false;
            this.lstLopHoc.View = System.Windows.Forms.View.Details;
            this.lstLopHoc.SelectedIndexChanged += new System.EventHandler(this.lstLopHoc_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã Lớp";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên Lớp";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã Khoa";
            this.columnHeader6.Width = 100;
            // 
            // txtQLTimKiemL
            // 
            this.txtQLTimKiemL.Location = new System.Drawing.Point(128, 474);
            this.txtQLTimKiemL.Name = "txtQLTimKiemL";
            this.txtQLTimKiemL.Size = new System.Drawing.Size(169, 20);
            this.txtQLTimKiemL.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tìm kiếm lớp";
            // 
            // btnSuaLop
            // 
            this.btnSuaLop.Location = new System.Drawing.Point(449, 381);
            this.btnSuaLop.Name = "btnSuaLop";
            this.btnSuaLop.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLop.TabIndex = 6;
            this.btnSuaLop.Text = "Sửa";
            this.btnSuaLop.UseVisualStyleBackColor = true;
            this.btnSuaLop.Click += new System.EventHandler(this.btnSuaLop_Click);
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(449, 341);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(75, 23);
            this.btnThemLop.TabIndex = 5;
            this.btnThemLop.Text = "Thêm";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // txtQLTenLop
            // 
            this.txtQLTenLop.Location = new System.Drawing.Point(128, 391);
            this.txtQLTenLop.Name = "txtQLTenLop";
            this.txtQLTenLop.Size = new System.Drawing.Size(169, 20);
            this.txtQLTenLop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Lớp";
            // 
            // txtQLMaLop
            // 
            this.txtQLMaLop.Location = new System.Drawing.Point(128, 352);
            this.txtQLMaLop.Name = "txtQLMaLop";
            this.txtQLMaLop.Size = new System.Drawing.Size(169, 20);
            this.txtQLMaLop.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã Khoa";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(18, 561);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 2;
            this.button9.Text = "Trở Lại";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // KhoaLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 596);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.grbKhoa);
            this.Controls.Add(this.grpLopHoc);
            this.Name = "KhoaLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhoaLopHoc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KhoaLopHoc_FormClosing);
            this.Load += new System.EventHandler(this.KhoaLopHoc_Load);
            this.grpLopHoc.ResumeLayout(false);
            this.grpLopHoc.PerformLayout();
            this.grbKhoa.ResumeLayout(false);
            this.grbKhoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLopHoc;
        private System.Windows.Forms.GroupBox grbKhoa;
        private System.Windows.Forms.Button btnTimKiemKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.TextBox txtQLTimKiemK;
        private System.Windows.Forms.TextBox txtQLDiaChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQLTenKhoa;
        private System.Windows.Forms.TextBox txtQLMaKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstKhoa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnTimKiemLop;
        private System.Windows.Forms.TextBox txtQLMaKhoaLH;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.ListView lstLopHoc;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtQLTimKiemL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSuaLop;
        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.TextBox txtQLTenLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQLMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button9;
    }
}