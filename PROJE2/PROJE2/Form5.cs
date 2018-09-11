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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "6":
                    {
                        textBox2.Text = "2"; break;
                    }
                case "12":
                    {
                        textBox2.Text = "6"; break;
                    }
                case "24":
                    {
                        textBox2.Text = "8"; break;
                    }
                    
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            int miktar = int.Parse(textBox1.Text);
            int vade = int.Parse(comboBox1.Text);
            int vadeor = int.Parse(textBox2.Text);
            int sonuc = 0;
            int taksit = 0;
            sonuc = ((miktar / 100) * vadeor) + miktar;
            taksit = sonuc / vade;
            textBox3.Text = (sonuc.ToString());
            textBox4.Text = (taksit.ToString());
            listBox1.Items.Add(textBox5.Text) && listBox1.Items.Add(textBox6.Text);
            
        }
    }
}
