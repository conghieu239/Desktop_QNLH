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
    public partial class FormUpdateXH : Form
    {
        public FormUpdateXH()
        {
            InitializeComponent();
        }
        BLLQLXH BLLQLXH = new BLLQLXH();
        public DTOQLXH xh = new DTOQLXH();

        private void bt_sua_Click(object sender, EventArgs e)
        {
            xh.Idxuat = tb_idxuat.Text;
            xh.Tenhang = tb_tenhang.Text;
            xh.Ngayxuat = dtp_ngayxuat.Value;
            xh.Donvitinh = tb_dvt.Text;
            xh.Dongia = float.Parse(tb_dongia.Text);
            xh.Thanhtien = float.Parse(tb_thanhtien.Text);
            xh.Soluong = int.Parse(tb_soluong.Text);
            xh.Ghichu = tb_ghichu.Text;




            if (BLLQLXH.UpdateXH(xh))
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
