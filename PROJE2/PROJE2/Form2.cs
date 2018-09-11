using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PROJE2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 formkapa = new Form2();
            formkapa.Close();
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 formkapa = new Form2();
            formkapa.Close();
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }
    }
}
