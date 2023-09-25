using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoy.Text);
            int kq = x + y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "+" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoy.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "*" + y.ToString() + "=" + kq.ToString() + "\r\n";
        }

        private void tbLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("form2.txt", true);
            sw.Write(tbKetQua.Text);
            sw.Close();

        }

        private void tbThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbKetQua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
