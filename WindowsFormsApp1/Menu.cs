﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 mainmenu = new Form1();
            mainmenu.ShowDialog(this);
        }
          
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 mainmenu = new Form2();
            mainmenu.ShowDialog(this);
        }
    }
}
