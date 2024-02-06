using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox1.Text="Odabrali ste:\nDorucak";
            }

            else if(checkBox2.Checked)
            {
                textBox1.Text = "Odabrali ste:\nRučak";
            }

            else if (checkBox3.Checked)
            {
                textBox1.Text = "Odabrali ste:\nVecera";
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            { 
                textBox1.Visible = false;   

            }
            else
            {
                textBox1.Visible = true;    
            }
        }
    }
}
