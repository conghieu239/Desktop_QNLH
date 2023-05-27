using DALQLNH;
using DTOQLNH;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLQLNH
{
    public class BLLQLNV
    {
        DALQLNV DALQLNV = new DALQLNV();
        public DataTable showNV()
        {
            DataTable dt = DALQLNV.showNV();
            return dt;
        }
        public bool InsertNV(DTOQLNV nv)
        {
            return DALQLNV.insertNV(nv);
        }
        public bool UpdateNV(DTOQLNV nv)
        {
            return DALQLNV.updateNV(nv);
        }
        public bool DeleteNV(DTOQLNV nv)
        {
            return DALQLNV.deleteNV(nv);
        }
    }
    public class BLLQLBC
    {
        DALQLBC DALQLBC = new DALQLBC();
        public DataTable showBC()
        {
            DataTable dt = DALQLBC.showBC();
            return dt;
        }
        public bool InsertBC(DTOQLBC bc)
        {
            return DALQLBC.insertBC(bc);
        }
        public bool UpdateBC(DTOQLBC bc)
        {
            return DALQLBC.updateBC(bc);
        }
        public bool DeleteBC(DTOQLBC bc)
        {
            return DALQLBC.deleteBC(bc);
        }
    }
    public class BLLQLXH
    {
        DALQLXH DALQLXH = new DALQLXH();
        public DataTable showXH()
        {
            DataTable dt = DALQLXH.showXH();
            return dt;
        }
        public bool InsertXH(DTOQLXH xh)
        {
            return DALQLXH.insertXH(xh);
        }
        public bool UpdateXH(DTOQLXH xh)
        {
            return DALQLXH.updateXH(xh);
        }
        public bool DeleteXH(DTOQLXH xh)
        {
            return DALQLXH.deleteXH(xh);
        }

    }
    public class BLLQLPNH
    {
        DALQLPNH DALQLPNH = new DALQLPNH();
        public DataTable showPNH()
        {
            DataTable dt = DALQLPNH.showPNH();
            return dt;
        }
        public bool InsertPNH(DTOQLPNH nh)
        {
            return DALQLPNH.insertPNH(nh);
        }
        public bool UpdatePNH(DTOQLPNH nh)
        {
            return DALQLPNH.updatePNH(nh);
        }
        public bool DeletePNH(DTOQLPNH nh)
        {
            return DALQLPNH.deletePNH(nh);
        }

    }
    public class BLLQuyDinh
    {
        DALQuyDinh dALQuyDinh = new DALQuyDinh();

        public DataTable SelectQuyDinh()
        {
            DataTable dt = dALQuyDinh.SelectQuyDinh();
            return dt;
        }

        public bool InsertQD(DTOQuyDinh qd)
        {
            return dALQuyDinh.InsertQuyDinh(qd);
        }

        public bool UpdateQD(DTOQuyDinh qd)
        {
            return dALQuyDinh.UpdateQD(qd);
        }

        public bool DeleteQD(DTOQuyDinh qd)
        {
            return dALQuyDinh.deleteQD(qd);
        }

    }

    public class BLLKhuyenMai
    {
        DALKhuyenMai dALKM = new DALKhuyenMai();

        public DataTable showKM()
        {
            DataTable dt = dALKM.showKM();
            return dt;
        }

        public bool InsertKM(DTOKhuyenMai km)
        {
            return dALKM.InsertKM(km);
        }

        public bool UpdateKM(DTOKhuyenMai km)
        {
            return dALKM.UpdateKM(km);
        }

        public bool DeleteKM(DTOKhuyenMai km)
        {
            return dALKM.DeleteKM(km);
        }
    }
    public class BLLLTKH
    {
        DALLTKH DALLTKH = new DALLTKH();
        public DataTable showKH()
        {
            DataTable dt = DALLTKH.showKH();
            return dt;
        }
        public bool InsertKH(DTOLTKH kh)
        {
            return DALLTKH.insertKH(kh);
        }
        public bool UpdateKH(DTOLTKH kh)
        {
            return DALLTKH.updateKH(kh);
        }
        public bool DeleteKH(DTOLTKH kh)
        {
            return DALLTKH.deleteKH(kh);
        }
    }
}
