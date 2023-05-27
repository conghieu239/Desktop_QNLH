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
    public partial class FormAddPNH : Form
    {
        public FormAddPNH()
        {
            InitializeComponent();
        }
        BLLQLPNH BLLQLPNH = new BLLQLPNH();
        DTOQLPNH nh = null;
        private void clear()
        {
            tb_dongia.Clear();
            tb_dvt.Clear();
            tb_ghichu.Clear();
            tb_idnhap.Clear();
            tb_soluong.Clear();
            tb_tenhang.Clear();
            tb_thanhtien.Clear();
            dtp_ngaynhap.Value = DateTime.Now;


        }
        private void bt_them_Click(object sender, EventArgs e)
        {
            nh = new DTOQLPNH();
            nh.Idnhap = tb_idnhap.Text;
            nh.Tenhang = tb_tenhang.Text;
            nh.Ngaynhap = dtp_ngaynhap.Value;
            nh.Donvitinh = tb_dvt.Text;
            nh.Dongia = float.Parse(tb_dongia.Text);
            nh.Thanhtien = float.Parse(tb_thanhtien.Text);
            nh.Soluong = int.Parse(tb_soluong.Text);
            nh.Ghichu = tb_ghichu.Text;

            if (BLLQLPNH.InsertPNH(nh))
            {
                clear();
            }
            else
                MessageBox.Show("Loi thêm mới...");
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
