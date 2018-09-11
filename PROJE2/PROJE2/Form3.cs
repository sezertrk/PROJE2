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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 formkapa = new Form3();
            formkapa.Close();
            Form7 form = new Form7();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 formkapa = new Form3();
            formkapa.Close();
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }
    }
}
