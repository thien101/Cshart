using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "abc" && txtPass.Text == "123")
            {
                mySave.KT = !mySave.KT;
                MessageBox.Show("Login Success", "Thong bao");
                Close();
            }
            else
            {
                MessageBox.Show("Name or Pass is not correct", "Thong bao");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
