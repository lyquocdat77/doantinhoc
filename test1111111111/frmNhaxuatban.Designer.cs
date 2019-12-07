namespace test1111111111
{
    partial class frmNhaxuatban
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
            this.label4 = new System.Windows.Forms.Label();
            this.lvwNhaxuatban = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSuanxb = new System.Windows.Forms.Button();
            this.btnXoanxb = new System.Windows.Forms.Button();
            this.btnThemnxb = new System.Windows.Forms.Button();
            this.txtTennxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtManxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Danh nhà xuất bản";
            // 
            // lvwNhaxuatban
            // 
            this.lvwNhaxuatban.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvwNhaxuatban.FullRowSelect = true;
            this.lvwNhaxuatban.GridLines = true;
            this.lvwNhaxuatban.HideSelection = false;
            this.lvwNhaxuatban.Location = new System.Drawing.Point(13, 190);
            this.lvwNhaxuatban.Margin = new System.Windows.Forms.Padding(4);
            this.lvwNhaxuatban.MultiSelect = false;
            this.lvwNhaxuatban.Name = "lvwNhaxuatban";
            this.lvwNhaxuatban.Size = new System.Drawing.Size(488, 251);
            this.lvwNhaxuatban.TabIndex = 71;
            this.lvwNhaxuatban.UseCompatibleStateImageBehavior = false;
            this.lvwNhaxuatban.View = System.Windows.Forms.View.Details;
            this.lvwNhaxuatban.SelectedIndexChanged += new System.EventHandler(this.lvwNhaxuatban_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã nhà xuất bản";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên nhà xuất bản";
            this.columnHeader6.Width = 127;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(386, 122);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 28);
            this.btnThoat.TabIndex = 70;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSuanxb
            // 
            this.btnSuanxb.Location = new System.Drawing.Point(386, 86);
            this.btnSuanxb.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuanxb.Name = "btnSuanxb";
            this.btnSuanxb.Size = new System.Drawing.Size(117, 28);
            this.btnSuanxb.TabIndex = 69;
            this.btnSuanxb.Text = "Sửa nhà xuất bản";
            this.btnSuanxb.UseVisualStyleBackColor = true;
            this.btnSuanxb.Click += new System.EventHandler(this.btnSuanxb_Click);
            // 
            // btnXoanxb
            // 
            this.btnXoanxb.Location = new System.Drawing.Point(386, 51);
            this.btnXoanxb.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoanxb.Name = "btnXoanxb";
            this.btnXoanxb.Size = new System.Drawing.Size(117, 28);
            this.btnXoanxb.TabIndex = 68;
            this.btnXoanxb.Text = "Xóa nhà xuất bản";
            this.btnXoanxb.UseVisualStyleBackColor = true;
            this.btnXoanxb.Click += new System.EventHandler(this.btnXoanxb_Click);
            // 
            // btnThemnxb
            // 
            this.btnThemnxb.Location = new System.Drawing.Point(386, 15);
            this.btnThemnxb.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemnxb.Name = "btnThemnxb";
            this.btnThemnxb.Size = new System.Drawing.Size(117, 28);
            this.btnThemnxb.TabIndex = 67;
            this.btnThemnxb.Text = "Thêm nhà xuất bản";
            this.btnThemnxb.UseVisualStyleBackColor = true;
            this.btnThemnxb.Click += new System.EventHandler(this.btnThemnxb_Click);
            // 
            // txtTennxb
            // 
            this.txtTennxb.Location = new System.Drawing.Point(149, 48);
            this.txtTennxb.Margin = new System.Windows.Forms.Padding(4);
            this.txtTennxb.Name = "txtTennxb";
            this.txtTennxb.Size = new System.Drawing.Size(216, 22);
            this.txtTennxb.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên nhà xuất bản";
            // 
            // txtManxb
            // 
            this.txtManxb.Location = new System.Drawing.Point(149, 16);
            this.txtManxb.Margin = new System.Windows.Forms.Padding(4);
            this.txtManxb.MaxLength = 10;
            this.txtManxb.Name = "txtManxb";
            this.txtManxb.Size = new System.Drawing.Size(164, 22);
            this.txtManxb.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "Mã nhà xuất bản";
            // 
            // frmNhaxuatban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvwNhaxuatban);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuanxb);
            this.Controls.Add(this.btnXoanxb);
            this.Controls.Add(this.btnThemnxb);
            this.Controls.Add(this.txtTennxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtManxb);
            this.Controls.Add(this.label1);
            this.Name = "frmNhaxuatban";
            this.Text = "frmNhaxuatban";
            this.Load += new System.EventHandler(this.frmNhaxuatban_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwNhaxuatban;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSuanxb;
        private System.Windows.Forms.Button btnXoanxb;
        private System.Windows.Forms.Button btnThemnxb;
        private System.Windows.Forms.TextBox txtTennxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManxb;
        private System.Windows.Forms.Label label1;
    }
}