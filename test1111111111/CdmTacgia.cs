using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace test1111111111
{
     public class CdmTacgia
    {
        private Hashtable m_dmtacgia;
        public CdmTacgia()
        {
            m_dmtacgia = new Hashtable();
        }
        public Hashtable dmTacgia
        {
            get
            {
                return m_dmtacgia;
            }
        }
        public Tacgia[] arrayTacGia
        {
            get
            {
                Tacgia[] x = new Tacgia[m_dmtacgia.Count];
                m_dmtacgia.Values.CopyTo(x, 0);
                return x;
            }
        }
        public bool them(Tacgia hv)
        {
            try
            {
                m_dmtacgia.Add(hv.Matacgia, hv);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool sua(Tacgia s)
        {
            try
            {
                Tacgia a = (Tacgia)m_dmtacgia[s.Matacgia];
                if (a == null) return false;
                a.Tentacgia = s.Tentacgia;
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
                m_dmtacgia.Remove(key);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Tacgia tim(string key)
        {
            return (Tacgia)m_dmtacgia[key];
        }


    }
}
