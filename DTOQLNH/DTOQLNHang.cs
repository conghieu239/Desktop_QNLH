using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOQLNH
{
    public class DTOQLNV
    {
        private string idnv;
        private string hoten;
        private DateTime ngaysinh;
        private string sdt;
        private string gt;
        private string diachi;
        private DateTime ngaylam;
        private int calam;
        private float luong;

        private string key_update;

        public DTOQLNV(string idnv, string hoten, DateTime ngaysinh, string sdt, string gt, string diachi, DateTime ngaylam, int calam, float luong)
        {
            this.idnv = idnv;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.sdt = sdt;
            this.gt = gt;
            this.diachi = diachi;
            this.ngaylam = ngaylam;
            this.calam = calam;
            this.luong = luong;
        }
        public DTOQLNV() { }

        public string Idnv { get => idnv; set => idnv = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Gt { get => gt; set => gt = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public DateTime Ngaylam { get => ngaylam; set => ngaylam = value; }
        public int Calam { get => calam; set => calam = value; }
        public float Luong { get => luong; set => luong = value; }
        public string Key_update { get => key_update; set => key_update = value; }
    }
}

