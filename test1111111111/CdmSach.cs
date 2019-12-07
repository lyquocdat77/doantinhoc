using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace test1111111111
{
     public class CdmSach
    {
        private Hashtable m_dmsach;
        public CdmSach()
        {
            m_dmsach = new Hashtable();
        }
        public Hashtable dmsach
        {
            get { return m_dmsach; }
        }
        public Sach[] arraySach
        {
            get
            {
                Sach[] x = new Sach[m_dmsach.Count];
                m_dmsach.Values.CopyTo(x, 0);
                return x;
            }
        }

        public Sach Sach
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public bool them(Sach lh)
        {
            try
            {
                m_dmsach.Add(lh.Masach, lh);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //public bool sua(LopHoc lh)
        //{
        //    try
        //    {
        //        LopHoc a = (LopHoc)m_dmLop[lh.Malop];
        //        if (a == null) return false;
        //        a.Khoa = lh.Khoa;
        //        a.HeDaoTao = lh.HeDaoTao;
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public bool sua(Sach lh)
        {
            try
            {
                m_dmsach.Remove(lh.Masach);
                m_dmsach.Add(lh.Masach, lh);
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
                m_dmsach.Remove(key);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Sach tim(string key)
        {
            return (Sach)m_dmsach[key];
        }

        public bool themHV(string malop, Tacgia hv)
        {
            try
            {
                Sach lop = tim(malop);
                if (lop != null)
                {
                    lop.DanhMucTacGia.Add(hv.Matacgia, hv);
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool themNXB(string malop, NhaXuatBan hv)
        {
            try
            {
                Sach lop = tim(malop);
                if (lop != null)
                {
                    lop.DanhMucNhaXuatBan.Add(hv.Manhaxuatban, hv);
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }




        public bool xoaHV(string masach, string matacgia)
        {
            try
            {
                Sach sach = tim(masach);
                if (sach != null)
                {
                    sach.DanhMucTacGia.Remove(matacgia);
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNXB(string masach, string manxb)
        {
            try
            {
                Sach sach = tim(masach);
                if (sach != null)
                {
                    sach.DanhMucNhaXuatBan.Remove(manxb);
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }



        public bool xoaHV2(string masach, Tacgia s)
        {
            try
            {
                Sach sach = tim(masach);
                if (sach != null)
                {
                    sach.DanhMucTacGia.Remove(s.Matacgia);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
