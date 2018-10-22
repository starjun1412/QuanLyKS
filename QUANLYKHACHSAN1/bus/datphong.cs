using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using data1;

namespace bus
{
    public class datphong
    {
        datanv da = new datanv();
        public DataTable ttkhang()
        {
            string sql = "select * from KHACHHANG";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return (dt);
        }
        //thêm
        public void InsertHK(string ma, string ten, string cm, string dc, string sdt, string gt, string nd, string nt, string ns, string ck)
        {
            string sql = "insert KHACHHANG values('" + ma + "',N'" + ten + "','" + cm + "',N'" + dc + "','" + sdt + "',N'" + gt + "','" + nd + "','" + nt + "','" + ns + "','" + ck + "')";
            da.ExecuteNonQuery(sql);
        }
        //sửa
        public void updatekh(string mak, string ma, string ten, string dc, string cm, string sdt, string gt, string nd, string nt, string ns, string ck )
        {
            string sql = "update KHACHHANG set MAKH='" + ma + "',TENKH=N'" + ten + "',DIACHI=N'" + dc + "',SDT='" + sdt + "',CMND='" + cm + "',GIOITINH='" + gt + "',NGAYDAT='" + nd + "',NGAYTRA='" + nt + "',NGAYSINH='" + ns + "',CHECKIN='" + ck + "' where MAKH=N'" + mak + "'";
            da.ExecuteNonQuery(sql);
        }
        //hủy
        public void deleteKH(string ma)
        {
            string sql = "delete KHACHHANG where MAKH = N'" + ma + "'";
            da.ExecuteNonQuery(sql);
        }
        //tìm kiếm
        public DataTable lookingHK(string dk)
        {
            string sql = "select * from KHACHHANG where MAKH like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //checkin
        public DataTable checkinHKY()
        {
            string sql = "select * from KHACHHANG where CHECKIN like N'%YES'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        public DataTable checkinHKN()
        {
            string sql = "select * from KHACHHANG where CHECKIN like N'%NO'";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
    }
}
