using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_09
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listTT.Enabled = false;
            //listTT.Visible = false;
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            string s = "";

            /*for(int i = 0; i < chcklbox1.CheckedItems.Count; i++)
            {
                s += chcklbox1.CheckedItems[i].ToString();
            }
            if (s != "") lblkq.Text = "Ban da chon: " + s;
            else lblkq.Text = "Ban chua chon gi ca";*/

            int tt = 0;
            for(int i=0; i<chcklbox1.Items.Count; i++)
            {
                for (int j = 0; j < chcklbox1.CheckedItems.Count; j++)
                {
                    if (chcklbox1.CheckedItems[j] == chcklbox1.Items[i])
                        // list thanh tien
                        tt += int.Parse(listTT.Items[i].ToString());
                }
            }
            
            if (tt != 0) lblkq.Text ="Tong Tien: "+ tt.ToString();
            else lblkq.Text = "Tong Tien: 0";
        }
    }
}
