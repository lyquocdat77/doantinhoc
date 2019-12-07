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
    public partial class frmTacgia : Form
    {
        public CdmTacgia m_dmtacgia;

        public void hienthi()
        {
            lvwTacgia.View = View.Details;
            lvwTacgia.GridLines = true;
            lvwTacgia.FullRowSelect = true;
            lvwTacgia.Items.Clear();
            lvwTacgia.Columns.Clear();
            lvwTacgia.Columns.Add("Mã tac gia", 80);
            lvwTacgia.Columns.Add("Tên tac gia", 100);
           

            foreach (Tacgia hv in m_dmtacgia.dmTacgia.Values)
            {
                ListViewItem lvi = lvwTacgia.Items.Add(hv.Matacgia);
                lvi.SubItems.Add(hv.Tentacgia);
            }
        }

        public frmTacgia()
        {
            InitializeComponent();
        }

        

        private void btnThemtg_Click(object sender, EventArgs e)
        {
            Tacgia s = new Tacgia();
            s.Matacgia = txtMatg.Text;
            s.Tentacgia = txtTentg.Text;
           
            if (m_dmtacgia.them(s) == true)
            {
                hienthi();

                //----------------------------------------------
                foreach (Form con in this.MdiParent.MdiChildren)
                {
                    if (con.Name == "frmSach")
                    {
                        frmSach con1 = (frmSach)con;
                        con1.HienThiTatCaTacGia();
                        con1.HienThiTatCaTacGiacbox();
                    }
                }
                //----------------------------------------------
            }
            else
                MessageBox.Show("Đã có mã sinh viên này trong danh sách!");
        }

        private void btnXoatg_Click(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (ListViewItem lvi in lvwTacgia.SelectedItems)
            {
                ok = true;
                m_dmtacgia.xoa(lvi.SubItems[0].Text);
            }
            if (ok)
            {
                hienthi();
            }
        }

        private void btnSuatg_Click(object sender, EventArgs e)
        {
            Tacgia s = new Tacgia();
            s.Matacgia = txtMatg.Text;
            s.Tentacgia = txtTentg.Text;
          


            if (!m_dmtacgia.sua(s))
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

        private void lvwTacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvwTacgia.SelectedItems)
            {
                txtMatg.Text = lvi.SubItems[0].Text;
                txtTentg.Text = lvi.SubItems[1].Text;
                break;
            }
        }
        void lvwTacgia_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cmsHV.Show(lvwTacgia, e.X, e.Y);
        }

        private void frmTacgia_Load_1(object sender, EventArgs e)
        {
            hienthi();
            toolTip1.SetToolTip(txtMatg, "Nhập mã ");
            toolTip1.SetToolTip(txtTentg, "Nhập họ");
        }
    }
}
