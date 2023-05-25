using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_QLNH
{
    public partial class TrangChu : Form
    {

        private Form activeForm;
        public TrangChu()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(childForm);
            this.panelMenu.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }


        private void btnLTKH_Click(object sender, EventArgs e)
        {
       
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormQLNV(), sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOrder(), sender);
        }

        private void btnPXH_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void btnPhieuNhapHang_Click(object sender, EventArgs e)
        {

        }

        private void btnKhac_Click(object sender, EventArgs e)
        {

        }

    }
}
