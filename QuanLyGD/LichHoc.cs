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
    public partial class LichHoc : Form
    {
        DBAcccess dBAcccess = new DBAcccess();
        public LichHoc()
        {
            InitializeComponent();
        }


        private void lichHoc_Load(object sender, EventArgs e)
        {
            string query = "SELECT LichGiangDay.MaLGD, LichGiangDay.ThoiGian, LichGiangDay.PhongHoc, Lop.TenLop, GiangVien.Hoten FROM LichGiangDay INNER JOIN Lop ON LichGiangDay.MaLop = Lop.MaLop INNER JOIN GiangVien ON LichGiangDay.MaGV = GiangVien.MaGV";
            dBAcccess.lichHoc(query, lstLichHoc);
        }

        private void LichHoc_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
