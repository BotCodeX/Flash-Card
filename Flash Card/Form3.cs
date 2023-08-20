using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Flash_Card
{
    public partial class Form3 : Form
    {
        string name , last=".txt";
        string filename;


        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string s)
        {
            InitializeComponent();
            name = s;
            label5.Text = s;
            filename = name + last;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(
                    "You have left one or both field empty",
                    "Insufficient Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            string ques = textBox1.Text;
            string ans = textBox2.Text;

            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(ques);
                sw.WriteLine(ans);
                sw.Close();
            }

            textBox1.ResetText();
            textBox2.ResetText();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(
                    "You have left one or both field empty",
                    "Insufficient Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            string ques = textBox1.Text;
            string ans = textBox2.Text;

            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.WriteLine(ques);
                sw.WriteLine(ans);
            }

            textBox1.ResetText();
            textBox2.ResetText();
            

            this.Hide();
            FlashCard start = new FlashCard();
            start.Show();
        }
    }
}
