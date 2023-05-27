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
    public partial class FormSuaThongTinKhachHang : Form
    {
        public FormSuaThongTinKhachHang()
        {
            InitializeComponent();
        }
        BLLLTKH BLLLTKH = new BLLLTKH();
       public  DTOLTKH kh = new DTOLTKH();
        private void Clear()
        {
            tb_stenkh.Clear();
            tb_ssdtkh.Clear();
            tb_smakh.Clear();
            tb_sdiachikh.Clear();
            tb_sgioitinhkh.Clear();
            dtp_sngaysinhkh.Value = DateTime.Now;
        }
        private void btsuattkh_Click(object sender, EventArgs e)
        {
            kh.Thotenkh = tb_stenkh.Text;
            kh.Tmakh = tb_smakh.Text;
            kh.Tgioitinhkh = tb_sgioitinhkh.Text;
            kh.Tdiachikh = tb_sdiachikh.Text;
            kh.Tsodienthoaikh = tb_ssdtkh.Text;
            kh.Tngaysinhkh = dtp_sngaysinhkh.Value;

            if (BLLLTKH.UpdateKH(kh))
            {
                this.Close();
            }
            else
                MessageBox.Show("Lỗi update...");
        }

        private void btsthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
