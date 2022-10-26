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
    public partial class FromChinh : Form
    {
        public FromChinh()
        {
            InitializeComponent();
            Lock_Unlock(mySave.KT);
        }
        void Lock_Unlock (bool kt){
            mnulogin.Enabled = mnuclose.Enabled = kt;
            mnulogout.Enabled = mnuWork.Enabled = mnuFind.Enabled = !kt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mnulogin_Click(object sender, EventArgs e)
        {
            FormLogin flg = new FormLogin();
            flg.Show();
        }

        private void FromChinh_Activated(object sender, EventArgs e)
        {
            Lock_Unlock(mySave.KT);
        }

        private void mnulogout_Click(object sender, EventArgs e)
        {
            mySave.KT = !mySave.KT;
            Lock_Unlock(mySave.KT);
        }
    }
}
