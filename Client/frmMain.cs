﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitializeComponent();
            Views.userProfile login = new Views.userProfile();
            this.Controls.Add(login);
            login.Dock = DockStyle.Fill;
        }
    }
}
