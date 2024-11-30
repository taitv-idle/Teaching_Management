using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGD
{
    public partial class ChinhSuaGV : Form
    {
        public ChinhSuaGV()
        {
            InitializeComponent();
        }
        private string maGV;
        private string hoTen;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string dienThoai;
        private string email;
        private string maKhoa;
        private string matKhau;
        public ChinhSuaGV(string maGV, string hoTen, string ngaySinh, string gioiTinh, string diaChi, string dienThoai, string email, string maKhoa, string matKhau)
        {
            InitializeComponent();
            // Đưa thông tin dòng được chọn lên các textbox để sửa
            this.maGV = maGV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.email = email;
            this.maKhoa = maKhoa;
            this.matKhau = matKhau;

            txtMaGV.Text = maGV;
            txtHoTenGV.Text = hoTen;
            dtpNgaySinh.Value = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (gioiTinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else if (gioiTinh == "Nữ")
            {
                rdbNu.Checked = true;
            }
            else if (gioiTinh == "Khác")
            {
                rdbKhac.Checked = true;
            }
            txtDiaChiGV.Text = diaChi;
            txtDienThoaiGV.Text = dienThoai;
            txtEmailGV.Text = email;
            txtMaKhoaGV.Text = maKhoa;
            txtMatKhauGV.Text = matKhau;
        }
        private void ChinhSuaGV_Load(object sender, EventArgs e)
        {

        }

        DBAcccess dBAcccess = new DBAcccess();
        private void btnThemGVDB_Click(object sender, EventArgs e)
        {
            try
            {
                string maGV = txtMaGV.Text;
                string hoTen = txtHoTenGV.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                string gioiTinh = "";
                if (rdbNam.Checked)
                    gioiTinh = "Nam";
                else if (rdbNu.Checked)
                    gioiTinh = "Nữ";
                else if (rdbKhac.Checked)
                    gioiTinh = "Khác";
                string diaChi = txtDiaChiGV.Text;
                string dienThoai = txtDienThoaiGV.Text;
                string email = txtEmailGV.Text;
                string maKhoa = txtMaKhoaGV.Text;
                string matKhau = txtMatKhauGV.Text;
                string query1 = "SELECT * FROM GiangVien WHERE MaGV = @maGV";
                string query2 = "INSERT INTO GiangVien (MaGV, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, Email, MaKhoa, MatKhau) " +
                "VALUES (@maGV, @hoTen, @ngaySinh, @gioiTinh, @diaChi, @dienThoai, @email, @maKhoa, @matKhau)";
                dBAcccess.themGiangVien(maGV, hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, email, maKhoa, matKhau, query1, query2);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control
            string maGV = txtMaGV.Text;
            string hoTen = txtHoTenGV.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = rdbNam.Checked ? "Nam" : rdbNu.Checked ? "Nữ" : "Khác";
            string diaChi = txtDiaChiGV.Text;
            string dienThoai = txtDienThoaiGV.Text;
            string email = txtEmailGV.Text;
            string maKhoa = txtMaKhoaGV.Text;
            string matKhau = txtMatKhauGV.Text;

            // Cập nhật dữ liệu vào CSDL
            string updateQuery = "UPDATE GiangVien SET HoTen = @hoten, NgaySinh = @ngaysinh, GioiTinh = @gioitinh, " +
                                 "DiaChi = @diachi, DienThoai = @dienthoai, Email = @email, " +
                                 "MaKhoa = @makhoa, MatKhau = @matkhau " +
                                 "WHERE MaGV = @magv";
            dBAcccess.suaGiangVien(maGV, hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, email, maKhoa, matKhau, updateQuery);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ChinhSuaGV_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
