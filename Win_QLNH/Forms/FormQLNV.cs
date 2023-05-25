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
    public partial class FormQLNV : Form
    {
        public FormQLNV()
        {
            InitializeComponent();
        }
        static  int i;
        BLLQLNV BLLQLNV = new BLLQLNV();
        DTOQLNV nv = null;
        private void dtg_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dtg_QLNV.CurrentRow.Index;
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            FormUpdateNV formUpdateNV = new FormUpdateNV();
            formUpdateNV.nv.Key_update = dtg_QLNV.Rows[i].Cells[0].Value.ToString();
            formUpdateNV.ShowDialog();

        }

        private void bt_xem_Click(object sender, EventArgs e)
        {

            dtg_QLNV.DataSource = BLLQLNV.showNV();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            FormAddNV formAddNV = new FormAddNV();
            formAddNV.ShowDialog();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            nv = new DTOQLNV();


            i = dtg_QLNV.CurrentRow.Index;
            nv.Key_update = dtg_QLNV.Rows[i].Cells[0].Value.ToString();
            if (BLLQLNV.DeleteNV(nv))
            {
               
                dtg_QLNV.DataSource = BLLQLNV.showNV();
            }
            else
                MessageBox.Show("Loi xoa...");
        }
    }
}
