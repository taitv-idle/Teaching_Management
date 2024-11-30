namespace QuanLyGD
{
    partial class QuanLy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQL = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLGV = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQLMH = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQLSV = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQLLH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLichGD = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.sốLượngKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.grbGiangVien = new System.Windows.Forms.GroupBox();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.btnLamMoiGV = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.txtTimKiemMGV = new System.Windows.Forms.TextBox();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstGiangVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbMonHoc = new System.Windows.Forms.GroupBox();
            this.btnTimMH = new System.Windows.Forms.Button();
            this.cboMaKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimTheoTenMH = new System.Windows.Forms.TextBox();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLamMoiMH = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.lstMonHoc = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.grbGiangVien.SuspendLayout();
            this.grbMonHoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQL,
            this.menuLichGD,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1341, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuQL
            // 
            this.menuQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLGV,
            this.MenuQLMH,
            this.MenuQLSV,
            this.MenuQLLH});
            this.menuQL.Name = "menuQL";
            this.menuQL.Size = new System.Drawing.Size(125, 20);
            this.menuQL.Text = "Chức Năng Quản Lý";
            // 
            // menuQLGV
            // 
            this.menuQLGV.Name = "menuQLGV";
            this.menuQLGV.Size = new System.Drawing.Size(210, 22);
            this.menuQLGV.Text = "Quản Lý Giảng Viên";
            this.menuQLGV.Click += new System.EventHandler(this.menuQLGV_Click);
            // 
            // MenuQLMH
            // 
            this.MenuQLMH.Name = "MenuQLMH";
            this.MenuQLMH.Size = new System.Drawing.Size(210, 22);
            this.MenuQLMH.Text = "Quản Lý Môn Học";
            this.MenuQLMH.Click += new System.EventHandler(this.MenuQLMHToolStripMenuItem_Click);
            // 
            // MenuQLSV
            // 
            this.MenuQLSV.Name = "MenuQLSV";
            this.MenuQLSV.Size = new System.Drawing.Size(210, 22);
            this.MenuQLSV.Text = "Quản Lý Sinh Viên";
            this.MenuQLSV.Click += new System.EventHandler(this.MenuQLSV_Click);
            // 
            // MenuQLLH
            // 
            this.MenuQLLH.Name = "MenuQLLH";
            this.MenuQLLH.Size = new System.Drawing.Size(210, 22);
            this.MenuQLLH.Text = "Quản Lý Khoa và Lớp Học";
            this.MenuQLLH.Click += new System.EventHandler(this.MenuQLLH_Click);
            // 
            // menuLichGD
            // 
            this.menuLichGD.Name = "menuLichGD";
            this.menuLichGD.Size = new System.Drawing.Size(96, 20);
            this.menuLichGD.Text = "Lịch giảng dạy";
            this.menuLichGD.Click += new System.EventHandler(this.menuLichGDToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGiangVien,
            this.mniSinhVien,
            this.sốLượngKhoaToolStripMenuItem,
            this.mniMonHoc,
            this.mniLopHoc});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // mniGiangVien
            // 
            this.mniGiangVien.Name = "mniGiangVien";
            this.mniGiangVien.Size = new System.Drawing.Size(184, 22);
            this.mniGiangVien.Text = "Số Lượng Giảng Viên";
            this.mniGiangVien.Click += new System.EventHandler(this.mniGiangVien_Click);
            // 
            // mniSinhVien
            // 
            this.mniSinhVien.Name = "mniSinhVien";
            this.mniSinhVien.Size = new System.Drawing.Size(184, 22);
            this.mniSinhVien.Text = "Số Lượng Sinh Viên";
            this.mniSinhVien.Click += new System.EventHandler(this.mniSinhVien_Click);
            // 
            // sốLượngKhoaToolStripMenuItem
            // 
            this.sốLượngKhoaToolStripMenuItem.Name = "sốLượngKhoaToolStripMenuItem";
            this.sốLượngKhoaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sốLượngKhoaToolStripMenuItem.Text = "Số Lượng Khoa";
            this.sốLượngKhoaToolStripMenuItem.Click += new System.EventHandler(this.sốLượngKhoaToolStripMenuItem_Click);
            // 
            // mniMonHoc
            // 
            this.mniMonHoc.Name = "mniMonHoc";
            this.mniMonHoc.Size = new System.Drawing.Size(184, 22);
            this.mniMonHoc.Text = "Số Lượng Môn Học";
            this.mniMonHoc.Click += new System.EventHandler(this.mniMonHoc_Click);
            // 
            // mniLopHoc
            // 
            this.mniLopHoc.Name = "mniLopHoc";
            this.mniLopHoc.Size = new System.Drawing.Size(184, 22);
            this.mniLopHoc.Text = "Số Lượng Lớp Học";
            this.mniLopHoc.Click += new System.EventHandler(this.mniLopHoc_Click);
            // 
            // grbGiangVien
            // 
            this.grbGiangVien.Controls.Add(this.btnThemGV);
            this.grbGiangVien.Controls.Add(this.btnLamMoiGV);
            this.grbGiangVien.Controls.Add(this.btnTimKiem);
            this.grbGiangVien.Controls.Add(this.btnXoaGV);
            this.grbGiangVien.Controls.Add(this.txtTimKiemMGV);
            this.grbGiangVien.Controls.Add(this.btnSuaGV);
            this.grbGiangVien.Controls.Add(this.label1);
            this.grbGiangVien.Controls.Add(this.lstGiangVien);
            this.grbGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGiangVien.Location = new System.Drawing.Point(6, 27);
            this.grbGiangVien.Name = "grbGiangVien";
            this.grbGiangVien.Size = new System.Drawing.Size(1329, 557);
            this.grbGiangVien.TabIndex = 1;
            this.grbGiangVien.TabStop = false;
            this.grbGiangVien.Text = "Quản Lý Gỉang Viên";
            // 
            // btnThemGV
            // 
            this.btnThemGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGV.Location = new System.Drawing.Point(1215, 38);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(108, 35);
            this.btnThemGV.TabIndex = 1;
            this.btnThemGV.Text = "Thêm GV";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // btnLamMoiGV
            // 
            this.btnLamMoiGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiGV.Location = new System.Drawing.Point(1215, 198);
            this.btnLamMoiGV.Name = "btnLamMoiGV";
            this.btnLamMoiGV.Size = new System.Drawing.Size(108, 35);
            this.btnLamMoiGV.TabIndex = 6;
            this.btnLamMoiGV.Text = "Làm Mới";
            this.btnLamMoiGV.UseVisualStyleBackColor = true;
            this.btnLamMoiGV.Click += new System.EventHandler(this.btnLamMoiGV_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(310, 519);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(67, 33);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGV.Location = new System.Drawing.Point(1215, 146);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(108, 35);
            this.btnXoaGV.TabIndex = 2;
            this.btnXoaGV.Text = "Xóa GV";
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // txtTimKiemMGV
            // 
            this.txtTimKiemMGV.Location = new System.Drawing.Point(188, 520);
            this.txtTimKiemMGV.Name = "txtTimKiemMGV";
            this.txtTimKiemMGV.Size = new System.Drawing.Size(100, 29);
            this.txtTimKiemMGV.TabIndex = 5;
            this.txtTimKiemMGV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiemMGV_KeyPress);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGV.Location = new System.Drawing.Point(1215, 93);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(108, 35);
            this.btnSuaGV.TabIndex = 3;
            this.btnSuaGV.Text = "Sửa GV";
            this.btnSuaGV.UseVisualStyleBackColor = true;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tìm Kiếm Theo Mã GV";
            // 
            // lstGiangVien
            // 
            this.lstGiangVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lstGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGiangVien.FullRowSelect = true;
            this.lstGiangVien.GridLines = true;
            this.lstGiangVien.HideSelection = false;
            this.lstGiangVien.Location = new System.Drawing.Point(6, 28);
            this.lstGiangVien.Name = "lstGiangVien";
            this.lstGiangVien.Size = new System.Drawing.Size(1197, 480);
            this.lstGiangVien.TabIndex = 0;
            this.lstGiangVien.UseCompatibleStateImageBehavior = false;
            this.lstGiangVien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã GV";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Tên";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày Sinh";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới Tính";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Địa Chỉ";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Điện Thoại";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã Khoa";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mật Khẩu";
            this.columnHeader9.Width = 100;
            // 
            // grbMonHoc
            // 
            this.grbMonHoc.Controls.Add(this.btnTimMH);
            this.grbMonHoc.Controls.Add(this.cboMaKhoa);
            this.grbMonHoc.Controls.Add(this.label5);
            this.grbMonHoc.Controls.Add(this.txtTimTheoTenMH);
            this.grbMonHoc.Controls.Add(this.txtSoTC);
            this.grbMonHoc.Controls.Add(this.txtTenMH);
            this.grbMonHoc.Controls.Add(this.txtMaMH);
            this.grbMonHoc.Controls.Add(this.txtMaKhoa);
            this.grbMonHoc.Controls.Add(this.label4);
            this.grbMonHoc.Controls.Add(this.label3);
            this.grbMonHoc.Controls.Add(this.label2);
            this.grbMonHoc.Controls.Add(this.btnLamMoiMH);
            this.grbMonHoc.Controls.Add(this.btnXoaMH);
            this.grbMonHoc.Controls.Add(this.btnSuaMH);
            this.grbMonHoc.Controls.Add(this.btnThemMH);
            this.grbMonHoc.Controls.Add(this.lstMonHoc);
            this.grbMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMonHoc.Location = new System.Drawing.Point(12, 27);
            this.grbMonHoc.Name = "grbMonHoc";
            this.grbMonHoc.Size = new System.Drawing.Size(1323, 542);
            this.grbMonHoc.TabIndex = 8;
            this.grbMonHoc.TabStop = false;
            this.grbMonHoc.Text = "Quản Lý Môn Học";
            // 
            // btnTimMH
            // 
            this.btnTimMH.Location = new System.Drawing.Point(1242, 406);
            this.btnTimMH.Name = "btnTimMH";
            this.btnTimMH.Size = new System.Drawing.Size(75, 29);
            this.btnTimMH.TabIndex = 11;
            this.btnTimMH.Text = "Tìm";
            this.btnTimMH.UseVisualStyleBackColor = true;
            this.btnTimMH.Click += new System.EventHandler(this.btnTimMH_Click);
            // 
            // cboMaKhoa
            // 
            this.cboMaKhoa.DisplayMember = "MaKhoa";
            this.cboMaKhoa.FormattingEnabled = true;
            this.cboMaKhoa.Location = new System.Drawing.Point(992, 185);
            this.cboMaKhoa.Name = "cboMaKhoa";
            this.cboMaKhoa.Size = new System.Drawing.Size(325, 32);
            this.cboMaKhoa.TabIndex = 10;
            this.cboMaKhoa.ValueMember = "MaKhoa";
            this.cboMaKhoa.SelectedIndexChanged += new System.EventHandler(this.cboMaKhoa_SelectedIndexChanged);
            this.cboMaKhoa.Click += new System.EventHandler(this.cboMaKhoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(870, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tìm Theo Tên MH";
            // 
            // txtTimTheoTenMH
            // 
            this.txtTimTheoTenMH.Location = new System.Drawing.Point(1023, 406);
            this.txtTimTheoTenMH.Name = "txtTimTheoTenMH";
            this.txtTimTheoTenMH.Size = new System.Drawing.Size(169, 29);
            this.txtTimTheoTenMH.TabIndex = 8;
            // 
            // txtSoTC
            // 
            this.txtSoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTC.Location = new System.Drawing.Point(992, 144);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(325, 29);
            this.txtSoTC.TabIndex = 6;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.Location = new System.Drawing.Point(992, 97);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(325, 29);
            this.txtTenMH.TabIndex = 6;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(992, 52);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(325, 29);
            this.txtMaMH.TabIndex = 6;
            this.txtMaMH.TextChanged += new System.EventHandler(this.txtMaMH_TextChanged);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.AutoSize = true;
            this.txtMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhoa.Location = new System.Drawing.Point(897, 188);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(85, 24);
            this.txtMaKhoa.TabIndex = 5;
            this.txtMaKhoa.Text = "Mã Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(897, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số TC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(897, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên MH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(897, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã MH";
            // 
            // btnLamMoiMH
            // 
            this.btnLamMoiMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiMH.Location = new System.Drawing.Point(1017, 348);
            this.btnLamMoiMH.Name = "btnLamMoiMH";
            this.btnLamMoiMH.Size = new System.Drawing.Size(108, 35);
            this.btnLamMoiMH.TabIndex = 4;
            this.btnLamMoiMH.Text = "Làm Mới";
            this.btnLamMoiMH.UseVisualStyleBackColor = true;
            this.btnLamMoiMH.Click += new System.EventHandler(this.btnLamMoiMH_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMH.Location = new System.Drawing.Point(874, 348);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(108, 35);
            this.btnXoaMH.TabIndex = 3;
            this.btnXoaMH.Text = "Xóa MH";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            this.btnXoaMH.Click += new System.EventHandler(this.btnXoaMH_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMH.Location = new System.Drawing.Point(1017, 284);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(108, 35);
            this.btnSuaMH.TabIndex = 2;
            this.btnSuaMH.Text = "Sửa MH";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMH.Location = new System.Drawing.Point(874, 284);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(108, 35);
            this.btnThemMH.TabIndex = 1;
            this.btnThemMH.Text = "Thêm MH";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // lstMonHoc
            // 
            this.lstMonHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lstMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMonHoc.FullRowSelect = true;
            this.lstMonHoc.GridLines = true;
            this.lstMonHoc.HideSelection = false;
            this.lstMonHoc.Location = new System.Drawing.Point(23, 38);
            this.lstMonHoc.Name = "lstMonHoc";
            this.lstMonHoc.Size = new System.Drawing.Size(774, 493);
            this.lstMonHoc.TabIndex = 0;
            this.lstMonHoc.UseCompatibleStateImageBehavior = false;
            this.lstMonHoc.View = System.Windows.Forms.View.Details;
            this.lstMonHoc.SelectedIndexChanged += new System.EventHandler(this.lstMonHoc_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã Môn Học";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Tên Môn Học";
            this.columnHeader11.Width = 400;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Số Tín Chỉ";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Mã Khoa";
            this.columnHeader13.Width = 100;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 596);
            this.Controls.Add(this.grbMonHoc);
            this.Controls.Add(this.grbGiangVien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Giảng Dạy";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbGiangVien.ResumeLayout(false);
            this.grbGiangVien.PerformLayout();
            this.grbMonHoc.ResumeLayout(false);
            this.grbMonHoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQL;
        private System.Windows.Forms.ToolStripMenuItem menuQLGV;
        private System.Windows.Forms.ToolStripMenuItem MenuQLMH;
        private System.Windows.Forms.ToolStripMenuItem menuLichGD;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbGiangVien;
        private System.Windows.Forms.ListView lstGiangVien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.TextBox txtTimKiemMGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoiGV;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grbMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimTheoTenMH;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label txtMaKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLamMoiMH;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.ListView lstMonHoc;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ComboBox cboMaKhoa;
        private System.Windows.Forms.Button btnTimMH;
        private System.Windows.Forms.ToolStripMenuItem MenuQLSV;
        private System.Windows.Forms.ToolStripMenuItem MenuQLLH;
        private System.Windows.Forms.ToolStripMenuItem mniGiangVien;
        private System.Windows.Forms.ToolStripMenuItem mniSinhVien;
        private System.Windows.Forms.ToolStripMenuItem sốLượngKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mniLopHoc;
    }
}