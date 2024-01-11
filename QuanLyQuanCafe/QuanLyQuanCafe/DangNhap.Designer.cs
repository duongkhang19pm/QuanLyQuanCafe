namespace QuanLyQuanCafe
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnThoat = new Button();
            btnDangNhap = new Button();
            panel3 = new Panel();
            txtMatKhau = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtTenDangNhap = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 188);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(421, 127);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 41);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(184, 127);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(107, 41);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtMatKhau);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 56);
            panel3.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(184, 14);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(341, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 10);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTenDangNhap);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 56);
            panel2.TabIndex = 0;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(184, 14);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(341, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // DangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(549, 212);
            Controls.Add(panel1);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += DangNhap_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private TextBox txtMatKhau;
        private Label label2;
        private Panel panel2;
        private TextBox txtTenDangNhap;
        private Label label1;
        private Button btnThoat;
        private Button btnDangNhap;
    }
}
