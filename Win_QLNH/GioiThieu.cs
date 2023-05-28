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
    public partial class GioiThieu : Form
    {
        public GioiThieu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap fmdn = new DangNhap();
            this.Hide();
            fmdn.ShowDialog();
            this.Show();
        }
    }
}
