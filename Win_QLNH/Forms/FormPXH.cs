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
    public partial class FormPXH : Form
    {
        public FormPXH()
        {
            InitializeComponent();
        }
        static int i;
        BLLQLXH BLLQLXH = new BLLQLXH();
        DTOQLXH xh = null;
        private void bt_xem_Click(object sender, EventArgs e)
        {
            dtg_XH.DataSource = BLLQLXH.showXH();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            FormAddXH formAddXH = new FormAddXH();
            formAddXH.ShowDialog();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            FormUpdateXH formUpdateXH = new FormUpdateXH();
            formUpdateXH.xh.Key_update = dtg_XH.Rows[i].Cells[0].Value.ToString();
            formUpdateXH.ShowDialog();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            xh = new DTOQLXH();


            i = dtg_XH.CurrentRow.Index;
            xh.Key_update = dtg_XH.Rows[i].Cells[0].Value.ToString();
            if (BLLQLXH.DeleteXH(xh))
            {

                dtg_XH.DataSource = BLLQLXH.showXH();
            }
            else
                MessageBox.Show("Lỗi xóa...");
        }

        private void dtg_XH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dtg_XH.CurrentRow.Index;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
