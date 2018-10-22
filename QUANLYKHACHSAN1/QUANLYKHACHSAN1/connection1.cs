using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYKHACHSAN1
{
    class connection1
    {
            SqlConnection conn;
            SqlDataAdapter dataadap;
            public string strComm = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLKSdemo;Integrated Security=True";
            public DataSet getDulieu(string sql)
            {
                try
                {
                    conn = new SqlConnection(strComm);
                    conn.Open();
                    dataadap = new SqlDataAdapter(sql, conn);
                    DataSet d = new DataSet();
                    dataadap.Fill(d, sql);
                    conn.Close();
                    return d;
                }
                catch (Exception )
                {
                    return null;
                }
            }
        }
 }
