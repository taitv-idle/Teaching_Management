using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace QuanLyGD
{
    public partial class LichGiangDay : Form
    {
        DBAcccess dBAcccess = new DBAcccess();
        public LichGiangDay()
        {
            InitializeComponent();
        }
        private void hienThiGD()
        {
            string query = "SELECT * FROM LichGiangDay";
            dBAcccess.lichGiangDay(lstGiangDay, query);
        }
        private void LichGiangDay_Load(object sender, EventArgs e)
        {
            hienThiGD();
        }

        private void lstGiangDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGiangDay.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstGiangDay.SelectedItems[0];

                // Lấy thông tin từ các cột trong dòng được chọn
                string maLGD = selectedItem.SubItems[0].Text;
                string thoiGian = selectedItem.SubItems[1].Text;
                string phongHoc = selectedItem.SubItems[2].Text;
                string maLop = selectedItem.SubItems[3].Text;
                string maGV = selectedItem.SubItems[4].Text;
                string maMH = selectedItem.SubItems[5].Text;

                // Đặt giá trị cho các TextBox tương ứng
                txtMaGD.Text = maLGD;
                txtThoiGianGD.Text = thoiGian;
                txtPhongHocGD.Text = phongHoc;
                txtMaLopGD.Text = maLop;
                txtMaGiangVienGD.Text = maGV;
                txtMonHocGD.Text = maMH;
            }
        }

        private void btnThemLGD_Click(object sender, EventArgs e)
        {
            try
            {
                string maLGD = txtMaGD.Text.Trim();
                string thoiGian = txtThoiGianGD.Text.Trim();
                string phongHoc = txtPhongHocGD.Text.Trim();
                string maLop = txtMaLopGD.Text.Trim();
                string maGV = txtMaGiangVienGD.Text.Trim();
                string maMH = txtMonHocGD.Text.Trim();
                if (maLGD.Equals(""))
                    MessageBox.Show("Chưa Nhập Mã LGD");
                else if (thoiGian.Equals(""))
                    MessageBox.Show("Chưa Nhập Thời Gian");
                else if (phongHoc.Equals(""))
                    MessageBox.Show("Chưa Nhập Phòng Học");
                else if (maLop.Equals(""))
                    MessageBox.Show("Chưa Nhập Mã Lớp");
                else if (maGV.Equals(""))
                    MessageBox.Show("Chưa Nhập Mã Giảng Viên");
                else if (maMH.Equals(""))
                    MessageBox.Show("Chưa Nhập Môn Học");
                string query1 = "SELECT * FROM LichGiangDay WHERE MaLGD = @maLGD";
                string query2 = "INSERT INTO LichGiangDay VALUES (@maLGD, @thoiGian, @phongHoc, @maLop, @maGV, @maMH)";
                dBAcccess.themLGD(maLGD, thoiGian, phongHoc, maLop, maGV, maMH, query1, query2);
                hienThiGD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnSuaLGD_Click(object sender, EventArgs e)
        {
            if (lstGiangDay.SelectedItems.Count > 0) // Kiểm tra xem đã chọn để sửa chưa
            {
                ListViewItem item = lstGiangDay.SelectedItems[0];

                // Lấy thông tin từ các textbox
                string maLGD = txtMaGD.Text;
                string thoiGian = txtThoiGianGD.Text;
                string phongHoc = txtPhongHocGD.Text;
                string maLop = txtMaLopGD.Text;
                string maGV = txtMaGiangVienGD.Text;
                string maMH = txtMonHocGD.Text;
                // Sửa thông tin trong cơ sở dữ liệu
                // Sử dụng mã GD để tìm và sửa thông tin của môn học đó
                string sql = "UPDATE LichGiangDay SET MaLGD=@maLGD, ThoiGian=@thoiGian, PhongHoc=@phongHoc, MaLop=@maLop, MaGV=@maGV, MaMH=@maMH WHERE MaLGD=@maLGD";
                dBAcccess.suaLGD(maLGD, thoiGian, phongHoc, maLop, maGV, maMH, sql);
                hienThiGD();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn môn học để sửa!");
            }
        }

        private void btnXoaLGD_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM LichGiangDay WHERE MaLGD = @maLGD";
            dBAcccess.xoaLGD(lstGiangDay, deleteQuery);
        }

        private void btnLamMoiLGD_Click(object sender, EventArgs e)
        {
            hienThiGD();
        }

        private void btnTimKiemLGD_Click(object sender, EventArgs e)
        {
            string searchValue = txtTimKiemGD.Text.Trim();
            lstGiangDay.Items.Clear();
            string query = "SELECT * FROM LichGiangDay WHERE MaLGD LIKE @searchValue";
            dBAcccess.timKiemGD(query, searchValue, lstGiangDay);
        }

        public void anGrb()
        {
            grbChucNangGD.Visible = false;
            btnQuayLaiQL.Visible = false;

        }

        private void btnQuayLaiQL_Click(object sender, EventArgs e)
        {
            QuanLy quanLy = new QuanLy();
            this.Hide();
            quanLy.ShowDialog();
        }

        private void LichGiangDay_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
