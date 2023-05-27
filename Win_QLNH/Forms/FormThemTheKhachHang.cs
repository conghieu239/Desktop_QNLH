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

namespace Win_QLNH.Forms
{
    public partial class FormThemTheKhachHang : Form
    {
        public FormThemTheKhachHang()
        {
            InitializeComponent();
        }
        BLLLTKH BLLLTKH = new BLLLTKH();
        DTOLTKH kh = null;
        private void Clear()
        {
            tb_ttenkh.Clear();
            tb_tsdtkh.Clear();
            tb_tmakh.Clear();
            tb_tdiachikh.Clear();
            tb_tgioitinhkh.Clear();
            dtp_tngaysinhkh.Value = DateTime.Now;
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            kh = new DTOLTKH();
            kh.Thotenkh = tb_ttenkh.Text;
            kh.Tmakh = tb_tmakh.Text;
            kh.Tgioitinhkh = tb_tgioitinhkh.Text;
            kh.Tdiachikh = tb_tdiachikh.Text;
            kh.Tsodienthoaikh = tb_tsdtkh.Text;
            kh.Tngaysinhkh = dtp_tngaysinhkh.Value;

            if (BLLLTKH.InsertKH(kh))
            { Clear(); }
            else
                MessageBox.Show("Lỗi thêm mới...");
        }

       

        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
