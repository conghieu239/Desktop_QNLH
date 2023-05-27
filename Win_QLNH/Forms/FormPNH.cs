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
    public partial class FormPNH : Form
    {
        public FormPNH()
        {
            InitializeComponent();
        }
        static int i;
        BLLQLPNH BLLQLPNH = new BLLQLPNH();
        DTOQLPNH nh = null;
        private void bt_xem_Click(object sender, EventArgs e)
        {
            dtg_NH.DataSource = BLLQLPNH.showPNH();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            FormAddPNH formAddPNH = new FormAddPNH();
            formAddPNH.ShowDialog();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            FormUpdatePNH formUpdatePNH = new FormUpdatePNH();
            formUpdatePNH.nh.Key_update = dtg_NH.Rows[i].Cells[0].Value.ToString();
            formUpdatePNH.ShowDialog();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            nh = new DTOQLPNH();


            i = dtg_NH.CurrentRow.Index;
            nh.Key_update = dtg_NH.Rows[i].Cells[0].Value.ToString();
            if (BLLQLPNH.DeletePNH(nh))
            {

                dtg_NH.DataSource = BLLQLPNH.showPNH();
            }
            else
                MessageBox.Show("Lỗi xóa...");
        }

        private void dtg_NH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dtg_NH.CurrentRow.Index;
        }
    }
}
