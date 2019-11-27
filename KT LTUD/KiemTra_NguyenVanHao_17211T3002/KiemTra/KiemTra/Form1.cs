using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KiemTra
{
    public partial class frmThi : Form
    {
        public frmThi()
        {
            InitializeComponent();
        }

        private void nhậpĐiểmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBangDiem bangdiem = new frmBangDiem();
            bangdiem.Show();
            Visible = false;
        }
    }
}
