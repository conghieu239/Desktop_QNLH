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
        Dictionary<Button, int> map = new Dictionary<Button, int>();

        public FormOrder()
        {
            InitializeComponent();
        }

        private void ChonBan(Button btnBan)
        {
            int z = 1;
            if (map.ContainsKey(btnBan)) z = ++map[btnBan] % 3;
                else map.Add(btnBan, 1);
            if (z == 0) btnBan.BackColor = Color.White;
            if (z == 1) btnBan.BackColor = Color.Yellow;
            if (z == 2) btnBan.BackColor = Color.Gray;
        }

        private void openForm()
        {
            this.Hide();
            FormChonChucNangOrder form = new FormChonChucNangOrder();
            form.ShowDialog();
            this.Close();
        }
        private void BtnT1B1_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT1B2_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT1B3_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT1B4_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT1B5_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT1B6_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT2B1_Click(object sender, EventArgs e)
        {   
            openForm();
        }

        private void BtnT2B2_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT2B3_Click(object sender, EventArgs e)
        {
            openForm();

        }

        private void BtnT2B4_Click(object sender, EventArgs e)
        {
            openForm();

        }

        private void BtnT2B5_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT2B6_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT2B7_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT2B8_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT2B9_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT3B1_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT3B2_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT3B3_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT3B4_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT3B5_Click(object sender, EventArgs e)
        {
            openForm();
        }

        private void BtnT3B6_Click(object sender, EventArgs e)
        {
            openForm();
        }
    }
}
