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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
        private void openForm(Button btn)
        {
            ;
            FormChonChucNangOrder form = new FormChonChucNangOrder(btn);
            form.ShowDialog();

        }
        private void BtnT1B1_Click(object sender, EventArgs e)
        {
            openForm(BtnT1B1);
        }

        private void BtnT1B2_Click(object sender, EventArgs e)
        {
            openForm(BtnT1B2);
        }

        private void BtnT1B3_Click(object sender, EventArgs e)
        {
            openForm(BtnT1B3);
        }

        private void BtnT1B4_Click(object sender, EventArgs e)
        {
            openForm(BtnT1B4);
        }

        private void BtnT1B5_Click(object sender, EventArgs e)
        {
            openForm(BtnT1B5);
        }

        private void BtnT1B6_Click(object sender, EventArgs e)
        {
            openForm(BtnT1B6);
        }

        private void BtnT2B1_Click(object sender, EventArgs e)
        {
            openForm(BtnT2B1);
        }

        private void BtnT2B2_Click(object sender, EventArgs e)
        {
            openForm(BtnT2B2);
        }

        private void BtnT2B3_Click(object sender, EventArgs e)
        {
            openForm(BtnT2B3);

        }

        private void BtnT2B4_Click(object sender, EventArgs e)
        {
            openForm(BtnT2B4);

        }

        private void BtnT2B5_Click(object sender, EventArgs e)
        {
            openForm(BtnT2B5);
        }

        private void BtnT2B6_Click(object sender, EventArgs e)
        {
            openForm(BtnT2B6);
        }

        private void BtnT2B7_Click(object sender, EventArgs e)
        {
            openForm(BtnT2B7);
        }

        private void BtnT2B8_Click(object sender, EventArgs e)
        {
            openForm(BtnT2B8);
        }

        private void BtnT2B9_Click(object sender, EventArgs e)
        {
            openForm(BtnT2B9);
        }

        private void BtnT3B1_Click(object sender, EventArgs e)
        {
            openForm(BtnT3B1);
        }

        private void BtnT3B2_Click(object sender, EventArgs e)
        {
            openForm(BtnT3B2);
        }

        private void BtnT3B3_Click(object sender, EventArgs e)
        {
            openForm(BtnT3B3);
        }

        private void BtnT3B4_Click(object sender, EventArgs e)
        {
            openForm(BtnT3B4);
        }

        private void BtnT3B5_Click(object sender, EventArgs e)
        {
            openForm(BtnT3B5);
        }

        private void BtnT3B6_Click(object sender, EventArgs e)
        {
            openForm(BtnT3B6);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
