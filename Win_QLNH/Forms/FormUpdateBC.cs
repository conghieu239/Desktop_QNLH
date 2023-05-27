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
    public partial class FormUpdateBC : Form
    {
        public FormUpdateBC()
        {
            InitializeComponent();
        }
        BLLQLBC BLLQLBC = new BLLQLBC();
        public DTOQLBC bc = new DTOQLBC();


        private void bt_sua_Click_1(object sender, EventArgs e)
        {

            bc.Idbc = tb_id.Text;
            bc.Manvbc = tb_idnv.Text;
            bc.Doanhthu = float.Parse(tb_doanhthu.Text);
            bc.Chiphi = float.Parse(tb_chiphi.Text);
            bc.Loinhuan = float.Parse(tb_loinhuan.Text);

            bc.Ngaythang = dtp_ngaythang.Value;


            if (BLLQLBC.UpdateBC(bc))
            {
                this.Close();
            }
            else
                MessageBox.Show("Loi update...");
        }

        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
