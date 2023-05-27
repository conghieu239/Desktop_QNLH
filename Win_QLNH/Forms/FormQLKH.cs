using BLLQLNH;
using DTOQLNH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win_QLNH.Forms;

namespace Win_QLNH.Forms
{
    public partial class FormQLKH : Form
    {
        public FormQLKH()
        {
            InitializeComponent();
        }
        static int i;
        BLLLTKH BLLLTKH = new BLLLTKH();
        DTOLTKH kh = null;
        private void dtg_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dtg_QLKH.CurrentRow.Index;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            kh = new DTOLTKH();


            i = dtg_QLKH.CurrentRow.Index;
            kh.Key_addkh = dtg_QLKH.Rows[i].Cells[0].Value.ToString();
            if (BLLLTKH.DeleteKH(kh))
            {

                dtg_QLKH.DataSource = BLLLTKH.showKH();
            }
            else
                MessageBox.Show("Loi xoa...");
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            FormSuaThongTinKhachHang suaThongTinKhachHang = new FormSuaThongTinKhachHang();
            suaThongTinKhachHang.kh.Key_addkh = dtg_QLKH.Rows[i].Cells[0].Value.ToString();
            suaThongTinKhachHang.ShowDialog();
        }

        private void bt_xem_Click(object sender, EventArgs e)
        {
            dtg_QLKH.DataSource = BLLLTKH.showKH();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
        FormThemTheKhachHang themTheKhachHang = new FormThemTheKhachHang();
            themTheKhachHang.ShowDialog();
        }
    }
}
