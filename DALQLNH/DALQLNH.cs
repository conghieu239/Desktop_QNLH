using DTOQLNH;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNH
{
    public class DALQLNV : DBconn
    {
        public DataTable showNV()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from nhanvien", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                //conn.Close();

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool updateNV(DTOQLNV nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update nhanvien set idnv=@id,ten=@ten,ngaysinh=@ngaysinh,sdt=@sdt,gt=@gt,dc=@dc,ngaylam=@ngaylam,calam=@calam,luong=@luong where idnv=@key", conn);
                cmd.Parameters.AddWithValue("@id", nv.Idnv);
                cmd.Parameters.AddWithValue("@ten", nv.Hoten);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.Ngaysinh.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@sdt", nv.Sdt);
                cmd.Parameters.AddWithValue("@gt", nv.Gt);
                cmd.Parameters.AddWithValue("@dc", nv.Diachi);
                cmd.Parameters.AddWithValue("@ngaylam", nv.Ngaylam.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@calam", nv.Calam);
                cmd.Parameters.AddWithValue("@luong", nv.Luong);
                cmd.Parameters.AddWithValue("@key", nv.Key_update);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool insertNV(DTOQLNV nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into nhanvien values (@id,@ten,@ngaysinh,@sdt,@gt,@dc,@ngaylam,@calam,@luong)", conn);
                cmd.Parameters.AddWithValue("@id", nv.Idnv);
                cmd.Parameters.AddWithValue("@ten", nv.Hoten);
                cmd.Parameters.AddWithValue("@ngaysinh", nv.Ngaysinh.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@sdt", nv.Sdt);
                cmd.Parameters.AddWithValue("@gt", nv.Gt);
                cmd.Parameters.AddWithValue("@dc", nv.Diachi);
                cmd.Parameters.AddWithValue("@ngaylam", nv.Ngaylam.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@calam", nv.Calam);
                cmd.Parameters.AddWithValue("@luong", nv.Luong);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteNV(DTOQLNV nv)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from nhanvien where nhanvien.idnv=@key", conn);

                cmd.Parameters.AddWithValue("@key", nv.Key_update);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
    public class DALQLBC : DBconn
    {
        public DataTable showBC()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from baocao", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                //conn.Close();

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool updateBC(DTOQLBC bc)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update baocao set idbc=@id,manvbc=@idnv,ngaythang=@ngaythang,doanhthu=@doanhthu,chiphi=@chiphi,loinhuan=@loinhuan where idbc=@key", conn);
                cmd.Parameters.AddWithValue("@id", bc.Idbc);
                cmd.Parameters.AddWithValue("@idnv", bc.Manvbc);
                cmd.Parameters.AddWithValue("@ngaythang", bc.Ngaythang.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@doanhthu", bc.Doanhthu);
                cmd.Parameters.AddWithValue("@chiphi", bc.Chiphi);
                cmd.Parameters.AddWithValue("@loinhuan", bc.Loinhuan);

                cmd.Parameters.AddWithValue("@key", bc.Key_update);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool insertBC(DTOQLBC bc)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into baocao values (@id,@idnv,@ngaythang,@doanhthu,@chiphi,@loinhuan)", conn);
                cmd.Parameters.AddWithValue("@id", bc.Idbc);
                cmd.Parameters.AddWithValue("@idnv", bc.Manvbc);
                cmd.Parameters.AddWithValue("@ngaythang", bc.Ngaythang.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@doanhthu", bc.Doanhthu);
                cmd.Parameters.AddWithValue("@chiphi", bc.Chiphi);
                cmd.Parameters.AddWithValue("@loinhuan", bc.Loinhuan);
          

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteBC(DTOQLBC bc)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from baocao where baocao.idbc=@key", conn);

                cmd.Parameters.AddWithValue("@key", bc.Key_update);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

    }
    public class DALQLXH : DBconn
    {
        public DataTable showXH()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from xuathang", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                //conn.Close();

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool updateXH(DTOQLXH xh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update xuathang set idxuat=@Idxuat, ngayxuat=@Ngayxuat,tenhang=@Tenhang,donvitinh=@Donvitinh,thanhtien=@Thanhtien,soluong=@Soluong,dongia=@Dongia,ghichu=@Ghichu where idxuat=@key", conn);
                cmd.Parameters.AddWithValue("@Ngayxuat", xh.Ngayxuat.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Tenhang", xh.Tenhang);
                cmd.Parameters.AddWithValue("@Idxuat", xh.Idxuat);
                cmd.Parameters.AddWithValue("@Donvitinh", xh.Donvitinh);
                cmd.Parameters.AddWithValue("@Thanhtien", xh.Thanhtien);
                cmd.Parameters.AddWithValue("@Soluong", xh.Soluong);
                cmd.Parameters.AddWithValue("@Dongia", xh.Dongia);
                cmd.Parameters.AddWithValue("@Ghichu", xh.Ghichu);
                cmd.Parameters.AddWithValue("@key", xh.Key_update);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool insertXH(DTOQLXH xh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into xuathang values (@Idxuat, @Ngayxuat,@Tenhang,@Donvitinh,@Thanhtien,@Soluong,@Dongia,@Ghichu)", conn);
                cmd.Parameters.AddWithValue("@Ngayxuat", xh.Ngayxuat.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Tenhang", xh.Tenhang);
                cmd.Parameters.AddWithValue("@Idxuat", xh.Idxuat);
                cmd.Parameters.AddWithValue("@Donvitinh", xh.Donvitinh);
                cmd.Parameters.AddWithValue("@Thanhtien", xh.Thanhtien);
                cmd.Parameters.AddWithValue("@Soluong", xh.Soluong);
                cmd.Parameters.AddWithValue("@Dongia", xh.Dongia);
                cmd.Parameters.AddWithValue("@Ghichu", xh.Ghichu);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteXH(DTOQLXH xh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from xuathang where xuathang.idxuat=@key", conn);

                cmd.Parameters.AddWithValue("@key", xh.Key_update);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
    public class DALQLPNH : DBconn
    {
        public DataTable showPNH()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from nhaphang", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                //conn.Close();

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool updatePNH(DTOQLPNH nh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update nhaphang set idnhap=@Idnhap, ngaynhap=@Ngaynhap,tenhang=@Tenhang,donvitinh=@Donvitinh,thanhtien=@Thanhtien,soluong=@Soluong,dongia=@Dongia,ghichu=@Ghichu where idnhap=@key", conn);
                cmd.Parameters.AddWithValue("@Ngaynhap", nh.Ngaynhap.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Tenhang", nh.Tenhang);
                cmd.Parameters.AddWithValue("@Idnhap", nh.Idnhap);
                cmd.Parameters.AddWithValue("@Donvitinh", nh.Donvitinh);
                cmd.Parameters.AddWithValue("@Thanhtien", nh.Thanhtien);
                cmd.Parameters.AddWithValue("@Soluong", nh.Soluong);
                cmd.Parameters.AddWithValue("@Dongia", nh.Dongia);
                cmd.Parameters.AddWithValue("@Ghichu", nh.Ghichu);
                cmd.Parameters.AddWithValue("@key", nh.Key_update);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool insertPNH(DTOQLPNH nh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into nhaphang values (@Idnhap, @Ngaynhap,@Tenhang,@Donvitinh,@Thanhtien,@Soluong,@Dongia,@Ghichu)", conn);
                cmd.Parameters.AddWithValue("@Ngaynhap", nh.Ngaynhap.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@Tenhang", nh.Tenhang);
                cmd.Parameters.AddWithValue("@Idnhap", nh.Idnhap);
                cmd.Parameters.AddWithValue("@Donvitinh", nh.Donvitinh);
                cmd.Parameters.AddWithValue("@Thanhtien", nh.Thanhtien);
                cmd.Parameters.AddWithValue("@Soluong", nh.Soluong);
                cmd.Parameters.AddWithValue("@Dongia", nh.Dongia);
                cmd.Parameters.AddWithValue("@Ghichu", nh.Ghichu);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deletePNH(DTOQLPNH nh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from nhaphang where nhaphang.idnhap=@key", conn);

                cmd.Parameters.AddWithValue("@key", nh.Key_update);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }

    public class DALQuyDinh : DBconn
    {


        public DataTable SelectQuyDinh()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select*from QUYDINH", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();  //close
                return dt;

            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool InsertQuyDinh(DTOQuyDinh qd)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into QUYDINH(MAQD,TENQD,MANVBIPHAT,HINHTHUCPHAT) values (@mAQD, @tENQD, @mANVBIPHAT, @hINHTHUCPHAT)", conn);
                cmd.Parameters.AddWithValue("@mAQD", qd.MAQD);
                cmd.Parameters.AddWithValue("@tENQD", qd.TENQD);
                cmd.Parameters.AddWithValue("@mANVBIPHAT", qd.MANVBIPHAT);
                cmd.Parameters.AddWithValue("@hINHTHUCPHAT", qd.HINHTHUCPHAT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool UpdateQD(DTOQuyDinh qd)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update QUYDINH set MAQD = @mAQD,  TENQD=@tENQD, MANVBIPHAT=@mANVBIPHAT, HINHTHUCPHAT=@hINHTHUCPHAT where MAQD=@Key", conn);
                cmd.Parameters.AddWithValue("@tENQD", qd.TENQD);
                cmd.Parameters.AddWithValue("@mANVBIPHAT", qd.MANVBIPHAT);
                cmd.Parameters.AddWithValue("@hINHTHUCPHAT", qd.HINHTHUCPHAT);
                cmd.Parameters.AddWithValue("@mAQD", qd.MAQD);
                cmd.Parameters.AddWithValue("@Key", qd.KEY);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool deleteQD(DTOQuyDinh qd)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from QUYDINH where QUYDINH.MAQD=@key", conn);

                cmd.Parameters.AddWithValue("@key", qd.KEY);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;


        }
    }

    public class DALKhuyenMai : DBconn
    {
        public DataTable showKM()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from KHUYENMAI ", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                //conn.Close();

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool InsertKM(DTOKhuyenMai km)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into KHUYENMAI(IDKM,TENKM,GIAMGIA,NGAYBATDAU,NGAYKETTHUC) values (@idkm, @tenkm, @giamgia, @ngaybd, @ngaykt)", conn);
                cmd.Parameters.AddWithValue("@idkm", km.Idkm);
                cmd.Parameters.AddWithValue("@tenkm", km.Tenkm);
                cmd.Parameters.AddWithValue("@giamgia", km.Giamgia);
                cmd.Parameters.AddWithValue("@ngaybd", km.Ngaybd.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@ngaykt", km.Ngaykt.ToString("yyyy/MM/dd"));

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool UpdateKM(DTOKhuyenMai km)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update KHUYENMAI set IDKM=@idkm,TENKM=@tenkm,GIAMGIA=@giamgia,NGAYBATDAU=@ngaybd,NGAYKETTHUC=@ngaykt where IDKM=@key", conn);
                cmd.Parameters.AddWithValue("@idkm", km.Idkm);
                cmd.Parameters.AddWithValue("@tenkm", km.Tenkm);
                cmd.Parameters.AddWithValue("@giamgia", km.Giamgia);
                cmd.Parameters.AddWithValue("@ngaybd", km.Ngaybd.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@ngaykt", km.Ngaykt.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@key", km.Key);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool DeleteKM(DTOKhuyenMai km)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from KHUYENMAI where KHUYENMAI.IDKM=@key", conn);

                cmd.Parameters.AddWithValue("@key", km.Key);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
    public class DALLTKH : DBconn
    {
        public DataTable showKH()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from KHACHHANG", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                //conn.Close();

                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool updateKH(DTOLTKH kh)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update KHACHHANG set makh=@makh, hotenkh=@tenkh,ngaysinhkh=@ngaysinhkh,gioitinhkh=@gtkh,sodienthoai=@sodienthoaikh,diachi=@diachikh where makh=@keykh", conn);
                cmd.Parameters.AddWithValue("@tenkh", kh.Thotenkh);
                cmd.Parameters.AddWithValue("@ngaysinhkh", kh.Tngaysinhkh.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@sodienthoaikh", kh.Tsodienthoaikh);
                cmd.Parameters.AddWithValue("@makh", kh.Tmakh);
                cmd.Parameters.AddWithValue("@gtkh", kh.Tgioitinhkh);
                cmd.Parameters.AddWithValue("@diachikh", kh.Tdiachikh);
                cmd.Parameters.AddWithValue("@keykh", kh.Key_addkh);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool insertKH(DTOLTKH kh)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into KHACHHANG values (@makh,@tenkh,@ngaysinhkh,@gtkh,@sodienthoaikh,@diachikh)", conn);
                cmd.Parameters.AddWithValue("@tenkh", kh.Thotenkh);
                cmd.Parameters.AddWithValue("@ngaysinhkh", kh.Tngaysinhkh.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@sodienthoaikh", kh.Tsodienthoaikh);
                cmd.Parameters.AddWithValue("@makh", kh.Tmakh);
                cmd.Parameters.AddWithValue("@gtkh", kh.Tgioitinhkh);
                cmd.Parameters.AddWithValue("@diachikh", kh.Tdiachikh);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteKH(DTOLTKH kh)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from KHACHHANG where KHACHHANG.makh=@key", conn);

                cmd.Parameters.AddWithValue("@key", kh.Key_addkh);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
