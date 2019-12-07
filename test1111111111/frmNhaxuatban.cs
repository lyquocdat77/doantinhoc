using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace test1111111111
{
    public partial class frmNhaxuatban : Form
    {
        public CdmNhaxuatban m_dmnhaxuatban;

        public void hienthi()
        {
            lvwNhaxuatban.View = View.Details;
            lvwNhaxuatban.GridLines = true;
            lvwNhaxuatban.FullRowSelect = true;
            lvwNhaxuatban.Items.Clear();
            lvwNhaxuatban.Columns.Clear();
            lvwNhaxuatban.Columns.Add("Mã Nhà xuất bản", 80);
            lvwNhaxuatban.Columns.Add("Tên Nhà xuất bản", 100);


            foreach (NhaXuatBan hv in m_dmnhaxuatban.dmNhaxuatban.Values)
            {
                ListViewItem lvi = lvwNhaxuatban.Items.Add(hv.Manhaxuatban);
                lvi.SubItems.Add(hv.Tennhaxuatban);
            }
        }

        public frmNhaxuatban()
        {
            InitializeComponent();
        }

        private void btnThemnxb_Click(object sender, EventArgs e)
        {
            NhaXuatBan s = new NhaXuatBan();
            s.Manhaxuatban = txtManxb.Text;
            s.Tennhaxuatban = txtTennxb.Text;

            if (m_dmnhaxuatban.them(s) == true)
            {
                hienthi();

                //----------------------------------------------
                foreach (Form con in this.MdiParent.MdiChildren)
                {
                    if (con.Name == "frmSach")
                    {
                        frmSach con1 = (frmSach)con;
                        con1.HienThiTatCaNXB();
                    }
                }
                //----------------------------------------------
            }
            else
                MessageBox.Show("Đã có mã nhà xuất bản này trong danh sách!");
        }

        private void btnXoanxb_Click(object sender, EventArgs e)
        { 
                bool ok = false;
                foreach (ListViewItem lvi in lvwNhaxuatban.SelectedItems)
                {
                    ok = true;
                    m_dmnhaxuatban.xoa(lvi.SubItems[0].Text);
                }
                if (ok)
                {
                    hienthi();
                }
            
        }

        private void btnSuanxb_Click(object sender, EventArgs e)
        {
            NhaXuatBan s = new NhaXuatBan();
            s.Manhaxuatban = txtManxb.Text;
            s.Tennhaxuatban = txtTennxb.Text;



            if (!m_dmnhaxuatban.sua(s))
                MessageBox.Show("Không sửa dữ liệu được!");
            else
            {
                hienthi();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvwNhaxuatban_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvwNhaxuatban.SelectedItems)
            {
                txtManxb.Text = lvi.SubItems[0].Text;
                txtTennxb.Text = lvi.SubItems[1].Text;
                break;
            }
        }

        private void frmNhaxuatban_Load(object sender, EventArgs e)
        {
            hienthi();
       
        }
    }
}
