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
    public partial class FormAddXH : Form
    {
        public FormAddXH()
        {
            InitializeComponent();
        }
        BLLQLXH BLLQLXH = new BLLQLXH();
        DTOQLXH xh = null;
        private void clear()
        {
            tb_idxuat.Clear();
            tb_tenhang.Clear();
            tb_dongia.Clear();
            tb_dvt.Clear();
            tb_ghichu.Clear();
            tb_soluong.Clear();
            tb_thanhtien.Clear();
            dtp_ngayxuat.Value = DateTime.Now;
        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            xh = new DTOQLXH();
            xh.Idxuat = tb_idxuat.Text;
            xh.Tenhang = tb_tenhang.Text;
            xh.Ngayxuat = dtp_ngayxuat.Value;
            xh.Donvitinh = tb_dvt.Text;
            xh.Dongia = float.Parse(tb_dongia.Text);
            xh.Thanhtien = float.Parse(tb_thanhtien.Text);
            xh.Soluong = int.Parse(tb_soluong.Text);
            xh.Ghichu = tb_ghichu.Text;

            if (BLLQLXH.InsertXH(xh))
            { clear(); }
            else
                MessageBox.Show("Lỗi thêm mới...");
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

