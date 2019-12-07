namespace test1111111111
{
    partial class frmTacgia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwTacgia = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSuatg = new System.Windows.Forms.Button();
            this.btnXoatg = new System.Windows.Forms.Button();
            this.btnThemtg = new System.Windows.Forms.Button();
            this.txtTentg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsHV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmsHV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Danh sách tác giả";
            // 
            // lvwTacgia
            // 
            this.lvwTacgia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvwTacgia.FullRowSelect = true;
            this.lvwTacgia.GridLines = true;
            this.lvwTacgia.HideSelection = false;
            this.lvwTacgia.Location = new System.Drawing.Point(13, 176);
            this.lvwTacgia.Margin = new System.Windows.Forms.Padding(4);
            this.lvwTacgia.MultiSelect = false;
            this.lvwTacgia.Name = "lvwTacgia";
            this.lvwTacgia.Size = new System.Drawing.Size(488, 251);
            this.lvwTacgia.TabIndex = 61;
            this.lvwTacgia.UseCompatibleStateImageBehavior = false;
            this.lvwTacgia.View = System.Windows.Forms.View.Details;
            this.lvwTacgia.SelectedIndexChanged += new System.EventHandler(this.lvwTacgia_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã tác giả";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên tác giả";
            this.columnHeader6.Width = 115;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(386, 113);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 28);
            this.btnThoat.TabIndex = 60;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSuatg
            // 
            this.btnSuatg.Location = new System.Drawing.Point(386, 77);
            this.btnSuatg.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuatg.Name = "btnSuatg";
            this.btnSuatg.Size = new System.Drawing.Size(117, 28);
            this.btnSuatg.TabIndex = 59;
            this.btnSuatg.Text = "Sửa tác giả";
            this.btnSuatg.UseVisualStyleBackColor = true;
            this.btnSuatg.Click += new System.EventHandler(this.btnSuatg_Click);
            // 
            // btnXoatg
            // 
            this.btnXoatg.Location = new System.Drawing.Point(386, 42);
            this.btnXoatg.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoatg.Name = "btnXoatg";
            this.btnXoatg.Size = new System.Drawing.Size(117, 28);
            this.btnXoatg.TabIndex = 58;
            this.btnXoatg.Text = "Xóa tác giả";
            this.btnXoatg.UseVisualStyleBackColor = true;
            this.btnXoatg.Click += new System.EventHandler(this.btnXoatg_Click);
            // 
            // btnThemtg
            // 
            this.btnThemtg.Location = new System.Drawing.Point(386, 6);
            this.btnThemtg.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemtg.Name = "btnThemtg";
            this.btnThemtg.Size = new System.Drawing.Size(117, 28);
            this.btnThemtg.TabIndex = 57;
            this.btnThemtg.Text = "Thêm tác giả";
            this.btnThemtg.UseVisualStyleBackColor = true;
            this.btnThemtg.Click += new System.EventHandler(this.btnThemtg_Click);
            // 
            // txtTentg
            // 
            this.txtTentg.Location = new System.Drawing.Point(149, 39);
            this.txtTentg.Margin = new System.Windows.Forms.Padding(4);
            this.txtTentg.Name = "txtTentg";
            this.txtTentg.Size = new System.Drawing.Size(216, 22);
            this.txtTentg.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tên tác giả";
            // 
            // txtMatg
            // 
            this.txtMatg.Location = new System.Drawing.Point(149, 7);
            this.txtMatg.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatg.MaxLength = 10;
            this.txtMatg.Name = "txtMatg";
            this.txtMatg.Size = new System.Drawing.Size(164, 22);
            this.txtMatg.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã tác giả";
            // 
            // cmsHV
            // 
            this.cmsHV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsHV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.cmsHV.Name = "cmsHV";
            this.cmsHV.Size = new System.Drawing.Size(117, 52);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // frmTacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvwTacgia);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuatg);
            this.Controls.Add(this.btnXoatg);
            this.Controls.Add(this.btnThemtg);
            this.Controls.Add(this.txtTentg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatg);
            this.Controls.Add(this.label1);
            this.Name = "frmTacgia";
            this.Text = "frmTacgia";
            this.Load += new System.EventHandler(this.frmTacgia_Load_1);
            this.cmsHV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwTacgia;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSuatg;
        private System.Windows.Forms.Button btnXoatg;
        private System.Windows.Forms.Button btnThemtg;
        private System.Windows.Forms.TextBox txtTentg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsHV;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}