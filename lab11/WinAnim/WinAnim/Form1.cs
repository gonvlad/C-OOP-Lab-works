﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAnim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_ACTIVATE | WinAPIClass.AnimateWindowFlags.AW_BLEND);

            this.btn_AW_BLEND.Invalidate();
            this.btn_HOR_AW_SLIDE.Invalidate();
            this.btn_Center_AW_SLIDE.Invalidate();
        }

        private void btn_HOR_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();

            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_HOR_POSITIVE | WinAPIClass.AnimateWindowFlags.AW_SLIDE);

            this.btn_AW_BLEND.Invalidate();
            this.btn_HOR_AW_SLIDE.Invalidate();
            this.btn_Center_AW_SLIDE.Invalidate();
        }

        private void btnCenter_AW_SLIDE_Click(object sender, EventArgs e)
        {
            this.Hide();

            WinAPIClass.AnimateWindow(this, 3000, WinAPIClass.AnimateWindowFlags.AW_CENTER | WinAPIClass.AnimateWindowFlags.AW_SLIDE);

            this.btn_AW_BLEND.Invalidate();
            this.btn_HOR_AW_SLIDE.Invalidate();
            this.btn_Center_AW_SLIDE.Invalidate();
        }
    }
}
