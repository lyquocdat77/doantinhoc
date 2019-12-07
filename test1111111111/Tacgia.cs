using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1111111111
{
    public class Tacgia
    {
        private string matacgia;
        private string tentacgia;

        public string Matacgia
        {
            get { return matacgia; }
            set { matacgia = value; }
        }
        public string Tentacgia
        {
            get { return tentacgia; }
            set { tentacgia = value; }
        }
        
        public Tacgia()
        {
            matacgia = "";
            tentacgia = "";

          
        }
        public Tacgia(string ma, string ten)
        {
            matacgia = ma;
            tentacgia = ten;

           
        }
    }
}
