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
    public partial class FormBC : Form
    {
        public FormBC()
        {
            InitializeComponent();
        }
        static int i;
        BLLQLBC BLLQLBC = new BLLQLBC();
        DTOQLBC bc = null;
       

        private void bt_xem_Click_1(object sender, EventArgs e)
        {
            dtg_QLBC.DataSource = BLLQLBC.showBC();
        }

        private void bt_them_Click_1(object sender, EventArgs e)
        {
            FormAddBC formAddBC = new FormAddBC();
            formAddBC.ShowDialog();
        }

        private void bt_sua_Click_1(object sender, EventArgs e)
        {
            FormUpdateBC formUpdateBC = new FormUpdateBC();
            formUpdateBC.bc.Key_update = dtg_QLBC.Rows[i].Cells[0].Value.ToString();
            formUpdateBC.ShowDialog();
        }

        private void bt_xoa_Click_1(object sender, EventArgs e)
        {
            bc = new DTOQLBC();


            i = dtg_QLBC.CurrentRow.Index;
            bc.Key_update = dtg_QLBC.Rows[i].Cells[0].Value.ToString();
            if (BLLQLBC.DeleteBC(bc))
            {

                dtg_QLBC.DataSource = BLLQLBC.showBC();
            }
            else
                MessageBox.Show("Loi xoa...");
        }

        private void dtg_QLBC_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            i = dtg_QLBC.CurrentRow.Index;
        }
    }
}
