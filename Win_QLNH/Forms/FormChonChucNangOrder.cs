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
    public partial class FormChonChucNangOrder : Form
    {
        int[] a = new int[5];
        public Button button;

        public FormChonChucNangOrder(Button button)
        {
            InitializeComponent();
            this.button = button;
            GlobalVar.MyBtn = button;
        }


        private void btnChonBan_Click(object sender, EventArgs e)
        {
            if (a[1] % 2 == 0)
            {
                a[1]++;
                btnChonBan.BackColor = Color.Khaki;
                btnChonBan.ForeColor = Color.Black;
                if (btnDatBan.BackColor == Color.Khaki)
                {
                    btnDatBan.BackColor = Color.RoyalBlue;
                    btnDatBan.ForeColor = Color.White;
                    a[2]++;
                }
            }
            else
            {
                a[1]++;
                btnChonBan.BackColor = Color.RoyalBlue;
                btnChonBan.ForeColor = Color.White;
            }
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            if (a[2] % 2 == 0)
            {
                a[2]++;
                btnDatBan.BackColor = Color.Khaki;
                btnDatBan.ForeColor = Color.Black;
                if (btnChonBan.BackColor == Color.Khaki)
                {
                    btnChonBan.BackColor = Color.RoyalBlue;
                    btnChonBan.ForeColor = Color.White;
                    a[1]++;
                }
            }
            else
            {
                a[2]++;
                btnDatBan.BackColor = Color.RoyalBlue;
                btnDatBan.ForeColor = Color.White;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (btnChonBan.BackColor == Color.Khaki) button.BackColor = Color.Silver;
            else if (btnDatBan.BackColor == Color.Khaki) button.BackColor = Color.Khaki;
            this.Close();
        }

        private void btnXemMon_Click(object sender, EventArgs e)
        {
            FormDatMon newPage = new FormDatMon();
            TrangChu formMain = Application.OpenForms.OfType<TrangChu>().FirstOrDefault();
            formMain.OpenChildFormWBut(newPage, button);
            this.Close();
        }
    }
}
