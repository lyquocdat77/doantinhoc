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
    public partial class Form1 : Form
    {
        internal CdmSach m_dmsach = new CdmSach();
        internal CdmTacgia m_dmtacgia = new CdmTacgia();
        internal CdmNhaxuatban m_dmnhaxuatban = new CdmNhaxuatban();
        public Form1()
        {
            InitializeComponent();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach frm = new frmSach();
            frm.MdiParent = this;
            frm.m_dmsach = m_dmsach;
            frm.m_dmtacgia = m_dmtacgia;
            frm.m_dmnhaxuatban = m_dmnhaxuatban;
            frm.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacgia frm = new frmTacgia();
            frm.MdiParent = this;
            frm.m_dmtacgia = m_dmtacgia;
            frm.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNhaxuatban frm = new frmNhaxuatban();
            frm.MdiParent = this;
            frm.m_dmnhaxuatban = m_dmnhaxuatban;
            frm.Show();
        }
    }
}
