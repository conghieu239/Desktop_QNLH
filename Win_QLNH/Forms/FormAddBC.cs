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
    public partial class FormAddBC : Form
    {
        public FormAddBC()
        {
            InitializeComponent();
        }
        BLLQLBC BLLQLBC = new BLLQLBC();
        DTOQLBC bc = null;
        private void clear()
        {
            tb_chiphi.Clear();
            tb_id.Clear();
            tb_doanhthu.Clear();
            tb_idnv.Clear();
            tb_loinhuan.Clear();
           
            dtp_ngaythang.Value = DateTime.Now;
      
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            bc = new DTOQLBC();
            bc.Idbc = tb_id.Text;
            bc.Manvbc = tb_idnv.Text;
            bc.Doanhthu = float.Parse(tb_doanhthu.Text);
            bc.Chiphi = float.Parse(tb_chiphi.Text);
            bc.Loinhuan = float.Parse(tb_loinhuan.Text);

            bc.Ngaythang = dtp_ngaythang.Value;

            if (BLLQLBC.InsertBC(bc))
            { clear(); }
            else
                MessageBox.Show("Loi thêm mới...");
        }

        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
