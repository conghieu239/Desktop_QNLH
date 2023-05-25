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
}
