using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_Card
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            this.Hide();
            Form3 start = new Form3(s);
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlashCard start = new FlashCard();
            start.Show();
        }
    }
}
