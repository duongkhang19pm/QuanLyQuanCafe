﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void btndatlaimk_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan thongtincanhan = new ThongTinCaNhan();
            thongtincanhan.ShowDialog();
        }
    }
}