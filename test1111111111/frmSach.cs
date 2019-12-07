using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1111111111
{
    public partial class frmSach : Form
    {
        public CdmTacgia m_dmtacgia;
        public CdmSach m_dmsach;
        public CdmNhaxuatban m_dmnhaxuatban;
        

        public frmSach()
        {
            InitializeComponent();
        }

        public void HienThiTatCaTacGia()
        {
            lvwTacgia.View = View.Details;
            lvwTacgia.GridLines = true;
            lvwTacgia.FullRowSelect = true;
            lvwTacgia.Items.Clear();
            lvwTacgia.Columns.Clear();
            lvwTacgia.Columns.Add("Mã tác giả", 80);
            lvwTacgia.Columns.Add("Tên tác giả", 100);

            foreach (Tacgia hv in m_dmtacgia.dmTacgia.Values)
            {
                ListViewItem lvi = lvwTacgia.Items.Add(hv.Matacgia);
                lvi.SubItems.Add(hv.Tentacgia);
            }
        }

        public void HienThiTatCaTacGiacbox()
        {

            foreach (Tacgia hv in m_dmtacgia.dmTacgia.Values)
            {
                //cbtacgia.DataSource = hv;
                //cbtacgia.DisplayMember = hv.Matacgia;
                cbtacgia.Items.Add(hv);
                cbtacgia.DisplayMember = "hv.Tentacgia";
                cbtacgia.ValueMember = "hv.Matacgia";
            }
            //BindingSource bs = new BindingSource(m_dmtacgia.dmTacgia.Values,null);
           
            //cbtacgia.DataSource = bs;
            





        }

        public void HienThiTatCaNXB()
        {
            lvwNxb.View = View.Details;
            lvwNxb.GridLines = true;
            lvwNxb.FullRowSelect = true;
            lvwNxb.Items.Clear();
            lvwNxb.Columns.Clear();
            lvwNxb.Columns.Add("Mã NXB", 80);
            lvwNxb.Columns.Add("Tên NXB", 100);

            foreach (NhaXuatBan hv in m_dmnhaxuatban.dmNhaxuatban.Values)
            {
                ListViewItem lvi = lvwNxb.Items.Add(hv.Manhaxuatban);
                lvi.SubItems.Add(hv.Tennhaxuatban);
            }
        }


        public void hienthi()
        {
            lvwSach.View = View.Details;
            lvwSach.GridLines = true;
            lvwSach.FullRowSelect = true;
            lvwSach.Items.Clear();
            lvwSach.Columns.Clear();
            lvwSach.Columns.Add("Mã sách", 100);
            lvwSach.Columns.Add("Tên sách", 200);
            lvwSach.Columns.Add("Loại sách", 100);
            lvwSach.Columns.Add("Tác giả", 100);
            lvwSach.Columns.Add("Nhà xuất bản", 100);


            foreach (Sach lh in m_dmsach.dmsach.Values)
            {
                ListViewItem lvi = lvwSach.Items.Add(lh.Masach);
                lvi.SubItems.Add(lh.Tensach);
                lvi.SubItems.Add(lh.Loaisach);
                Sach lop = m_dmsach.tim(lh.Masach);
                foreach (Tacgia hv in lop.DanhMucTacGia.Values)
                {
                    lvi.SubItems.Add(hv.Tentacgia);
                }
            }
            
        }

        public void hienthiSach(string malop)
        {
            Sach lop = m_dmsach.tim(malop);
            if (lop != null)
            {
                lvwtacgiacuasach.View = View.Details;
                lvwtacgiacuasach.GridLines = true;
                lvwtacgiacuasach.FullRowSelect = true;
                lvwtacgiacuasach.Items.Clear();
                lvwtacgiacuasach.Columns.Clear();
                lvwtacgiacuasach.Columns.Add("Mã tac gia", 80);
                lvwtacgiacuasach.Columns.Add("Tên tac gia", 100);


                foreach (Tacgia hv in lop.DanhMucTacGia.Values)
                {
                    ListViewItem lvi = lvwtacgiacuasach.Items.Add(hv.Matacgia);
                    lvi.SubItems.Add(hv.Tentacgia);
                }
            }
        }

        public void hienthiNXB(string malop)
        {
            Sach lop = m_dmsach.tim(malop);
            if (lop != null)
            {
                lvwnxbcuasach.View = View.Details;
                lvwnxbcuasach.GridLines = true;
                lvwnxbcuasach.FullRowSelect = true;
                lvwnxbcuasach.Items.Clear();
                lvwnxbcuasach.Columns.Clear();
                lvwnxbcuasach.Columns.Add("Mã NXB", 80);
                lvwnxbcuasach.Columns.Add("Tên NXB", 100);

                foreach (NhaXuatBan hv in lop.DanhMucNhaXuatBan.Values)
                {
                    ListViewItem lvi = lvwnxbcuasach.Items.Add(hv.Manhaxuatban);
                    lvi.SubItems.Add(hv.Tennhaxuatban);

                }
            }
        }



        public CdmSach CdmSach
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach lop = new Sach();
            lop.Masach = txtMasach.Text;
            lop.Tensach = txtTensach.Text;
            lop.Loaisach = txtLoaisach.Text;
            
            //m_dmsach.themHV(txtMasach.Text, hv);

            //if (lvwTacgia.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Bạn chưa chọn tác giả.");
            //    return;
            //}
            //if (txtMasach.Text.Trim() == "")
            //{
            //    MessageBox.Show("Bạn chưa chọn sách.");
            //    return;
            //}
            //foreach (Tacgia lvi in cbtacgia.SelectedItem)
            //{
                
              
               
            //    break;
            //}



            if (m_dmsach.them(lop) == true )
            {
                
                //Tacgia hv = m_dmtacgia.tim(cbtacgia.SelectedValue.ToString());
                //if (m_dmsach.themHV(txtMasach.Text, hv) == true) { hienthi(); } else { MessageBox.Show("!"); }

            }
            else
                MessageBox.Show("Đã có Mã sách này trong danh sách!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (ListViewItem lvi in lvwSach.SelectedItems)
            {
                ok = true;
                m_dmsach.xoa(lvi.SubItems[0].Text);
            }
            if (ok)
            {
                hienthi();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Sach lop = new Sach();
            lop.Masach = txtMasach.Text;
            lop.Tensach = txtTensach.Text;
            lop.Loaisach = txtLoaisach.Text;
        


            if (!m_dmsach.sua(lop))
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

        private void lvwSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvwSach.SelectedItems)
            {
                txtMasach.Text = lvi.SubItems[0].Text;
                txtTensach.Text = lvi.SubItems[1].Text;
                txtLoaisach.Text = lvi.SubItems[2].Text;
                hienthiSach(lvi.SubItems[0].Text);
                hienthiNXB(lvi.SubItems[0].Text);
                break;
            }
        }

        private void btnThemtacgiavao_Click(object sender, EventArgs e)
        {
            if (lvwTacgia.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn tác giả.");
                return;
            }
            if (txtMasach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn sách.");
                return;
            }
            foreach (ListViewItem lvi in lvwTacgia.SelectedItems)
            {
                Tacgia hv = new Tacgia();
                hv = m_dmtacgia.tim(lvi.SubItems[0].Text);
                m_dmsach.themHV(txtMasach.Text, hv);
                hienthiSach(txtMasach.Text);
                hienthi();
                break;
            }
        }

        private void btnXoatacgiara_Click(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (ListViewItem lvi in lvwtacgiacuasach.SelectedItems)
            {
                Tacgia hv;
                hv = m_dmtacgia.tim(lvi.SubItems[0].Text);
                if (hv != null)
                {
                    ok = true;
                    m_dmsach.xoaHV(txtMasach.Text, lvi.SubItems[0].Text);
                    break;
                }
                else
                    MessageBox.Show("Không tim thấy tác giả cần xóa trong danh sách.");
            }
            if (ok)
            {
                hienthiSach(txtMasach.Text);
            }
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            hienthi();
            HienThiTatCaTacGia();
            HienThiTatCaNXB();
            HienThiTatCaTacGiacbox();
        }

        private void lvwtacgiacuasach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwnxbcuasach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoanxbra_Click(object sender, EventArgs e)
        {
            bool ok = false;
            foreach (ListViewItem lvi in lvwnxbcuasach.SelectedItems)
            {
                NhaXuatBan hv;
                hv = m_dmnhaxuatban.tim(lvi.SubItems[0].Text);
                if (hv != null)
                {
                    ok = true;
                    m_dmsach.xoaNXB(txtMasach.Text, lvi.SubItems[0].Text);
                    break;
                }
                else
                    MessageBox.Show("Không tim thấy NXB cần xóa trong danh sách.");
            }
            if (ok)
            {
                hienthiNXB(txtMasach.Text);
            }
        }

        private void btnThemnxbvao_Click(object sender, EventArgs e)
        {
            if (lvwNxb.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn NXB.");
                return;
            }
            if (txtMasach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn sách.");
                return;
            }
            foreach (ListViewItem lvi in lvwNxb.SelectedItems)
            {
                NhaXuatBan hv = new NhaXuatBan();
                hv = m_dmnhaxuatban.tim(lvi.SubItems[0].Text);
                m_dmsach.themNXB(txtMasach.Text, hv);
                hienthiNXB(txtMasach.Text);
                break;
            }
        }

        private void cbtacgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ////cbtacgia.SelectedItem.
            string var;
            ////var = comboBox1.Text;
            ////Or
            var item = this.cbtacgia.SelectedItem.ToString();
            MessageBox.Show(item);
            ComboBox
        }
    }
}
