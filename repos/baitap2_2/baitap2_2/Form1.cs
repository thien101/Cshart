using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radvang.Checked = true;
            radga.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtht.Text + "\n" + txtage.Text, "Thông báo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtage_Leave(object sender, EventArgs e)
        {
            if (txtage != null && txtht != null)
                btnok.Enabled = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            double a = double.Parse(number1.Text);
            double b = double.Parse(number2.Text);
            ketqua.Text = (a / b).ToString();
            //MessageBox.Show("Thương: " + (a / b));
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(number1.Text);
            double b = double.Parse(number2.Text);
            ketqua.Text = (a + b).ToString();
            //MessageBox.Show("Tổng: " + (a + b));
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(number1.Text);
            double b = double.Parse(number2.Text);
            ketqua.Text = (a - b).ToString();
            //MessageBox.Show("Hiệu: " + (a - b));
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(number1.Text);
            double b = double.Parse(number2.Text);
            ketqua.Text = (a*b).ToString();
            //MessageBox.Show("Tích: " + (a * b));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double cd = double.Parse(txtdai.Text);
            double cr= double.Parse(txtrong.Text);
            HCN cn = new HCN(cd, cr);
            double dt = cn.dientich();
            MessageBox.Show(dt.ToString(), "ket qua");
        }

        private void btnchuvi_Click(object sender, EventArgs e)
        {
            double cd = double.Parse(txtdai.Text);
            double cr = double.Parse(txtrong.Text);
            HCN cn = new HCN(cd, cr);
            double cv = cn.chuvi();
            MessageBox.Show(cv.ToString(), "ket qua");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            /*gerenic<int, string> a = new gerenic<int, string>(10, "Thien");
            MessageBox.Show(a.getx().ToString() + ","
                + a.gety().ToString(), "Thong bao");*/

            if (radvang.Checked == true) picbox.BackColor = Color.Yellow;
            if (raddo.Checked == true) picbox.BackColor = Color.Red;
            if (radden.Checked == true) picbox.BackColor = Color.Black;

        }

        private void radga_CheckedChanged(object sender, EventArgs e)
        {
            if (radga.Checked)
            {
                picture_food.BackColor = Color.YellowGreen;
                giaca.Text = "10.000 đồng";
                
            }
        }

        private void radca_CheckedChanged(object sender, EventArgs e)
        {
            if (radca.Checked)
            {
                picture_food.BackColor = Color.Blue;
                giaca.Text = "20.000 đồng";
            }
        }

        private void radmuc_CheckedChanged(object sender, EventArgs e)
        {
            if (radmuc.Checked)
            {
                picture_food.BackColor = Color.Purple;
                giaca.Text = "30.000 đồng";
            }
        }
    }
}
