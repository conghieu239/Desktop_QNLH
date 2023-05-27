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
    public partial class FormQuyDinh : Form
    {
        public FormQuyDinh()
        {
            InitializeComponent();
        }

        BLLQuyDinh bLLQD = new BLLQuyDinh();
        DTOQuyDinh qd = null;

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            dgv_QuyDinh.DataSource = bLLQD.SelectQuyDinh();

            dgv_QuyDinh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_QuyDinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            qd = new DTOQuyDinh();
            qd.MAQD = txt_MaQD.Text;
            qd.TENQD = txt_TenQD.Text;
            qd.MANVBIPHAT = txt_MaPhat.Text;
            qd.HINHTHUCPHAT = txt_HinhThuc.Text;

            if (bLLQD.InsertQD(qd))
                dgv_QuyDinh.DataSource = bLLQD.SelectQuyDinh();
            else
                MessageBox.Show("Error...");
        }

        public DTOQuyDinh upqd = new DTOQuyDinh();


        static int i;
        BLLQuyDinh BLLQD = new BLLQuyDinh();
        private void dtg_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = dgv_QuyDinh.CurrentRow.Index;
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            qd = new DTOQuyDinh();
            qd.MAQD = txt_MaQD.Text;
            qd.TENQD = txt_TenQD.Text;
            qd.MANVBIPHAT = txt_MaPhat.Text;
            qd.HINHTHUCPHAT = txt_HinhThuc.Text;

            int i;
            i = dgv_QuyDinh.CurrentRow.Index;
            qd.KEY = dgv_QuyDinh.Rows[i].Cells[0].Value.ToString();

            if (bLLQD.UpdateQD(qd))
                dgv_QuyDinh.DataSource = bLLQD.SelectQuyDinh();
            else
                MessageBox.Show("Error...");
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            qd = new DTOQuyDinh();
            i = dgv_QuyDinh.CurrentRow.Index;
            qd.KEY = dgv_QuyDinh.Rows[i].Cells[0].Value.ToString();
            if (BLLQD.DeleteQD(qd))
                dgv_QuyDinh.DataSource = bLLQD.SelectQuyDinh();
            else
                MessageBox.Show("Error...");

        }

        private void dgv_QuyDinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_QuyDinh.CurrentRow.Index;
            txt_MaQD.Text = dgv_QuyDinh.Rows[i].Cells[0].Value.ToString();
            txt_TenQD.Text = dgv_QuyDinh.Rows[i].Cells[1].Value.ToString();
            txt_MaPhat.Text = dgv_QuyDinh.Rows[i].Cells[2].Value.ToString();
            txt_HinhThuc.Text = dgv_QuyDinh.Rows[i].Cells[3].Value.ToString();
        }
    }
}
