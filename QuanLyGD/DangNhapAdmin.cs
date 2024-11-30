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
    public partial class DangNhapAdmin : Form
    {
        DBAcccess dBAcccess = new DBAcccess();
        DataTable dtUsers = new DataTable();
        public DangNhapAdmin()
        {
            InitializeComponent();
        }

        private void btnGiangVienDN_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
        }

        private void DangNhapAdmin_Load(object sender, EventArgs e)
        {
        }

        private void btnAdminDN_Click(object sender, EventArgs e)
        {
            string adminTK = txtAdminTK.Text;
            string adminMK = txtAdminMK.Text;
            if (adminTK.Equals(""))
            {
                MessageBox.Show("Please enter your email");
            }
            else if (adminMK.Equals(""))
            {
                MessageBox.Show("Please enter your password");
            }
            else
            {
                string query = "SELECT * FROM Admin WHERE TaiKhoan = '" + adminTK + "'AND MatKhau = '" + adminMK + "'";
                dBAcccess.readDatathroughAdapter(query, dtUsers);
                if (dtUsers.Rows.Count == 1)
                {
                    MessageBox.Show("Login Success");
                    dBAcccess.closeConn();
                    this.Hide();
                    QuanLy ql = new QuanLy();
                    ql.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error Invalid");
                }
            }
        }

        private void DangNhapAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
    
}
