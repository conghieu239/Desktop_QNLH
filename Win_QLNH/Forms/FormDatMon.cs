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
    public partial class FormDatMon : Form
    {
        public FormDatMon()
        {
            InitializeComponent();
            button.Add(btnM1);
            button.Add(btnM2);
            button.Add(btnM3);
            button.Add(btnM4);
            button.Add(btnM5);
            button.Add(btnM6);
            button.Add(btnM7);
            button.Add(btnM8);
            button.Add(btnM9);
            button.Add(btnM10);
            button.Add(btnM11);
            button.Add(btnM12);

            label.Add(lbM1);
            label.Add(lbM2);
            label.Add(lbM3);
            label.Add(lbM4);
            label.Add(lbM5);
            label.Add(lbM6);
            label.Add(lbM7);
            label.Add(lbM8);
            label.Add(lbM9);
            label.Add(lbM10);
            label.Add(lbM11);
            label.Add(lbM12);

            /*            if (GlobalVar.SaveVarFood.ContainsKey(GlobalVar.MyBtn))
                        {
                            label1.Text = GlobalVar.SaveVarFood[GlobalVar.MyBtn].ToString();
                            for (int i = 0; i <= GlobalVar.SaveVarNum[GlobalVar.MyBtn].Count(); i++)
                            {
                                label[i].Text = GlobalVar.SaveVarNum[GlobalVar.MyBtn][i];
                            }
                            TinhTien1.Text = "Tổng tiền:     " + GlobalVar.bill.ToString();
                        }*/

            for (int i = 0; i <= 15; i++) b[i] = "";
        }

        public string[] MonAn = new string[100];
        public long s = 0;
        public int[] a = new int[100];
        public string[] b = new string[20];
        public List<Button> button = new List<Button>();
        public List<Label> label = new List<Label>();
        public Dictionary<Button, int> check = new Dictionary<Button, int>();

        private Button _button;

        public void SetButton(Button button)
        {
            _button = button;
        }
        private void Save()
        {
            if (GlobalVar.SaveVarFood.ContainsKey(GlobalVar.MyBtn)) GlobalVar.SaveVarFood[GlobalVar.MyBtn] = label1.Text;
            else GlobalVar.SaveVarFood.Add(GlobalVar.MyBtn, label1.Text);
            if (GlobalVar.SaveVarNum.ContainsKey(GlobalVar.MyBtn))
            {
                GlobalVar.SaveVarNum[GlobalVar.MyBtn].Clear();
                foreach (Label i in label)
                {
                    if (i.Text != "") GlobalVar.SaveVarNum[GlobalVar.MyBtn].Add(i.Text);
                }
            }
            else
            {
                List<string> temp = new List<string>();
                foreach (Label i in label)
                {
                    if (i.Text != "") temp.Add(i.Text);
                }
                GlobalVar.SaveVarNum.Add(GlobalVar.MyBtn, temp);
            }
            GlobalVar.bill = s;
        }
        private void WriteFood(string food, long money, int STT, Button btn)
        {
            a[STT - 1]++;
            b[STT - 1] = food;

            if (check.ContainsKey(btn)) check[btn] = a[STT - 1]; else check.Add(btn, a[STT - 1]);
            label1.Text = "";
            foreach (Label lb in label)
            {
                lb.Text = "";
            }

            int j = 0;

            for (int i = 0; i <= 11; i++)
            {
                if (b[i] != "")
                {
                    label1.Text += b[i];
                    if (check.ContainsKey(button[i])) label[j].Text = check[button[i]].ToString();
                    j++;
                }
            }
            s += money;
            TinhTien1.Text = "Tổng tiền:     " + s.ToString();
            //Save();
        }

        private void HuyMon(string food, long money, int STT, Button btn)
        {
            STT--;
            if (a[STT] > 0)
            {
                a[STT]--;
                check[btn] = a[STT];
                label1.Text = "";
                foreach (Label lb in label)
                {
                    lb.Text = "";
                }
                if (a[STT] > 0) b[STT] = food;
                else b[STT] = "";

                int j = 0;

                for (int i = 0; i <= 11; i++)
                {
                    if (b[i] != "")
                    {
                        label1.Text += b[i];
                        if (check.ContainsKey(button[i])) label[j].Text = check[button[i]].ToString();
                        j++;
                    }
                }
                s -= money;
                TinhTien1.Text = "Tổng tiền:     " + s.ToString();
            }
            //Save();
        }
        private void btnM1_Click(object sender, EventArgs e)
        {
            WriteFood("Khay thịt Un Matin/ Un Matin meat tray\n\n", 890000, 1, btnM1);
        }

        private void btnM2_Click(object sender, EventArgs e)
        {
            WriteFood("Lõi vai bò, Nạm bò Wagyu dùng với Hoa Thiên Lý\n\n", 990000, 2, btnM2);
        }

        private void btnM3_Click(object sender, EventArgs e)
        {
            WriteFood("Khay hải sản Un Matin\n\n", 890000, 3, btnM3);
        }

        private void btnM4_Click(object sender, EventArgs e)
        {
            WriteFood("Cá hồi, cá chẽm, vẹm, tôm sú và mực\n\n", 790000, 4, btnM4);

        }

        private void btnM5_Click(object sender, EventArgs e)
        {
            WriteFood("Cá chép áp chảo Un Matin\n\n", 289000, 5, btnM5);

        }

        private void btnM6_Click(object sender, EventArgs e)
        {
            WriteFood("Bánh Gạo, Kem bọt Hành và Sốt Hạt Điều\n\n", 190000, 6, btnM6);
        }

        private void btnM7_Click(object sender, EventArgs e)
        {
            WriteFood("Thạch Cổ Bê/ Veal Sweetbreads\n\n", 890000, 7, btnM7);

        }

        private void btnM8_Click(object sender, EventArgs e)
        {
            WriteFood("Bánh dâu Pháp/ Fraisier cake\n\n", 890000, 8, btnM8);

        }

        private void btnM9_Click(object sender, EventArgs e)
        {
            WriteFood("Thạch dâu, Genoise, kem Mousseline\n\n", 890000, 9, btnM9);

        }

        private void btnM10_Click(object sender, EventArgs e)
        {
            WriteFood("Trà tứ hoa\n\n", 49000, 10, btnM10);

        }

        private void btnM11_Click(object sender, EventArgs e)
        {
            WriteFood("Cúc tâm trà\n\n", 49000, 11, btnM11);
        }

        private void btnM12_Click(object sender, EventArgs e)
        {
            WriteFood("Trà quý phi", 49000, 12, btnM12);
        }

        private void X1_Click(object sender, EventArgs e)
        {
            HuyMon("Khay thịt Un Matin/ Un Matin meat tray\n\n", 890000, 1, btnM1);
        }

        private void X2_Click(object sender, EventArgs e)
        {
            HuyMon("Lõi vai bò, Nạm bò Wagyu dùng với Hoa Thiên Lý\n\n", 990000, 2, btnM2);
        }

        private void X3_Click(object sender, EventArgs e)
        {
            HuyMon("Khay hải sản Un Matin\n\n", 890000, 3, btnM3);
        }

        private void X4_Click(object sender, EventArgs e)
        {
            HuyMon("Cá hồi, cá chẽm, vẹm, tôm sú và mực\n\n", 790000, 4, btnM4);
        }

        private void X5_Click(object sender, EventArgs e)
        {
            HuyMon("Cá chép áp chảo Un Matin\n\n", 289000, 5, btnM5);
        }

        private void X6_Click(object sender, EventArgs e)
        {
            HuyMon("Bánh Gạo, Kem bọt Hành và Sốt Hạt Điều\n\n", 190000, 6, btnM6);
        }

        private void X7_Click(object sender, EventArgs e)
        {
            HuyMon("Thạch Cổ Bê/ Veal Sweetbreads\n\n", 890000, 7, btnM7);
        }

        private void X8_Click(object sender, EventArgs e)
        {
            HuyMon("Bánh dâu Pháp/ Fraisier cake\n\n", 890000, 8, btnM8);
        }

        private void X9_Click(object sender, EventArgs e)
        {
            HuyMon("Thạch dâu, Genoise, kem Mousseline\n\n", 890000, 9, btnM9);
        }

        private void X10_Click(object sender, EventArgs e)
        {
            HuyMon("Trà tứ hoa\n\n", 49000, 10, btnM10);
        }

        private void X11_Click(object sender, EventArgs e)
        {
            HuyMon("Cúc tâm trà\n\n", 49000, 11, btnM11);
        }

        private void X12_Click(object sender, EventArgs e)
        {
            HuyMon("Trà quý phi", 49000, 12, btnM12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormChonChucNangOrder form = new FormChonChucNangOrder(_button);
            form.ShowDialog();
            this.Close();
            FormOrder newPage = new FormOrder();
            TrangChu formMain = Application.OpenForms.OfType<TrangChu>().FirstOrDefault();
             formMain.OpenChildForm(newPage, button);
        }
    }
}
