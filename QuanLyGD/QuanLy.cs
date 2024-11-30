using System;
using System.Collections;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyGD
{
    public partial class QuanLy : Form
    {
        DBAcccess dBAcccess = new DBAcccess();
        private SqlConnection connection = new SqlConnection();
        public QuanLy()
        {
            InitializeComponent();
        }
        private void hienThiGV()
        {
            string query = "SELECT * FROM GiangVien";
            dBAcccess.LoadTeachersToListView(lstGiangVien, query);
        }
        private void menuQLGV_Click(object sender, EventArgs e)
        {
            grbGiangVien.Visible = true;
            grbMonHoc.Visible = false;
            hienThiGV();
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            grbMonHoc.Visible = false;
            hienThiGV();
        }


        private void btnThemGV_Click(object sender, EventArgs e)
        {
            ChinhSuaGV themGV = new ChinhSuaGV();
            themGV.ShowDialog();
            hienThiGV();
        }
        private void lstGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            if (lstGiangVien.SelectedItems.Count > 0)
            {
                // Lấy thông tin dòng được chọn trên ListView
                ListViewItem selected = lstGiangVien.SelectedItems[0];
                string maGV = selected.SubItems[0].Text;
                string hoTen = selected.SubItems[1].Text;
                string ngaySinh = selected.SubItems[2].Text;
                string gioiTinh = selected.SubItems[3].Text;
                string diaChi = selected.SubItems[4].Text;
                string dienThoai = selected.SubItems[5].Text;
                string email = selected.SubItems[6].Text;
                string maKhoa = selected.SubItems[7].Text;
                string matKhau = selected.SubItems[8].Text;

                // truyền thông tin dòng được chọn vào
                ChinhSuaGV chinhSuaGV = new ChinhSuaGV(maGV, hoTen, ngaySinh, gioiTinh, diaChi, dienThoai, email, maKhoa, matKhau);
                chinhSuaGV.ShowDialog();
                hienThiGV();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo");
            }
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            dBAcccess.xoaGiangVien(lstGiangVien);
            hienThiGV();
        }

        private void btnLamMoiGV_Click(object sender, EventArgs e)
        {
            hienThiGV();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maGV = txtTimKiemMGV.Text.Trim();
            string query = "SELECT * FROM GiangVien WHERE MaGV = @MaGV";
            dBAcccess.timKiemGV(query, maGV, lstGiangVien);
        }

        private void hienThiMH()
        {
            lstMonHoc.Items.Clear();
            string query = "SELECT * FROM MonHoc";
            dBAcccess.LoadMonHocToListView(lstMonHoc, query);
        }

        private void MenuQLMHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbGiangVien.Visible = false;
            grbMonHoc.Visible = true;
            hienThiMH();
            cboMaKhoa.Items.Clear();
            string query = "SELECT * FROM Khoa";
            dBAcccess.LoadKhoaComboBox(cboMaKhoa, query);
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ các control trên form
                string maMH = txtMaMH.Text.Trim();
                string tenMH = txtTenMH.Text.Trim();
                int soTinChi = int.Parse(txtSoTC.Text);
                string maKhoa = cboMaKhoa.SelectedItem.ToString();
                string query1 = "SELECT * FROM MonHoc WHERE MaMH = @maMH";
                string query2 = "INSERT INTO MonHoc VALUES (@maMH, @tenMH, @soTinChi, @maKhoa)";
                dBAcccess.themMonHoc(maMH, tenMH, soTinChi, maKhoa, query1, query2);
                lstMonHoc.Items.Clear();
                hienThiMH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Khoa";
            dBAcccess.LoadKhoaComboBox(cboMaKhoa, query);
        }

        private void cboMaKhoa_Click(object sender, EventArgs e)
        {
            cboMaKhoa.Items.Clear();
            string query = "SELECT * FROM Khoa";
            dBAcccess.LoadKhoaComboBox(cboMaKhoa, query);
        }

        private void lstMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMonHoc.SelectedItems.Count > 0)
            {
                ListViewItem item = lstMonHoc.SelectedItems[0];
                txtMaMH.Text = item.SubItems[0].Text.Trim();
                txtTenMH.Text = item.SubItems[1].Text.Trim();
                txtSoTC.Text = item.SubItems[2].Text.Trim();
                cboMaKhoa.SelectedValue = item.SubItems[3].Text;
            }
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            if (lstMonHoc.SelectedItems.Count > 0) // Kiểm tra xem đã chọn môn học để sửa chưa
            {
                ListViewItem item = lstMonHoc.SelectedItems[0];

                // Lấy thông tin từ các textbox
                string maMH = txtMaMH.Text;
                string tenMH = txtTenMH.Text;
                int soTinChi = int.Parse(txtSoTC.Text);
                string maKhoa = cboMaKhoa.SelectedItem.ToString();
                // Sửa thông tin của môn học trong cơ sở dữ liệu
                // Sử dụng mã môn học để tìm và sửa thông tin của môn học đó
                string sql = "UPDATE MonHoc SET TenMH=@tenMH, SoTinChi=@soTinChi, MaKhoa=@makhoa WHERE MaMH=@maMH";
                dBAcccess.suaMonHoc(maMH, tenMH, soTinChi, maKhoa, sql);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn môn học để sửa!");
            }
        }
        private void btnLamMoiMH_Click(object sender, EventArgs e)
        {
            hienThiMH();
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM MonHoc WHERE MaMH = @maMonHoc";
            dBAcccess.xoaMonHoc(lstMonHoc, deleteQuery);
            //hienThiMH();
        }

        private void btnTimMH_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimTheoTenMH.Text.Trim();
            lstMonHoc.Items.Clear();
            string query = "SELECT * FROM MonHoc WHERE TenMH LIKE @searchValue";
            dBAcccess.timKiemMH(query, searchValue, lstMonHoc);
           
        }

        private void txtTimKiemMGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số hoặc không phải phím Backspace hoặc Delete
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                // Huỷ sự kiện KeyPress để ngăn người dùng nhập vào ký tự không hợp lệ
                e.Handled = true;
            }
        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
            txtTenMH.Text = txtTenMH.Text.Trim();
        }

        private void menuLichGDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichGiangDay lichGiangDay = new LichGiangDay();
            this.Hide();
            lichGiangDay.ShowDialog();
        }

        private void MenuQLSV_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien();
            this.Hide();
            sinhVien.ShowDialog();
        }

        private void MenuQLLH_Click(object sender, EventArgs e)
        {
            KhoaLopHoc khoaLopHoc = new KhoaLopHoc();
            this.Hide();
            khoaLopHoc.ShowDialog();
        }

        private void mniGiangVien_Click(object sender, EventArgs e)
        {
            string bang = "GiangVien";
            string ten = "Giảng Viên";
            dBAcccess.demSL(bang, ten);
        }

        private void mniSinhVien_Click(object sender, EventArgs e)
        {
            string bang = "SinhVien";
            string ten = "Sinh Viên";
            dBAcccess.demSL(bang, ten);
        }
        private void sốLượngKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string bang = "Khoa";
            string ten = "Khoa";
            dBAcccess.demSL(bang, ten);
        }

        private void mniMonHoc_Click(object sender, EventArgs e)
        {
            string bang = "MonHoc";
            string ten = "Môn Học";
            dBAcccess.demSL(bang, ten);
        }

        private void mniLopHoc_Click(object sender, EventArgs e)
        {
            string bang = "Lop";
            string ten = "Lớp Học";
            dBAcccess.demSL(bang, ten);
        }


    }
}
