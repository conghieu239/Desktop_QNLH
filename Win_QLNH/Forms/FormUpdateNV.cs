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
    public partial class FormUpdateNV : Form
    {
        public FormUpdateNV()
        {
            InitializeComponent();
        }
        BLLQLNV BLLQLNV = new BLLQLNV();
        public DTOQLNV nv= new DTOQLNV() ;

        private void bt_sua_Click(object sender, EventArgs e)
        {
       
            nv.Idnv = tb_id.Text;
            nv.Hoten = tb_ten.Text;
            nv.Sdt = tb_sdt.Text;
            nv.Diachi = tb_calam.Text;
            nv.Gt = tb_gt.Text;
            nv.Luong = float.Parse(tb_luong.Text);
            nv.Calam = int.Parse(tb_calam.Text);
            nv.Ngaysinh = dtp_ngaysinh.Value;
            nv.Ngaylam = dtp_ngaylam.Value;
            

            if (BLLQLNV.UpdateNV(nv))
            {
                this.Close();
            }
            else
                MessageBox.Show("Loi update...");
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
