﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROJE2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formkapa = new Form1();
            formkapa.Close();
            Form2 form = new Form2();
            form.Show();
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formkapa = new Form1();
            formkapa.Close();
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 formkapa = new Form1();
            formkapa.Close();
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }
    }
}
