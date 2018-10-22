using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace data1
{
    public class datanv
    {

        
        //liên kết database
        public SqlConnection getConnection()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLKSdemo;Integrated Security=True");
        }
        // lấy dữ liệu từ SQL lên
        public DataTable getTable(string sql)
        {
            SqlConnection con = getConnection();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        // thực thi câu lện SQL
        public void ExecuteNonQuery(string sql)
        {
            SqlConnection con = getConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
