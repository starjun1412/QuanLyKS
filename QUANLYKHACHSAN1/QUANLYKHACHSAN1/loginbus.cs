using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYKHACHSAN1
{
    class loginbus
    {
        connection1 conn = new connection1();
        loginobject lgob = new loginobject();
        public DataSet layDS(string u, string p)
        {
            string sql = "select * from TAIKHOAN where TENDN=N'" + u + "' and MATKHAU=N'" + p + "'";
            return conn.getDulieu(sql);
        }
        public DataSet layDS(loginobject lg)
        {
            string sql = "select * from TAIKHOAN where TENDN=N'" + lg.Tenlogin + "' and MATKHAU=N'" + lg.Matkhau + "'";
            return conn.getDulieu(sql);
        }
    }
}
