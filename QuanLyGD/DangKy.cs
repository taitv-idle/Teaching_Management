using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyGD
{
    public partial class DangKy : Form
    {
        DBAcccess dBAcccess = new DBAcccess();
        public DangKy()
        {
            InitializeComponent();
        }

        private void closeDangKy()
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
        }

        private void btnGiangVienDK_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGiangVien.Text;
            string emailGV = txtEmailGV.Text;
            string matKhauGV = txtMatKhauGV.Text;
            if (maGV.Equals(""))
                MessageBox.Show("Chưa Nhập Mã GV");
            else if (emailGV.Equals(""))
                MessageBox.Show("Chưa Nhập Email");
            else if (matKhauGV.Equals(""))
                MessageBox.Show("Chưa Nhập Mật Khẩu");
            else
            {
                string query = "SELECT MatKhau FROM GiangVien WHERE MaGV = @maGV AND Email = @emailGV";
                dBAcccess.dangKyGV(query, maGV, emailGV, matKhauGV);
            }
        }

        private void btnSinhVienDK_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSinhVien.Text;
            string emailSV = txtEmailSV.Text;
            string matKhauSV = txtMatKhauSV.Text;
            if (maSV.Equals(""))
                MessageBox.Show("Chưa Nhập Mã SV");
            else if (emailSV.Equals(""))
                MessageBox.Show("Chưa Nhập Email");
            else if (matKhauSV.Equals(""))
                MessageBox.Show("Chưa Nhập Mật Khẩu");
            else
            {
                string query = "SELECT MatKhau FROM SinhVien WHERE MaSV = @masV AND Email = @emailsV";
                dBAcccess.dangKySV(query, maSV, emailSV, matKhauSV);
            }
        }

        private void btnGiangVienDNTL_Click(object sender, EventArgs e)
        {
            closeDangKy();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
