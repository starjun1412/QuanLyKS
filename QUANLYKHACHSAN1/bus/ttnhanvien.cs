using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data1;
using System.Data;

namespace bus
{
    public class ttnhanvien
    {
        datanv da = new datanv();
        public DataTable ttnv()
        {
            string sql = "select * from NHANVIEN1";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return (dt);
        }
        //thêm
        public void InsertNV (string ma, string ten, string cv, string ns, string gt, string st, string cm)
        {
            string sql = "insert NHANVIEN1 values('" + ma + "',N'" + ten + "',N'" + cv + "','" + st + "','" + cm + "','" + gt + "','" + ns + "')";
            da.ExecuteNonQuery(sql);
        }

        //sửa
        public void update (string ma1, string ma, string ten, string cv, string gt, string st, string ns, string cm)
        {
            string sql = "update NHANVIEN1 set MANV='" + ma + "',TENNV=N'" + ten + "',CHUCVU=N'" + cv + "',CMND=N'" + cm + "',GIOITINH=N'" + gt + "',NGAYSINH='" + ns + "',SDT='" + st + "' where MANV=N'" + ma1 + "'";
            da.ExecuteNonQuery(sql);
        }
        //xóa
        public void delete (string ma)
        {
            string sql = "delete NHANVIEN1 where MANV = N'" + ma + "'";
            da.ExecuteNonQuery(sql);
        }
        //tìm kiếm
        public DataTable looking (string dk)
        {
            string sql = "select * from NHANVIEN1 where MANV like N'%"+dk+"%'" ;
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
    }
}
