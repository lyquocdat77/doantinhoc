using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace test1111111111
{
    public class Sach
    {
        protected string masach;
        protected string tensach;
        protected string loaisach;
        private Hashtable dmtacgia;
        private Hashtable dmnhaxuatban;


        public Sach()
        {
            masach = "";
            tensach = "";
            loaisach = "";
       
            dmtacgia = new Hashtable();
            dmnhaxuatban = new Hashtable();
        }
        public Sach(string ma, string ten, string loai, string nhaxuaban)
        {
            masach = ma;
            tensach = ten;
            loaisach = loai;
    
            dmtacgia = new Hashtable();
            dmnhaxuatban = new Hashtable();
        }
        public string Masach
        {
            get
            {
                return masach;
            }
            set
            {
                masach = value;
            }
        }
        public string Tensach
        {
            get
            {
                return tensach;
            }
            set
            {
                tensach = value;
            }
        }
        public string Loaisach
        {
            get
            {
                return loaisach;
            }
            set
            {
                loaisach = value;
            }
        }

      

        public Hashtable DanhMucTacGia
        {
            get { return dmtacgia; }
            set { dmtacgia = value; }
        }

        public Hashtable DanhMucNhaXuatBan
        {
            get { return dmnhaxuatban; }
            set { dmnhaxuatban = value; }
        }

    }
}
