using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_UIL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Views.orders login = new Views.orders();
            this.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
