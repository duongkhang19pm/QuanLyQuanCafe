namespace QuanLyQuanCafe
{
    partial class TrangChu
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem1 = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvHoadon = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel3 = new Panel();
            cbChuyenBan = new ComboBox();
            btnChuyenBan = new Button();
            nmGiamGia = new NumericUpDown();
            btnGiamGia = new Button();
            btnThanhToan = new Button();
            panel4 = new Panel();
            nmSlMon = new NumericUpDown();
            btnThemMon = new Button();
            cbMonAn = new ComboBox();
            cbDanhMuc = new ComboBox();
            flpBan = new FlowLayoutPanel();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmGiamGia).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmSlMon).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinCáNhânToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1158, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem1, đăngXuấtToolStripMenuItem });
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(151, 24);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem1
            // 
            thôngTinCáNhânToolStripMenuItem1.Name = "thôngTinCáNhânToolStripMenuItem1";
            thôngTinCáNhânToolStripMenuItem1.Size = new Size(210, 26);
            thôngTinCáNhânToolStripMenuItem1.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem1.Click += thôngTinCáNhânToolStripMenuItem1_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(210, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvHoadon);
            panel2.Location = new Point(803, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 408);
            panel2.TabIndex = 2;
            // 
            // lsvHoadon
            // 
            lsvHoadon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvHoadon.GridLines = true;
            lsvHoadon.Location = new Point(3, 3);
            lsvHoadon.Name = "lsvHoadon";
            lsvHoadon.Size = new Size(337, 395);
            lsvHoadon.TabIndex = 0;
            lsvHoadon.UseCompatibleStateImageBehavior = false;
            lsvHoadon.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Món";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số Lượng";
            // 
            // panel3
            // 
            panel3.Controls.Add(cbChuyenBan);
            panel3.Controls.Add(btnChuyenBan);
            panel3.Controls.Add(nmGiamGia);
            panel3.Controls.Add(btnGiamGia);
            panel3.Controls.Add(btnThanhToan);
            panel3.Location = new Point(806, 531);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 86);
            panel3.TabIndex = 3;
            // 
            // cbChuyenBan
            // 
            cbChuyenBan.FormattingEnabled = true;
            cbChuyenBan.Location = new Point(3, 42);
            cbChuyenBan.Name = "cbChuyenBan";
            cbChuyenBan.Size = new Size(94, 28);
            cbChuyenBan.TabIndex = 7;
            // 
            // btnChuyenBan
            // 
            btnChuyenBan.Location = new Point(3, 3);
            btnChuyenBan.Name = "btnChuyenBan";
            btnChuyenBan.Size = new Size(94, 33);
            btnChuyenBan.TabIndex = 6;
            btnChuyenBan.Text = "Chuyển Bán";
            btnChuyenBan.UseVisualStyleBackColor = true;
            // 
            // nmGiamGia
            // 
            nmGiamGia.Location = new Point(129, 42);
            nmGiamGia.Name = "nmGiamGia";
            nmGiamGia.Size = new Size(94, 27);
            nmGiamGia.TabIndex = 5;
            nmGiamGia.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGiamGia
            // 
            btnGiamGia.Location = new Point(129, 3);
            btnGiamGia.Name = "btnGiamGia";
            btnGiamGia.Size = new Size(94, 33);
            btnGiamGia.TabIndex = 4;
            btnGiamGia.Text = "Giảm Giá";
            btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(249, 8);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(94, 62);
            btnThanhToan.TabIndex = 3;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(nmSlMon);
            panel4.Controls.Add(btnThemMon);
            panel4.Controls.Add(cbMonAn);
            panel4.Controls.Add(cbDanhMuc);
            panel4.Location = new Point(806, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(337, 69);
            panel4.TabIndex = 4;
            // 
            // nmSlMon
            // 
            nmSlMon.Location = new Point(293, 5);
            nmSlMon.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmSlMon.Name = "nmSlMon";
            nmSlMon.Size = new Size(44, 27);
            nmSlMon.TabIndex = 3;
            nmSlMon.TextAlign = HorizontalAlignment.Center;
            nmSlMon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThemMon
            // 
            btnThemMon.Location = new Point(193, 3);
            btnThemMon.Name = "btnThemMon";
            btnThemMon.Size = new Size(94, 62);
            btnThemMon.TabIndex = 2;
            btnThemMon.Text = "Thêm Món";
            btnThemMon.UseVisualStyleBackColor = true;
            // 
            // cbMonAn
            // 
            cbMonAn.FormattingEnabled = true;
            cbMonAn.Location = new Point(3, 37);
            cbMonAn.Name = "cbMonAn";
            cbMonAn.Size = new Size(184, 28);
            cbMonAn.TabIndex = 1;
            // 
            // cbDanhMuc
            // 
            cbDanhMuc.FormattingEnabled = true;
            cbDanhMuc.Location = new Point(3, 3);
            cbDanhMuc.Name = "cbDanhMuc";
            cbDanhMuc.Size = new Size(184, 28);
            cbDanhMuc.TabIndex = 0;
            // 
            // flpBan
            // 
            flpBan.AutoScroll = true;
            flpBan.Location = new Point(0, 42);
            flpBan.Name = "flpBan";
            flpBan.Size = new Size(797, 575);
            flpBan.TabIndex = 5;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn Giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành Tiền";
            columnHeader4.Width = 100;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 629);
            Controls.Add(flpBan);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần Mềm Quản Lý Quán CaFe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmGiamGia).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmSlMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem1;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ListView lsvHoadon;
        private Panel panel4;
        private Button btnThemMon;
        private ComboBox cbMonAn;
        private ComboBox cbDanhMuc;
        private NumericUpDown nmSlMon;
        private Button btnThanhToan;
        private FlowLayoutPanel flpBan;
        private NumericUpDown nmGiamGia;
        private Button btnGiamGia;
        private ComboBox cbChuyenBan;
        private Button btnChuyenBan;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}