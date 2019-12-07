using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace test1111111111
{
    public class CdmNhaxuatban
    {
        private Hashtable m_dmnhaxuatban;
        public CdmNhaxuatban()
        {
            m_dmnhaxuatban = new Hashtable();
        }
        public Hashtable dmNhaxuatban
        {
            get
            {
                return m_dmnhaxuatban;
            }
        }
        public NhaXuatBan[] arraynhaxuatban
        {
            get
            {
                NhaXuatBan[] x = new NhaXuatBan[m_dmnhaxuatban.Count];
                m_dmnhaxuatban.Values.CopyTo(x, 0);
                return x;
            }
        }
        public bool them(NhaXuatBan hv)
        {
            try
            {             
                    m_dmnhaxuatban.Add(hv.Manhaxuatban, hv);
                    return true;
            }
            catch
            {
                return false;
            }
        }
        public bool sua(NhaXuatBan s)
        {
            try
            {
                NhaXuatBan a = (NhaXuatBan)m_dmnhaxuatban[s.Manhaxuatban];
                if (a == null) return false;
                a.Tennhaxuatban = s.Tennhaxuatban;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoa(string key)
        {
            try
            {
                m_dmnhaxuatban.Remove(key);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public NhaXuatBan tim(string key)
        {
            return (NhaXuatBan)m_dmnhaxuatban[key];
        }
    }
}
