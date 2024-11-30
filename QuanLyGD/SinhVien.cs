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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyGD
{
    public partial class SinhVien : Form
    {
        DBAcccess dBAcccess = new DBAcccess();
        public SinhVien()
        {
            InitializeComponent();
        }

        private void menuQLSV_Click(object sender, EventArgs e)
        {

        }
        private void hienThiSV()
        {
            string query = "SELECT * FROM SinhVien";
            dBAcccess.LoadSVToListView(lstSinhVien, query);
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            // Truy vấn cơ sở dữ liệu để lấy danh sách các lớp
            string query = "SELECT MaLop, TenLop FROM Lop";
            dBAcccess.loadComBoBoxLop(query, cboLop);
            hienThiSV();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ trong ListView
            lstSinhVien.Items.Clear();

            // Lấy mã lớp được chọn từ ComboBox
            int maLop = ((KeyValuePair<int, string>)cboLop.SelectedItem).Key;
            // Truy vấn cơ sở dữ liệu để lấy danh sách sinh viên của lớp được chọn
            string query = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaLop, Email, MatKhau FROM SinhVien WHERE MaLop = @maLop";
            dBAcccess.loadListViewSV(query, lstSinhVien, maLop);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            this.Hide();
            quanLy.ShowDialog();

        }


        private void btnThemSV_Click(object sender, EventArgs e)
        {
            try
            {

                string maSV = txtMaSV.Text;
                string hoTen = txtHoTenSV.Text;
                DateTime ngaySinh = dtpNgaySinhSV.Value;
                string gioiTinh = "";
                if (rdbNamSV.Checked)
                    gioiTinh = "Nam";
                else if (rdbNuSV.Checked)
                    gioiTinh = "Nữ";
                else if (rdbKhacSV.Checked)
                    gioiTinh = "Khác";
                string diaChi = txtDiaChiSV.Text;
                string maLop = txtMaLopSV.Text;
                string dienThoai = txtDienThoaiSV.Text;
                string email = txtEmailSV.Text;
                string matKhau = txtMatKhauSV.Text;
                string query1 = "SELECT * FROM SinhVien WHERE MaSV = @maSV";
                string query2 = "INSERT INTO SinhVien (MasV, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, DienThoai, Email, MatKhau) " +
                "VALUES (@maSV, @hoTen, @ngaySinh, @gioiTinh, @diaChi, @maLop, @dienThoai, @email, @matKhau)";
                dBAcccess.themSinhVien(maSV, hoTen, ngaySinh, gioiTinh, diaChi, maLop, dienThoai, email, matKhau, query1, query2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM SinhVien WHERE MaSV = @maSV";
            dBAcccess.xoaSV(lstSinhVien, deleteQuery);
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedItems.Count > 0)
            {
                // Lấy dòng được chọn từ ListView
                ListViewItem selectedRow = lstSinhVien.SelectedItems[0];

                // Đẩy thông tin từ dòng được chọn vào các TextBox
                txtMaSV.Text = selectedRow.SubItems[0].Text;
                txtHoTenSV.Text = selectedRow.SubItems[1].Text;
                DateTime ngaySinh;
                if (DateTime.TryParse(selectedRow.SubItems[2].Text, out ngaySinh))
                {
                    dtpNgaySinhSV.Value = ngaySinh;
                }
                else
                {
                    // Xử lý khi chuỗi không đúng định dạng
                }

                // Kiểm tra giới tính và đặt RadioButton tương ứng
                string gioiTinh = selectedRow.SubItems[3].Text;
                if (gioiTinh == "Nam")
                {
                    rdbNamSV.Checked = true;
                    rdbNuSV.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdbNamSV.Checked = false;
                    rdbNuSV.Checked = true;
                }
                else
                {
                    rdbNamSV.Checked = false;
                    rdbNuSV.Checked = false;
                }
                txtDiaChiSV.Text = selectedRow.SubItems[4].Text;
                txtMaLopSV.Text = selectedRow.SubItems[5].Text;
                txtDienThoaiSV.Text = selectedRow.SubItems[6].Text;
                txtEmailSV.Text = selectedRow.SubItems[7].Text;
                txtMatKhauSV.Text = selectedRow.SubItems[8].Text;
            }
            else
            {
                // Nếu không có dòng nào được chọn, xóa nội dung các TextBox
                txtMaSV.Clear();
                txtHoTenSV.Clear();
                rdbNamSV.Checked = false;
                rdbNuSV.Checked = false;
                txtDiaChiSV.Clear();
                txtMaLopSV.Clear();
                txtDienThoaiSV.Clear();
                txtEmailSV.Clear();
                txtMatKhauSV.Clear();
            }
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            // Kiểm tra tính hợp lệ của dữ liệu đầu vào
            if (lstSinhVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin sinh viên từ các TextBox
            string maSV = txtMaSV.Text;
            string hoTen = txtHoTenSV.Text;
            DateTime ngaySinh = dtpNgaySinhSV.Value;
            string gioiTinh = rdbNamSV.Checked ? "Nam" : "Nữ";
            string diaChi = txtDiaChiSV.Text;
            string maLop = txtMaLopSV.Text;
            string dienThoai = txtDienThoaiSV.Text;
            string email = txtEmailSV.Text;
            string matKhau = txtMatKhauSV.Text;

            // Lấy ListViewItem đang được chọn trong ListView
            ListViewItem selectedItem = lstSinhVien.SelectedItems[0];

            // Cập nhật thông tin sinh viên trên ListViewItem
            selectedItem.SubItems[1].Text = hoTen;
            selectedItem.SubItems[2].Text = ngaySinh.ToString("dd/MM/yyyy");
            selectedItem.SubItems[3].Text = gioiTinh;
            selectedItem.SubItems[4].Text = diaChi;
            selectedItem.SubItems[5].Text = maLop;
            selectedItem.SubItems[6].Text = dienThoai;
            selectedItem.SubItems[7].Text = email;
            selectedItem.SubItems[8].Text = matKhau;

            // Chuẩn bị câu truy vấn UPDATE
            string query = "UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, MaLop = @MaLop, DienThoai = @DienThoai, Email = @Email, MatKhau = @MatKhau " +
                           "WHERE MaSV = @MaSV";
            dBAcccess.suaSinhVien(query, maSV, hoTen, ngaySinh, gioiTinh, diaChi, maLop, dienThoai, email, matKhau);
            // Xóa nội dung trong các TextBox sau khi sửa thành công
            txtMaSV.Clear();
            txtHoTenSV.Clear();
            dtpNgaySinhSV.Value = DateTime.Now;
            rdbNamSV.Checked = true;
            txtDiaChiSV.Clear();
            txtMaLopSV.Clear();
            txtDienThoaiSV.Clear();
            txtEmailSV.Clear();
            txtMatKhauSV.Clear();
        }

        private void btnLamMoiSV_Click(object sender, EventArgs e)
        {
            hienThiSV();
        }

        private void btnTimKiemSV_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiemMSV.Text.Trim();
            lstSinhVien.Items.Clear();
            string query = "SELECT * FROM SinhVien WHERE MaSV LIKE @searchValue";
            dBAcccess.timKiemSV(query, searchValue, lstSinhVien);
        }

        private void SinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
