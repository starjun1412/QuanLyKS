using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYKHACHSAN1
{
    class loginobject
    {
        string tenlogin, matkhau;
        public loginobject()
        { }
        public loginobject(string t, string mk, string ma)
        {
            Tenlogin = t;
            Matkhau = mk;
        }
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public string Tenlogin
        {
            get { return tenlogin; }
            set { tenlogin = value; }
        }
    }
}
