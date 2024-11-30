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
    public partial class KhoaLopHoc : Form
    {
        DBAcccess dBAcccess = new DBAcccess();
        public KhoaLopHoc()
        {
            InitializeComponent();
        }

        private void grpLopHoc_Enter(object sender, EventArgs e)
        {

        }
        private void hienThiKL()
        {
            string query = "SELECT * FROM Khoa";
            dBAcccess.loadKhoa(lstKhoa, query);
            string query2 = "SELECT * FROM Lop";
            dBAcccess.loadLop(lstLopHoc, query2);
        }
        private void KhoaLopHoc_Load(object sender, EventArgs e)
        {
            hienThiKL();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các control trên form
                string maKhoa = txtQLMaKhoa.Text.Trim();
                string tenKhoa = txtQLTenKhoa.Text.Trim();
                string diaChi = txtQLDiaChi.Text.Trim();
                if (maKhoa.Equals(""))
                    MessageBox.Show("Chưa Nhập Mã Khoa");
                else if (tenKhoa.Equals(""))
                    MessageBox.Show("Chưa Nhập Tên Khoa");
                else if (diaChi.Equals(""))
                    MessageBox.Show("Chưa Nhập Địa Chỉ");
                else
                {
                    string query1 = "SELECT * FROM Khoa WHERE MaKhoa = @maKhoa";
                    string query2 = "INSERT INTO Khoa VALUES (@maKhoa, @tenKhoa, @diaChi)";
                    dBAcccess.themKhoa(maKhoa, tenKhoa, diaChi, query1, query2);
                    hienThiKL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các control trên form
                string maLop = txtQLMaLop.Text.Trim();
                string tenLop = txtQLTenLop.Text.Trim();
                string maKhoa = txtQLMaKhoaLH.Text.Trim();
                if (maLop.Equals(""))
                    MessageBox.Show("Chưa Nhập Mã Lớp");
                else if (tenLop.Equals(""))
                    MessageBox.Show("Chưa Nhập Tên Lớp");
                else if (maKhoa.Equals(""))
                    MessageBox.Show("Chưa Nhập Mã Khoa");
                else
                {
                    string query1 = "SELECT * FROM Lop WHERE MaLop = @maLop";
                    string query2 = "INSERT INTO Lop VALUES (@maLop, @tenLop, @maKhoa)";
                    dBAcccess.themLop(maLop, tenLop, maKhoa, query1, query2);
                    hienThiKL();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            if (lstKhoa.SelectedItems.Count > 0) // Kiểm tra xem đã chọn để sửa chưa
            {
                ListViewItem item = lstKhoa.SelectedItems[0];
                // Lấy thông tin từ các textbox
                string maKhoa = txtQLMaKhoa.Text;
                string tenKhoa = txtQLTenKhoa.Text;
                string diaChi = txtQLDiaChi.Text;
                if (maKhoa.Equals(""))
                    MessageBox.Show("Chưa Nhập Mã Khoa");
                else if (tenKhoa.Equals(""))
                    MessageBox.Show("Chưa Nhập Tên Khoa");
                else if (diaChi.Equals(""))
                    MessageBox.Show("Chưa Nhập Địa Chỉ");
                else
                {
                    // Sửa thông tin trong cơ sở dữ liệu
                    // Sử dụng mã GD để tìm và sửa thông tin của môn học đó
                    string sql = "UPDATE Khoa SET MaKhoa=@maKhoa, TenKhoa=@tenKhoa, DiaChi=@diaChi";
                    dBAcccess.suaKhoa(maKhoa, tenKhoa, diaChi, sql);
                    hienThiKL();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn khoa để sửa!");
            }
        }


        private void lstKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKhoa.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstKhoa.SelectedItems[0];

                // Lấy thông tin từ các cột trong dòng được chọn
                string maKhoa = selectedItem.SubItems[0].Text;
                string tenKhoa = selectedItem.SubItems[1].Text;
                string diaChi = selectedItem.SubItems[2].Text;

                // Đặt giá trị cho các TextBox tương ứng
                txtQLMaKhoa.Text = maKhoa;
                txtQLTenKhoa.Text = tenKhoa;
                txtQLDiaChi.Text = diaChi;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            this.Hide();
            quanLy.ShowDialog();
            
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (lstLopHoc.SelectedItems.Count > 0) // Kiểm tra xem đã chọn để sửa chưa
            {
                ListViewItem item = lstLopHoc.SelectedItems[0];
                string maLop = txtQLMaLop.Text;
                string tenLop = txtQLTenLop.Text;
                string maKhoa = txtQLMaKhoa.Text;
                if (maLop.Equals(""))
                    MessageBox.Show("Chưa Nhập Mã Lớp");
                else if (tenLop.Equals(""))
                    MessageBox.Show("Chưa Nhập Tên Lớp");
                else if (maKhoa.Equals(""))
                    MessageBox.Show("Chưa Nhập Mã Khoa");
                else
                {
                    string sql = "UPDATE Lop SET MaKhoa=@maLop, TenKhoa=@tenLop, DiaChi=@maKhoa";
                    dBAcccess.suaLop(maLop, tenLop, maKhoa, sql);
                    hienThiKL();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn lớp để sửa!");
            }
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM Khoa WHERE MaKhoa = @maKhoa";
            dBAcccess.xoaKhoa(lstKhoa, deleteQuery);
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM Lop WHERE MaLop = @maLop";
            dBAcccess.xoaLop(lstLopHoc, deleteQuery);
        }

        private void btnTimKiemKhoa_Click(object sender, EventArgs e)
        {
            string searchValue = txtQLTimKiemK.Text.Trim();
            lstKhoa.Items.Clear();
            string query = "SELECT * FROM Khoa WHERE TenKhoa LIKE @searchValue";
            dBAcccess.timKiemKhoa(query, searchValue, lstKhoa);
        }

        private void btnTimKiemLop_Click(object sender, EventArgs e)
        {
            string searchValue = txtQLTimKiemL.Text.Trim();
            lstLopHoc.Items.Clear();
            string query = "SELECT * FROM Lop WHERE TenLop LIKE @searchValue";
            dBAcccess.timKiemLop(query, searchValue, lstLopHoc);
        }

        private void KhoaLopHoc_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void lstLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLopHoc.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstLopHoc.SelectedItems[0];
                // Lấy thông tin từ các cột trong dòng được chọn
                string maLop = selectedItem.SubItems[0].Text;
                string tenLop = selectedItem.SubItems[1].Text;
                string maKhoa = selectedItem.SubItems[2].Text;
                // Đặt giá trị cho các TextBox tương ứng
                txtQLMaLop.Text = maLop;
                txtQLTenLop.Text = tenLop;
                txtQLMaKhoaLH.Text = maKhoa;
            }
        }
    }
}
