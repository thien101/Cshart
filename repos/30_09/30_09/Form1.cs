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
    public partial class BackAll : Form
    {
        public BackAll()
        {
            InitializeComponent();
        }
        void Battat()
        {
            if (list_nguon.Items.Count == 0)
            {
                move.Enabled = false;
                move_all.Enabled = false;
            } else
            {
                move.Enabled = true;
                move_all.Enabled = true;
            }
            if (list_dich.Items.Count == 0)
            {
                back.Enabled = false;
                back_all.Enabled = false;
            }else
            {
                back.Enabled = true;
                back_all.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_click_Click(object sender, EventArgs e)
        {
            string t = "";
            /*
            if (checkca.Checked) t += checkca.Text + ",";
            if (checkcua.Checked) t += checkcua.Text + ",";
            if (checkmuc.Checked) t += checkmuc.Text + ",";
            if (t != "") lbtext.Text = "Ban da chon: " + t;
            else lbtext.Text = "Ban chua chon gi ca";*/

            for(int i = 0; i<listbox.SelectedItems.Count; i++) {
                t += listbox.SelectedItems[i].ToString();
            }
            if (t != "") lbtext.Text = "Ban da chon: " + t;
            else lbtext.Text = "Ban chua chon gi ca";
        }

        private void move_Click(object sender, EventArgs e)
        {
            /*for(int i=0; i<list_nguon.SelectedItems.Count; i++)
            {
                list_dich.Items.Add(list_nguon.SelectedItems[i]);
                list_nguon.Items.Remove(list_nguon.SelectedItems[i]);
            }*/

            list_dich.Items.Add(list_nguon.SelectedItem);
            list_nguon.Items.Remove(list_nguon.SelectedItem);

            /*back.Enabled = true;
            back_all.Enabled = true;*/
            if (list_nguon.Items.Count == 0)
            {
                /*move.Enabled = false;
                move_all.Enabled = false;*/
                Battat();
            }
            list_dich.Sorted = true;
        }

        private void move_all_Click(object sender, EventArgs e)
        {
            list_dich.Items.AddRange(list_nguon.Items);
            list_nguon.Items.Clear();
            /*back.Enabled = true;
            back_all.Enabled = true;*/
            Battat();
            list_dich.Sorted = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < list_dich.SelectedItems.Count; i++)
            {
                list_nguon.Items.Add(list_dich.SelectedItems[i]);
                list_dich.Items.Remove(list_dich.SelectedItems[i]);
            }*/

            list_nguon.Items.Add(list_dich.SelectedItem);
            list_dich.Items.Remove(list_dich.SelectedItem);

            if (list_dich.Items.Count == 0)
            {
                /*move.Enabled = true;
                move_all.Enabled = true;*/
                Battat();
            }
            list_nguon.Sorted = true;
        }

        private void back_all_Click(object sender, EventArgs e)
        {
            list_nguon.Items.AddRange(list_dich.Items);
            list_dich.Items.Clear();
            /*move.Enabled = true;
            move_all.Enabled = true;*/
            Battat();
            list_nguon.Sorted = true;
        }

        private void btnFr1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
