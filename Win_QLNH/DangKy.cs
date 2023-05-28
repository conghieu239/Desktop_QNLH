using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOQLNH;
using BLLQLNH;

namespace Win_QLNH
{
    public partial class DangKy : Form
    {
        DTOTaiKhoan dk = new DTOTaiKhoan();

        public DangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dk.Tendangnghap = txtTDN.Text;
            dk.Mkdangnhap = txtMKDK.Text;
            BLLTaikhoan dkTaiKhoan = new BLLTaikhoan();
            bool registrationSuccess = dkTaiKhoan.RegisterUser(dk.Tendangnghap, dk.Mkdangnhap);
            if (registrationSuccess)
            {
                if (txtMKDK.Text == txtXNMK.Text)
                {
                    DialogResult rs = MessageBox.Show("Đăng ký thành công xin vui lòng đăng nhập lại", "Thông báo", MessageBoxButtons.OK);
                    if (rs == DialogResult.OK)
                    {
                        DangNhap dn = new DangNhap();
                        this.Hide();
                        dn.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Đảm bảo bạn nhập đúng mật khẩu vào ô xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
