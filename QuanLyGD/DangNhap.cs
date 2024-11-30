using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGD
{
    public partial class DangNhap : Form
    {
        DBAcccess dBAcccess = new DBAcccess();
        DataTable table = new DataTable();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void openDangKy()
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dBAcccess.creatConnection();
        }


        private void lblAdminDN_Click(object sender, EventArgs e)
        {
            DangNhapAdmin dangNhapAdmin = new DangNhapAdmin();
            this.Hide();
            dangNhapAdmin.ShowDialog();
        }

        private void btnOpenGVDK_Click(object sender, EventArgs e)
        {
            openDangKy();
        }

        private void btnOpenDKSV_Click(object sender, EventArgs e)
        {
            openDangKy();
        }

        private void btnSinhVienDN_Click(object sender, EventArgs e)
        {
            string maSVDN = txtMaSinhVienDN.Text;
            string matKhauDN = txtMatKhauSVDN.Text;

            if (maSVDN.Equals(""))
            {
                MessageBox.Show("Chưa nhập mã Sinh Viên");
            }
            else if (matKhauDN.Equals(""))
            {
                MessageBox.Show("Chưa nhập mật khẩu");
            }
            else
            {
                string query = "SELECT * FROM SinhVien WHERE MaSV = '" + maSVDN + "'AND MatKhau = '" + matKhauDN + "'";
                dBAcccess.dangNhapSV(query, table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Login Success");
                    dBAcccess.closeConn();
                    LichHoc lichhoc = new LichHoc();
                    lichhoc.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại thông tin");
                }
            }
        }

        private void btnGiangVienDN_Click(object sender, EventArgs e)
        {
            string maGVDN = txtMaGVDN.Text;
            string matKhauDN = txtMatKhauGVDN.Text;

            if (maGVDN.Equals(""))
            {
                MessageBox.Show("Chưa nhập mã Giảng Viên");
            }
            else if (matKhauDN.Equals(""))
            {
                MessageBox.Show("Chưa nhập mật khẩu");
            }
            else
            {
                string query = "SELECT * FROM GiangVien WHERE MaGV = '" + maGVDN + "'AND MatKhau = '" + matKhauDN + "'";
                dBAcccess.dangNhapGV(query, table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Login Success");
                    dBAcccess.closeConn();
                    LichGiangDay lichGiangDay = new LichGiangDay();
                    lichGiangDay.anGrb();
                    lichGiangDay.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại thông tin");
                }
            }
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
