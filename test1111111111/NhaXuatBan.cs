using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1111111111
{
    public class NhaXuatBan
    {
        private string manhaxuatban;
        private string tennhaxuatban;

        public string Manhaxuatban
        {
            get { return manhaxuatban; }
            set { manhaxuatban = value; }
        }
        public string Tennhaxuatban
        {
            get { return tennhaxuatban; }
            set { tennhaxuatban = value; }
        }

        public NhaXuatBan()
        {
            manhaxuatban = "";
            tennhaxuatban = "";


        }
        public NhaXuatBan(string ma, string ten)
        {
            manhaxuatban = ma;
            tennhaxuatban = ten;


        }







    }
}
