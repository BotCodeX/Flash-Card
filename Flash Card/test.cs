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

    

    public partial class test : Form
    {
        string[] lines;
        string filePath;

        public test()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the selected file
                    string filePath = openFileDialog.FileName;
                    lines = File.ReadAllLines(filePath);

                    string temp = lines[0];
                    label1.Text = temp;

                    /*foreach (string line in lines)
                    {
                        label1.Text += line + Environment.NewLine;
                    }*/
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the selected file
                    filePath = openFileDialog.FileName;
                }

            }
            label2.Text = filePath;
        }

        private void button4_Click(object sender, EventArgs e)
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

            if (filePath == null)
            {
                MessageBox.Show(
                    "Choose a File first",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            string ques = textBox1.Text;
            string ans = textBox2.Text;

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(ques);
                sw.WriteLine(ans);
                sw.Close();
            }

            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
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

            if (filePath==null)
            {
                MessageBox.Show(
                    "Choose a File first",
                    "File Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            string ques = textBox1.Text;
            string ans = textBox2.Text;

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(ques);
                sw.WriteLine(ans);
            }

            this.Hide();
            FlashCard start = new FlashCard();
            start.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlashCard start = new FlashCard();
            start.Show();
        }
    }
}
