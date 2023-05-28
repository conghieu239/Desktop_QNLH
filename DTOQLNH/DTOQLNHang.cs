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
    public class DTOQLBC
    {
        private string idbc;
        private string manvbc;
        private DateTime ngaythang;
        
        private float doanhthu;
        private float chiphi;
        private float loinhuan;


        private string key_update;

        public DTOQLBC(string idbc, string manvbc, DateTime ngaythang, float doanhthu, float chiphi, float loinhuan, string key_update)
        {
            this.Idbc = idbc;
            this.Manvbc = manvbc;
            this.Ngaythang = ngaythang;
            this.Doanhthu = doanhthu;
            this.Chiphi = chiphi;
            this.Loinhuan = loinhuan;
            this.Key_update = key_update;
        }

        public string Idbc { get => idbc; set => idbc = value; }
        public string Manvbc { get => manvbc; set => manvbc = value; }
        public DateTime Ngaythang { get => ngaythang; set => ngaythang = value; }
        public float Doanhthu { get => doanhthu; set => doanhthu = value; }
        public float Chiphi { get => chiphi; set => chiphi = value; }
        public float Loinhuan { get => loinhuan; set => loinhuan = value; }
        public string Key_update { get => key_update; set => key_update = value; }
        public DTOQLBC() { }
    }
    public class DTOQLXH
    {
        private string tenhang;
        private string donvitinh;
        private DateTime ngayxuat;
        private string ghichu;
        private float thanhtien;
        private string idxuat;
        private int soluong;
        private float dongia;


        private string key_update;

        public DTOQLXH(string tenhang, string donvitinh, DateTime ngayxuat, string ghichu, float thanhtien, string idxuat, int soluong, float dongia, string key_update)
        {
            this.tenhang = tenhang;
            this.donvitinh = donvitinh;
            this.ngayxuat = ngayxuat;
            this.ghichu = ghichu;
            this.thanhtien = thanhtien;
            this.idxuat = idxuat;
            this.soluong = soluong;
            this.dongia = dongia;
            this.key_update = key_update;
        }
        public DTOQLXH() { }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public DateTime Ngayxuat { get => ngayxuat; set => ngayxuat = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public float Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Idxuat { get => idxuat; set => idxuat = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public string Key_update { get => key_update; set => key_update = value; }
    }
    public class DTOQLPNH
    {
        private string tenhang;
        private string donvitinh;
        private DateTime ngaynhap;
        private string ghichu;
        private float thanhtien;
        private string idnhap;
        private int soluong;
        private float dongia;


        private string key_update;

        public DTOQLPNH(string tenhang, string donvitinh, DateTime ngaynhap, string ghichu, float thanhtien, string idnhap, int soluong, float dongia, string key_update)
        {
            this.tenhang = tenhang;
            this.donvitinh = donvitinh;
            this.ngaynhap = ngaynhap;
            this.ghichu = ghichu;
            this.thanhtien = thanhtien;
            this.idnhap = idnhap;
            this.soluong = soluong;
            this.dongia = dongia;
            this.key_update = key_update;
        }
        public DTOQLPNH() { }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public float Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Idnhap { get => idnhap; set => idnhap = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public string Key_update { get => key_update; set => key_update = value; }
    }
    public class DTOQuyDinh
    {
        private string _MAQD;
        private string _TENQD;
        private string _MANVBIPHAT;
        private string _HINHTHUCPHAT;
        private string _KEY;



        public string TENQD { get => _TENQD; set => _TENQD = value; }
        public string MAQD { get => _MAQD; set => _MAQD = value; }
        public string MANVBIPHAT { get => _MANVBIPHAT; set => _MANVBIPHAT = value; }
        public string HINHTHUCPHAT { get => _HINHTHUCPHAT; set => _HINHTHUCPHAT = value; }
        public string KEY { get => _KEY; set => _KEY = value; }

        public DTOQuyDinh()
        {

        }

        public DTOQuyDinh(string mAQD, string tENQD, string mANVBIPHAT, string hINHTHUCPHAT)
        {
            _MAQD = mAQD;
            _TENQD = tENQD;
            _MANVBIPHAT = mANVBIPHAT;
            _HINHTHUCPHAT = hINHTHUCPHAT;
        }
    }

    public class DTOKhuyenMai
    {
        private string _idkm;
        private string _tenkm;
        private string _giamgia;
        private DateTime _ngaybd;
        private DateTime _ngaykt;
        private string _key;

        public string Idkm { get => _idkm; set => _idkm = value; }
        public string Tenkm { get => _tenkm; set => _tenkm = value; }
        public string Giamgia { get => _giamgia; set => _giamgia = value; }
        public DateTime Ngaybd { get => _ngaybd; set => _ngaybd = value; }
        public DateTime Ngaykt { get => _ngaykt; set => _ngaykt = value; }
        public string Key { get => _key; set => _key = value; }

        public DTOKhuyenMai() { }
        public DTOKhuyenMai(string idkm, string tenkm, string giamgia, DateTime ngaybd, DateTime ngaykt)
        {
            _idkm = idkm;
            _tenkm = tenkm;
            _giamgia = giamgia;
            _ngaybd = ngaybd;
            _ngaykt = ngaykt;

        }
    }

    public class DTOLTKH
    {
        private string thotenkh;
        private DateTime tngaysinhkh;
        private string tgioitinhkh;
        private string tdiachikh;
        private string tsodienthoaikh;
        private string tmakh;

        private string key_addkh;

        public DTOLTKH() { }

        public DTOLTKH(string thotenkh, DateTime tngaysinhkh, string tgioitinhkh, string tdiachikh, string tsodienthoaikh, string tmakh, string key_addkh)
        {
            this.Thotenkh = thotenkh;
            this.Tngaysinhkh = tngaysinhkh;
            this.Tgioitinhkh = tgioitinhkh;
            this.Tdiachikh = tdiachikh;
            this.Tsodienthoaikh = tsodienthoaikh;
            this.Tmakh = tmakh;

        }

        public string Thotenkh { get => thotenkh; set => thotenkh = value; }
        public DateTime Tngaysinhkh { get => tngaysinhkh; set => tngaysinhkh = value; }
        public string Tgioitinhkh { get => tgioitinhkh; set => tgioitinhkh = value; }
        public string Tdiachikh { get => tdiachikh; set => tdiachikh = value; }
        public string Tsodienthoaikh { get => tsodienthoaikh; set => tsodienthoaikh = value; }
        public string Tmakh { get => tmakh; set => tmakh = value; }
        public string Key_addkh { get => key_addkh; set => key_addkh = value; }
    }
    public class DTOTaiKhoan
    {
        private string tendangnhap;
        private string mkdangnhap;
        public string Tendangnghap { get; set; }
        public string Mkdangnhap { get; set; }
        public DTOTaiKhoan(string tendangnghap, string mkdangnhap)
        {
            this.Tendangnghap = tendangnghap;
            this.Mkdangnhap = mkdangnhap;
        }
        public DTOTaiKhoan() { }
    }
}

