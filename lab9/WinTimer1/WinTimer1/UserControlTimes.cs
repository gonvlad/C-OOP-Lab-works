﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTimer1
{
    public partial class UserControlTimes : UserControl
    {
        public UserControlTimes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        public bool TimeEnabled
        {
            get { return timer1.Enabled;  }
            set { timer1.Enabled = value;  }
        }
    }
}
