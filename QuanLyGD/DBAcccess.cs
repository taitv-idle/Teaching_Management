using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyGD
{
    public class DBAcccess
    {
        private string strconnectDB = "Data Source=TVT;Initial Catalog=QLGiangDay;Integrated Security=True";
        private SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void LoadTeachersToListView(ListView lstGiangVien, string query)//Hiển thị thông tin GiangVien
        {
            // Xóa tất cả các item trong ListView trước khi thêm mới
            lstGiangVien.Items.Clear();
            // Kết nối đến cơ sở dữ liệu và truy vấn dữ liệu cần hiển thị lên ListView
            adapter = new SqlDataAdapter(query, strconnectDB);
            DataTable dataTable = new DataTable();
            try
            {
                // Lấy dữ liệu từ kết quả truy vấn và đưa vào một DataTable
                adapter.Fill(dataTable);
                // Duyệt các dòng trong DataTable và thêm dữ liệu vào ListView
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MaGV"].ToString());
                    item.SubItems.Add(row["HoTen"].ToString());
                    item.SubItems.Add(((DateTime)row["NgaySinh"]).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(row["GioiTinh"].ToString());
                    item.SubItems.Add(row["DiaChi"].ToString());
                    item.SubItems.Add(row["DienThoai"].ToString());
                    item.SubItems.Add(row["Email"].ToString());
                    item.SubItems.Add(row["MaKhoa"].ToString());
                    item.SubItems.Add(row["MatKhau"].ToString());
                    lstGiangVien.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void creatConnection()//Tạo kết nói đến DB
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strconnectDB;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void closeConn()//Dóng DB
        {
            connection.Close();
        }
        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void themGiangVien(string maGV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai, string email, string maKhoa, string matKhau, string query1, string query2)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            // Kiểm tra tính hợp lệ của mã giảng viên (không được trùng lặp với mã giảng viên đã có)
            command = new SqlCommand(query1, connection);
            command.Parameters.AddWithValue("@MaGV", maGV);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // Mã giảng viên đã tồn tại trong cơ sở dữ liệu, không thể thêm mới
                reader.Close();
                throw new Exception("Mã giảng viên đã tồn tại");
            }
            reader.Close();
            // Tạo câu truy vấn SQL để thêm giảng viên mới vào bảng GiangVien
            command = new SqlCommand(query2, connection);
            command.Parameters.AddWithValue("@MaGV", maGV);
            command.Parameters.AddWithValue("@HoTen", hoTen);
            command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            command.Parameters.AddWithValue("@DiaChi", diaChi);
            command.Parameters.AddWithValue("@DienThoai", dienThoai);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@MaKhoa", maKhoa);
            command.Parameters.AddWithValue("@MatKhau", matKhau);
            // Thực hiện câu truy vấn trên cơ sở dữ liệu
            int row = command.ExecuteNonQuery();
            if (row > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Thêm thành công", "Thành Công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, thêm không thành công");
            }
        }
        public void suaGiangVien(string maGV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string dienThoai, string email, string maKhoa, string matKhau, string updateQuery)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@magv", maGV);
            command.Parameters.AddWithValue("@hoten", hoTen);
            command.Parameters.AddWithValue("@ngaysinh", ngaySinh);
            command.Parameters.AddWithValue("@gioitinh", gioiTinh);
            command.Parameters.AddWithValue("@diachi", diaChi);
            command.Parameters.AddWithValue("@dienthoai", dienThoai);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@makhoa", maKhoa);
            command.Parameters.AddWithValue("@matkhau", matKhau);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật thông tin giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin giảng viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaGiangVien(ListView lstGiangVien)
        {
            if (lstGiangVien.SelectedItems.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                    if (lstGiangVien.SelectedItems.Count > 0)
                    {
                        ListViewItem selectedRow = lstGiangVien.SelectedItems[0];
                        // Lấy giá trị của cột MaGV từ dòng được chọn
                        int maGV = Convert.ToInt32(selectedRow.SubItems[0].Text);
                        // Kết nối đến cơ sở dữ liệu
                        using (connection = new SqlConnection(strconnectDB))
                        {
                            connection.Open();
                            // Câu lệnh DELETE để xóa dòng có MaGV tương ứng
                            string query = "DELETE FROM GiangVien WHERE MaGV = @maGV";
                            // Tạo đối tượng SqlCommand
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Thêm tham số @maGV vào câu lệnh DELETE
                                command.Parameters.AddWithValue("@maGV", maGV);
                                // Thực thi câu lệnh DELETE
                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    // Xóa dòng được chọn trên ListView
                                    lstGiangVien.Items.Remove(selectedRow);
                                    MessageBox.Show("Xóa thành công!");
                                }
                                else
                                {
                                    MessageBox.Show("Xóa không thành công!");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                    }
                }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
            }
        }
        public void xoaMonHoc(ListView lstMonHoc, string deleteQuery)
        {
            if (lstMonHoc.SelectedItems.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                ListViewItem selectedRow = lstMonHoc.SelectedItems[0];
                string maMonHoc = selectedRow.SubItems[0].Text; // Lấy giá trị của cột MaMH
                // Thực hiện câu lệnh DELETE trong cơ sở dữ liệu
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@maMonHoc", maMonHoc);
                command.ExecuteNonQuery(); ;
                // Xóa dòng khỏi ListView
                lstMonHoc.Items.Remove(selectedRow);
                // Hiển thị thông báo xóa thành công
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
            }
        }
        public void timKiemGV(string query, string maGV, ListView lstGiangVien)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaGV", maGV);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                ListViewItem item = new ListViewItem(table.Rows[0]["MaGV"].ToString());
                item.SubItems.Add(table.Rows[0]["HoTen"].ToString());
                item.SubItems.Add(((DateTime)table.Rows[0]["NgaySinh"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(table.Rows[0]["GioiTinh"].ToString());
                item.SubItems.Add(table.Rows[0]["DiaChi"].ToString());
                item.SubItems.Add(table.Rows[0]["DienThoai"].ToString());
                item.SubItems.Add(table.Rows[0]["Email"].ToString());
                item.SubItems.Add(table.Rows[0]["MaKhoa"].ToString());
                item.SubItems.Add(table.Rows[0]["MatKhau"].ToString());
                lstGiangVien.Items.Clear();
                lstGiangVien.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Không tìm thấy giảng viên nào có mã " + maGV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Quản Lý Môn Học
        public void LoadMonHocToListView(ListView lstMonHoc, string query)//Hiển thị thông tin GiangVien
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            // Xóa tất cả các item trong ListView trước khi thêm mới
            lstMonHoc.Items.Clear();
            // Kết nối đến cơ sở dữ liệu và truy vấn dữ liệu cần hiển thị lên ListView
            adapter = new SqlDataAdapter(query, strconnectDB);
            DataTable dataTable = new DataTable();
            try
            {
                // Lấy dữ liệu từ kết quả truy vấn và đưa vào một DataTable
                adapter.Fill(dataTable);

                // Duyệt các dòng trong DataTable và thêm dữ liệu vào ListView
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MaMH"].ToString());
                    item.SubItems.Add(row["TenMH"].ToString());
                    item.SubItems.Add(row["SoTinChi"].ToString());
                    item.SubItems.Add(row["MaKhoa"].ToString());
                    lstMonHoc.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void LoadKhoaComboBox(ComboBox cboMaKhoa, string query)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            using (connection = new SqlConnection(strconnectDB))
            {
                adapter = new SqlDataAdapter(query, connection);
                table = new DataTable();
                adapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    string maKhoa = row["MaKhoa"].ToString();
                    cboMaKhoa.Items.Add(maKhoa);
                }
            }
        }

        public void themMonHoc(string maMH, string tenMH, int soTinChi, string maKhoa, string query1, string query2)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                command = new SqlCommand(query1, connection);
                command.Parameters.AddWithValue("@MaMH", maMH);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    throw new Exception("Mã môn học đã tồn tại trong cơ sở dữ liệu");
                }
                reader.Close();
                command = new SqlCommand(query2, connection);
                command.Parameters.AddWithValue("@MaMH", maMH);
                command.Parameters.AddWithValue("@TenMH", tenMH);
                command.Parameters.AddWithValue("@SoTinChi", soTinChi);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Thêm thành công", "Thành Công", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void suaMonHoc(string maMH, string tenMH, int soTinChi, string maKhoa, string updateQuery)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@maMH", maMH);
            command.Parameters.AddWithValue("@tenMH", tenMH);
            command.Parameters.AddWithValue("@soTinChi", soTinChi);
            command.Parameters.AddWithValue("@maKhoa", maKhoa);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Sửa thông tin Môn Học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thông tin Môn Học thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaMonHoc(string tenMonHoc)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            command = new SqlCommand("DELETE FROM MonHoc WHERE MaMH = @maMonHoc", connection);
            command.Parameters.AddWithValue("@maMonHoc", tenMonHoc);
            command.ExecuteNonQuery();
        }
        public void timKiemMH(string query, string searchValue, ListView lstMonHoc)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            using (connection = new SqlConnection(strconnectDB))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MaMH"].ToString());
                    item.SubItems.Add(reader["TenMH"].ToString());
                    item.SubItems.Add(reader["SoTinChi"].ToString());
                    item.SubItems.Add(reader["MaKhoa"].ToString());
                    lstMonHoc.Items.Add(item);
                }
                reader.Close();
            }
        }

        public void lichHoc(string query, ListView lstGiangDay)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["MaLGD"].ToString());
                item.SubItems.Add(reader["ThoiGian"].ToString());
                item.SubItems.Add(reader["PhongHoc"].ToString());
                item.SubItems.Add(reader["TenLop"].ToString());
                item.SubItems.Add(reader["Hoten"].ToString());
                lstGiangDay.Items.Add(item);
            }
            reader.Close();
        }

        public void lichGiangDay(ListView lstGiangVien, string query)//Hiển thị thông tin GiangVien
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            // Xóa tất cả các item trong ListView trước khi thêm mới
            lstGiangVien.Items.Clear();
            // Kết nối đến cơ sở dữ liệu và truy vấn dữ liệu cần hiển thị lên ListView
            adapter = new SqlDataAdapter(query, strconnectDB);
            table = new DataTable();
            try
            {
                // Lấy dữ liệu từ kết quả truy vấn và đưa vào một DataTable
                adapter.Fill(table);

                // Duyệt các dòng trong DataTable và thêm dữ liệu vào ListView
                foreach (DataRow row in table.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MaLGD"].ToString());
                    item.SubItems.Add(row["ThoiGian"].ToString());
                    item.SubItems.Add(row["PhongHoc"].ToString());
                    item.SubItems.Add(row["MaLop"].ToString());
                    item.SubItems.Add(row["MaGV"].ToString());
                    item.SubItems.Add(row["MaMH"].ToString());
                    lstGiangVien.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void themLGD(string maLGD, string thoiGian, string phongHoc, string maLop, string maGV, string maMH, string query1, string query2)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                command = new SqlCommand(query1, connection);
                command.Parameters.AddWithValue("@MaLGD", maLGD);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    throw new Exception("Mã giảng dạy đã tồn tại!");
                }
                reader.Close();
                command = new SqlCommand(query2, connection);
                command.Parameters.AddWithValue("@MaLGD", maLGD);
                command.Parameters.AddWithValue("@ThoiGian", thoiGian);
                command.Parameters.AddWithValue("@PhongHoc", phongHoc);
                command.Parameters.AddWithValue("@MaLop", maLop);
                command.Parameters.AddWithValue("@MaGV", maGV);
                command.Parameters.AddWithValue("@MaMH", maMH);
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Thêm thành công", "Thành Công", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void suaLGD(string maLGD, string thoiGian, string phongHoc, string maLop,string maGV, string maMH, string updateQuery)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@MaLGD", maLGD);
            command.Parameters.AddWithValue("@ThoiGian", thoiGian);
            command.Parameters.AddWithValue("@PhongHoc", phongHoc);
            command.Parameters.AddWithValue("@MaLop", maLop);
            command.Parameters.AddWithValue("@MaGV", maGV);
            command.Parameters.AddWithValue("@MaMH", maMH);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void xoaLGD(ListView lstGiangDay, string deleteQuery)
        {
            if (lstGiangDay.SelectedItems.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                ListViewItem selectedRow = lstGiangDay.SelectedItems[0];
                string maLGD = selectedRow.SubItems[0].Text; // Lấy giá trị của cột MaMH
                // Thực hiện câu lệnh DELETE trong cơ sở dữ liệu
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@maLGD", maLGD);
                command.ExecuteNonQuery(); ;
                // Xóa dòng khỏi ListView
                lstGiangDay.Items.Remove(selectedRow);
                // Hiển thị thông báo xóa thành công
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
            }
        }
        public void timKiemGD(string query, string searchValue, ListView lstGiangDay)
        {

            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            using (connection = new SqlConnection(strconnectDB))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MaLGD"].ToString());
                    item.SubItems.Add(reader["ThoiGian"].ToString());
                    item.SubItems.Add(reader["PhongHoc"].ToString());
                    item.SubItems.Add(reader["MaLop"].ToString());
                    item.SubItems.Add(reader["MaGV"].ToString());
                    item.SubItems.Add(reader["MaMH"].ToString());
                    lstGiangDay.Items.Add(item);
                }

                reader.Close();
            }
        }
        public void LoadSVToListView(ListView lstSinhVien, string query)
        {
            // Xóa tất cả các item trong ListView trước khi thêm mới
            lstSinhVien.Items.Clear();
            // Kết nối đến cơ sở dữ liệu và truy vấn dữ liệu cần hiển thị lên ListView
            adapter = new SqlDataAdapter(query, strconnectDB);
            DataTable dataTable = new DataTable();
            try
            {
                // Lấy dữ liệu từ kết quả truy vấn và đưa vào một DataTable
                adapter.Fill(dataTable);

                // Duyệt các dòng trong DataTable và thêm dữ liệu vào ListView
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MaSV"].ToString());
                    item.SubItems.Add(row["HoTen"].ToString());
                    item.SubItems.Add(((DateTime)row["NgaySinh"]).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(row["GioiTinh"].ToString());
                    item.SubItems.Add(row["DiaChi"].ToString());
                    item.SubItems.Add(row["MaLop"].ToString());
                    item.SubItems.Add(row["DienThoai"].ToString());
                    item.SubItems.Add(row["Email"].ToString());
                    item.SubItems.Add(row["MatKhau"].ToString());
                    lstSinhVien.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void loadComBoBoxLop(string query, ComboBox cboLop)
        {
            using (connection = new SqlConnection(strconnectDB))
            {
                connection.Open();
                using (command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Duyệt qua các bản ghi lớp và thêm tên lớp vào ComboBox
                        while (reader.Read())
                        {
                            int maLop = Convert.ToInt32(reader["MaLop"]);
                            string tenLop = reader["TenLop"].ToString();

                            cboLop.Items.Add(new KeyValuePair<int, string>(maLop, tenLop));
                        }
                    }
                }
            }
        }

        public void loadListViewSV(string query, ListView lstSinhVien, int maLop)
        {
            using (connection = new SqlConnection(strconnectDB))
            {
                connection.Open();
                using (command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@maLop", maLop);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Duyệt qua các bản ghi sinh viên và thêm vào ListView
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["MaSV"].ToString());
                            item.SubItems.Add(reader["HoTen"].ToString());
                            DateTime ngaySinh = (DateTime)reader["NgaySinh"];
                            string ngaySinhFormatted = ngaySinh.ToString("dd/MM/yyyy");
                            item.SubItems.Add(ngaySinhFormatted);
                            item.SubItems.Add(reader["GioiTinh"].ToString());
                            item.SubItems.Add(reader["DiaChi"].ToString());
                            item.SubItems.Add(reader["MaLop"].ToString());
                            item.SubItems.Add(reader["DienThoai"].ToString());
                            item.SubItems.Add(reader["Email"].ToString());
                            item.SubItems.Add(reader["MatKhau"].ToString());
                            lstSinhVien.Items.Add(item);
                        }
                    }
                }
            }
        }

        public void themSinhVien(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string maLop, string dienThoai, string email, string matKhau, string query1, string query2)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            // Kiểm tra tính hợp lệ của mã SV (không được trùng lặp với mã SV đã có)
            command = new SqlCommand(query1, connection);
            command.Parameters.AddWithValue("@MaSV", maSV);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // Mã SV đã tồn tại trong cơ sở dữ liệu, không thể thêm mới
                reader.Close();
                throw new Exception("Mã SV viên đã tồn tại trong cơ sở dữ liệu");
            }
            reader.Close();

            // Tạo câu truy vấn SQL để thêm SV mới vào bảng GiangVien
            command = new SqlCommand(query2, connection);
            command.Parameters.AddWithValue("@MaSV", maSV);
            command.Parameters.AddWithValue("@HoTen", hoTen);
            command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            command.Parameters.AddWithValue("@DiaChi", diaChi);
            command.Parameters.AddWithValue("@MaLop", maLop);
            command.Parameters.AddWithValue("@DienThoai", dienThoai);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@MatKhau", matKhau);
            // Thực hiện câu truy vấn trên cơ sở dữ liệu
            int row = command.ExecuteNonQuery();
            if (row > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Thêm thành công", "Thành Công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, thêm không thành công");
            }
        }

        public void suaSinhVien(string query, string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, string maLop, string dienThoai, string email, string matKhau)
        {
            using (connection = new SqlConnection(strconnectDB))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Gán giá trị tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@MaSV", maSV);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@MaLop", maLop);
                    command.Parameters.AddWithValue("@DienThoai", dienThoai);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);
                    // Thực thi câu truy vấn UPDATE
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

            MessageBox.Show("Sửa thông tin sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void xoaSV(ListView lstSinhVien, string deleteQuery)
        {
            if (lstSinhVien.SelectedItems.Count > 0)
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                ListViewItem selectedRow = lstSinhVien.SelectedItems[0];
                string maSV = selectedRow.SubItems[0].Text; // Lấy giá trị của cột MaSV
                // Thực hiện câu lệnh DELETE trong cơ sở dữ liệu
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@maSV", maSV);
                command.ExecuteNonQuery(); ;
                // Xóa dòng khỏi ListView
                lstSinhVien.Items.Remove(selectedRow);
                // Hiển thị thông báo xóa thành công
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
            }
        }

        public void timKiemSV(string query, string searchValue, ListView lstSinhVien)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            using (connection = new SqlConnection(strconnectDB))
            {
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MaSV"].ToString());
                    item.SubItems.Add(reader["HoTen"].ToString());
                    item.SubItems.Add(((DateTime)reader["NgaySinh"]).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(reader["GioiTinh"].ToString());
                    item.SubItems.Add(reader["DiaChi"].ToString());
                    item.SubItems.Add(reader["MaLop"].ToString());
                    item.SubItems.Add(reader["DienThoai"].ToString());
                    item.SubItems.Add(reader["Email"].ToString());
                    item.SubItems.Add(reader["MatKhau"].ToString());
                    lstSinhVien.Items.Clear();
                    lstSinhVien.Items.Add(item);
                }
                reader.Close();
            }
        }

        public void loadKhoa(ListView lstKhoa, string query)
        {
            lstKhoa.Items.Clear();
            adapter = new SqlDataAdapter(query, strconnectDB);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                // Duyệt các dòng trong DataTable và thêm dữ liệu vào ListView
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MaKhoa"].ToString());
                    item.SubItems.Add(row["TenKhoa"].ToString());
                    item.SubItems.Add(row["DiaChi"].ToString());
                    lstKhoa.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void loadLop(ListView lstLopHoc, string query2)
        {
            lstLopHoc.Items.Clear();
            adapter = new SqlDataAdapter(query2, strconnectDB);
            DataTable dataTable = new DataTable();
            try
            {
                // Lấy dữ liệu từ kết quả truy vấn và đưa vào một DataTable
                adapter.Fill(dataTable);
                // Duyệt các dòng trong DataTable và thêm dữ liệu vào ListView
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MaLop"].ToString());
                    item.SubItems.Add(row["TenLop"].ToString());
                    item.SubItems.Add(row["MaKhoa"].ToString());

                    lstLopHoc.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void demSL(string bang, string ten)
        {
            using (connection = new SqlConnection(strconnectDB))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM "+ bang +"";
                command = new SqlCommand(query, connection);
                int totalStudents = (int)command.ExecuteScalar();
                MessageBox.Show("Tổng số "+ten+": " + totalStudents.ToString());
            }
        }

        public void dangKyGV(string query, string maGV, string emailGV, string matKhauGV)
        {
            using (connection = new SqlConnection(strconnectDB))
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maGV", maGV);
                command.Parameters.AddWithValue("@emailGV", emailGV);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string matKhau = reader["MatKhau"].ToString();
                    if (string.IsNullOrEmpty(matKhau))
                    {
                        string query2 = "UPDATE GiangVien SET MatKhau = @matKhauGV WHERE MaGV = @maGV AND Email = @emailGV";
                        using ( connection = new SqlConnection(strconnectDB))
                        {
                            connection.Open();
                            command = new SqlCommand(query2, connection);
                            command.Parameters.AddWithValue("@matKhauGV", matKhauGV);
                            command.Parameters.AddWithValue("@maGV", maGV);
                            command.Parameters.AddWithValue("@emailGV", emailGV);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Đăng Ký Thành Công");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy giảng viên hoặc nhập không chính xác.");
                            }
                        }
                    }
                    else
                    {
                        // Mật khẩu đã tồn tại
                        MessageBox.Show("Tài khoản đã tồn tại.");
                    }
                }
                else
                {
                    // Không tìm thấy sinh viên
                    MessageBox.Show("Không tìm thấy Giảng Viên.");
                }
                reader.Close();
            }
        }

        public void dangKySV(string query, string maSV, string emailSV, string matKhauSV)
        {
            using (connection = new SqlConnection(strconnectDB))
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maSV", maSV);
                command.Parameters.AddWithValue("@emailSV", emailSV);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string matKhau = reader["MatKhau"].ToString();
                    if (string.IsNullOrEmpty(matKhau))
                    {
                        string query2 = "UPDATE SinhVien SET MatKhau = @matKhauSV WHERE MaSV = @maSV AND Email = @emailSV";

                        using (connection = new SqlConnection(strconnectDB))
                        {
                            connection.Open();
                            command = new SqlCommand(query2, connection);
                            command.Parameters.AddWithValue("@matKhauSV", matKhauSV);
                            command.Parameters.AddWithValue("@maSV", maSV);
                            command.Parameters.AddWithValue("@emailSV", emailSV);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Đăng Ký Thành Công");
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sinh viên hoặc nhập không chính xác.");
                            }
                        }
                    }
                    else
                    {
                        // Mật khẩu đã tồn tại
                        MessageBox.Show("Tài khoản đã tồn tại.");
                    }
                }
                else
                {
                    // Không tìm thấy sinh viên
                    MessageBox.Show("Không tìm thấy Sinh Viên.");
                }
                reader.Close();
            }
        }

        public void dangNhapGV(string query, DataTable table)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void dangNhapSV(string query, DataTable table)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void themKhoa(string maKhoa, string tenKhoa, string diaChi, string query1, string query2)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                command = new SqlCommand(query1, connection);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    throw new Exception("Mã khoa đã tồn tại!");
                }
                reader.Close();
                command = new SqlCommand(query2, connection);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                command.Parameters.AddWithValue("@TenKhoa", tenKhoa);
                command.Parameters.AddWithValue("@DiaChi", diaChi);

                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Thêm thành công", "Thành Công", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void themLop(string maLop, string tenLop, string maKhoa, string query1, string query2)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                command = new SqlCommand(query1, connection);
                command.Parameters.AddWithValue("@MaLop", maLop);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    throw new Exception("Mã khoa đã tồn tại!");
                }
                reader.Close();
                command = new SqlCommand(query2, connection);
                command.Parameters.AddWithValue("@MaLop", maLop);
                command.Parameters.AddWithValue("@TenLop", tenLop);
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                int row = command.ExecuteNonQuery();
                if (row > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Thêm thành công", "Thành Công", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, thêm không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void suaKhoa(string maKhoa, string tenKhoa, string diaChi, string updateQuery)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@MaKhoa", maKhoa);
            command.Parameters.AddWithValue("@TenKhoa", tenKhoa);
            command.Parameters.AddWithValue("@DiaChi", diaChi);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void suaLop(string maLop, string tenLop, string maKhoa, string updateQuery)
        {
            if (connection.State == ConnectionState.Closed)
            {
                creatConnection();
            }
            command = new SqlCommand(updateQuery, connection);
            command.Parameters.AddWithValue("@MaLop", maLop);
            command.Parameters.AddWithValue("@TenLop", tenLop);
            command.Parameters.AddWithValue("@MaKhoa", maKhoa);
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void xoaKhoa(ListView lstKhoa, string deleteQuery)
        {
            if (lstKhoa.SelectedItems.Count > 0)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        creatConnection();
                    }
                    ListViewItem selectedRow = lstKhoa.SelectedItems[0];
                    string maKhoa = selectedRow.SubItems[0].Text; // Lấy giá trị của cột MaMH                                             
                    command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@maKhoa", maKhoa);
                    command.ExecuteNonQuery(); ;
                    // Xóa dòng khỏi ListView
                    lstKhoa.Items.Remove(selectedRow);
                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
            }
        }
        public void xoaLop(ListView lstLopHoc, string deleteQuery)
        {
            if (lstLopHoc.SelectedItems.Count > 0)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        creatConnection();
                    }
                    ListViewItem selectedRow = lstLopHoc.SelectedItems[0];
                    string maLop = selectedRow.SubItems[0].Text; // Lấy giá trị của cột MaMH
                    command = new SqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@maLop", maLop);
                    command.ExecuteNonQuery(); ;
                    // Xóa dòng khỏi ListView
                    lstLopHoc.Items.Remove(selectedRow);
                    // Hiển thị thông báo xóa thành công
                    MessageBox.Show("Xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!");
            }
        }
        public void timKiemKhoa(string query, string searchValue, ListView lstKhoa)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                using (connection = new SqlConnection(strconnectDB))
                {
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["MaKhoa"].ToString());
                        item.SubItems.Add(reader["TenKhoa"].ToString());
                        item.SubItems.Add(reader["DiaChi"].ToString());
                        lstKhoa.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        }
        public void timKiemLop(string query, string searchValue, ListView lstLopHoc)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    creatConnection();
                }
                using (connection = new SqlConnection(strconnectDB))
                {
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchValue", "%" + searchValue + "%");

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Malop"].ToString());
                        item.SubItems.Add(reader["TenLop"].ToString());
                        item.SubItems.Add(reader["MaKhoa"].ToString());
                        lstLopHoc.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
