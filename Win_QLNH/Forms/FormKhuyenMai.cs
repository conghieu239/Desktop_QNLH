using BLLQLNH;
using DTOQLNH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_QLNH.Forms
{
    public partial class FormKhuyenMai : Form
    {
        public FormKhuyenMai()
        {
            InitializeComponent();
        }

        BLLKhuyenMai BLLKM = new BLLKhuyenMai();
        DTOKhuyenMai km = null;

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            dgv_KhuyenMai.DataSource = BLLKM.showKM();
            dgv_KhuyenMai.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_KhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            km = new DTOKhuyenMai();
            km.Idkm = txt_IDKM.Text;
            km.Tenkm = txt_TenKM.Text;
            km.Giamgia = txt_GiamGia.Text;
            km.Ngaybd = dtp_Start.Value;
            km.Ngaykt = dtp_End.Value;

            if (BLLKM.InsertKM(km))
                dgv_KhuyenMai.DataSource = BLLKM.showKM();
            else
                MessageBox.Show("Error...");
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            km = new DTOKhuyenMai();
            km.Idkm = txt_IDKM.Text;
            km.Tenkm = txt_TenKM.Text;
            km.Giamgia = txt_GiamGia.Text;
            km.Ngaykt = dtp_End.Value;
            km.Ngaybd = dtp_Start.Value;
            int i;
            i = dgv_KhuyenMai.CurrentRow.Index;
            km.Key = dgv_KhuyenMai.Rows[i].Cells[0].Value.ToString();

            if (BLLKM.UpdateKM(km))
                dgv_KhuyenMai.DataSource = BLLKM.showKM();
            else
                MessageBox.Show("Error...");
        }

        static int i;

        private void btn_Del_Click(object sender, EventArgs e)
        {
            km = new DTOKhuyenMai();
            i = dgv_KhuyenMai.CurrentRow.Index;
            km.Key = dgv_KhuyenMai.Rows[i].Cells[0].Value.ToString();
            if (BLLKM.DeleteKM(km))
                dgv_KhuyenMai.DataSource = BLLKM.showKM();
            else
                MessageBox.Show("Error...");
        }

        private void dgv_KhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv_KhuyenMai.CurrentRow.Index;
            txt_IDKM.Text = dgv_KhuyenMai.Rows[i].Cells[0].Value.ToString();
            txt_TenKM.Text = dgv_KhuyenMai.Rows[i].Cells[1].Value.ToString();
            txt_GiamGia.Text = dgv_KhuyenMai.Rows[i].Cells[2].Value.ToString();
            dtp_Start.Text = dgv_KhuyenMai.Rows[i].Cells[3].Value.ToString();
            dtp_End.Text = dgv_KhuyenMai.Rows[i].Cells[4].Value.ToString();

        }
    }
}
