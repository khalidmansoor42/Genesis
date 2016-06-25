using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Stock_UIL
{
    public partial class mainForm : DevExpress.XtraEditors.XtraForm
    {
        public mainForm()
        {
            InitializeComponent();
            Views.addProduct login = new Views.addProduct();
            this.Controls.Add(login);
            login.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
    }
}