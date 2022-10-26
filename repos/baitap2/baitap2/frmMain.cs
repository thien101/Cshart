using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void txta_Leave(object sender, EventArgs e)
        {
        }

        private void txta_Enter(object sender, EventArgs e)
        {
        }

        private void txtb_Enter(object sender, EventArgs e)
        {
        }

        private void txtb_Leave(object sender, EventArgs e)
        {
        }

        private void txt3_Enter(object sender, EventArgs e)
        {
        }

        private void txt3_Leave(object sender, EventArgs e)
        {
        }
        private void frmMain_Enter(object sender, EventArgs e)
        {
            TextBox x = (TextBox)sender;
            x.BackColor = Color.Gray;
        }
        private void frmMain_Leave(object sender, EventArgs e)
        {
            TextBox x = (TextBox)sender;
            x.BackColor = Color.White;
        }
    }
}
