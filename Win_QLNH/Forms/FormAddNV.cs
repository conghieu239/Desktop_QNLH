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
    public partial class FormAddNV : Form
    {
        public FormAddNV()
        {
            InitializeComponent();
        }
        BLLQLNV BLLQLNV = new BLLQLNV();
        DTOQLNV nv = null;
        private void clear()
        {
            tb_ten.Clear();
            tb_id.Clear();
            tb_diachi.Clear();
            tb_calam.Clear();
            tb_gt.Clear();
            tb_sdt.Clear();
            tb_luong.Clear();
            dtp_ngaylam.Value = DateTime.Now;
            dtp_ngaysinh.Value = DateTime.Now;

        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            nv = new DTOQLNV();
            nv.Idnv = tb_id.Text;
            nv.Hoten = tb_ten.Text;
            nv.Sdt = tb_sdt.Text;
            nv.Diachi = tb_calam.Text;
            nv.Gt = tb_gt.Text;
            nv.Luong = float.Parse(tb_luong.Text);
            nv.Calam = int.Parse(tb_calam.Text);
            nv.Ngaysinh = dtp_ngaysinh.Value;
            nv.Ngaylam = dtp_ngaylam.Value;

            if (BLLQLNV.InsertNV(nv))
            { clear(); }
            else
                MessageBox.Show("Loi thêm mới...");
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
