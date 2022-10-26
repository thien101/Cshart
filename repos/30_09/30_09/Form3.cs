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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.txttext.Font = new System.Drawing.Font(cbb_font.Text, int.Parse(cbb_size.Text), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        
        private void btb_click_Click(object sender, EventArgs e)
        {
            this.txttext.Font = new System.Drawing.Font(cbb_font.Text, int.Parse(cbb_size.Text), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*int t = int.Parse(lbltime.Text);
            t++;
            lbltime.Text = t.ToString();*/

            int s, m, h;
            h = int.Parse(txt_gio.Text);
            m = int.Parse(txt_phut.Text);
            s = int.Parse(txt_giay.Text);
            s++;
            if (s > 60)
            {
                s = 0;
                m++;
                if(m > 60)
                {
                    m = 0;
                    h++;
                    if(h > 24)
                    {
                        h = 0;
                    }
                }
            }
            txt_giay.Text = s.ToString();
            txt_phut.Text = m.ToString();
            txt_gio.Text = h.ToString();

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnstop.Enabled = true;
            btnstart.Enabled = false;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnstop.Enabled = false;
            btnstart.Enabled = true;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            pt_color.BackColor = Color.Red;
            time_do.Enabled = true;
            txt_den.Text = "60";
            btn_run.Enabled = false;
        }

        private void time_do_Tick(object sender, EventArgs e)
        {
            int d = int.Parse(txt_den.Text);
            if (d <= 0)
            {
                time_do.Enabled = false;
                pt_color.BackColor = Color.Green;
                txt_den.Text = "30";
                time_xanh.Enabled = true;
            }
            else {
                d--;
                txt_den.Text = d.ToString();
            }
            
        }

        private void time_xanh_Tick(object sender, EventArgs e)
        {
            int x = int.Parse(txt_den.Text);
            if (x <= 0)
            {
                time_xanh.Enabled = false;
                pt_color.BackColor = Color.Yellow;
                txt_den.Text = "5";
                time_vang.Enabled = true;
            }
            else
            {
                x--;
                txt_den.Text = x.ToString();
            }

        }

        private void time_vang_Tick(object sender, EventArgs e)
        {
            int v = int.Parse(txt_den.Text);
            if (v <= 0)
            {
                time_vang.Enabled = false;
                pt_color.BackColor = Color.Red;
                txt_den.Text = "60";
                time_do.Enabled = true;
            }
            else
            {
                v--;
                txt_den.Text = v.ToString();
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            
            pt_color.BackColor = Color.Yellow;
            time_do.Enabled = false;
            time_xanh.Enabled = false;
            time_vang.Enabled = true;
            txt_den.Text = "";
            btn_stop.Enabled = false;
        }

        private void btnFr2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        /*private void scroll_action_ValueChanged(object sender, EventArgs e)
        {
            //txtkq.Text = scroll_action.Value.ToString();
            //this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", scroll_action.Value, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }*/
    }
}
