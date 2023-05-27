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
    public partial class FormUpdatePNH : Form
    {
        public FormUpdatePNH()
        {
            InitializeComponent();
        }
        BLLQLPNH BLLQLPNH = new BLLQLPNH();
        public DTOQLPNH nh = new DTOQLPNH();
        private void bt_sua_Click(object sender, EventArgs e)
        {
            nh.Idnhap = tb_idnhap.Text;
            nh.Tenhang = tb_tenhang.Text;
            nh.Ngaynhap = dtp_ngaynhap.Value;
            nh.Donvitinh = tb_dvt.Text;
            nh.Dongia = float.Parse(tb_dongia.Text);
            nh.Thanhtien = float.Parse(tb_thanhtien.Text);
            nh.Soluong = int.Parse(tb_soluong.Text);
            nh.Ghichu = tb_ghichu.Text;




            if (BLLQLPNH.UpdatePNH(nh))
            {
                this.Close();
            }
            else
                MessageBox.Show("Lỗi update...");
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
