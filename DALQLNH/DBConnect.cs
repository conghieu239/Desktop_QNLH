using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNH
{
    public class DBconn
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QUANLYNHAHANG2;Integrated Security=True");
    }
}
