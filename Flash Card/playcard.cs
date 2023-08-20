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
    public partial class playcard : Form
    {
       
        string[] lines;
        int len;
        int i = 1;
        string filePath;

        public playcard()
        {
            InitializeComponent();

        }
        public playcard(string s)
        {

            InitializeComponent();
            panel1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            if (i<len)
            {
                if (i % 2 == 0)
                {
                    label2.Text = "QUESTION";
                }
                else
                {
                    label2.Text = "ANSWER";
                }
                label3.Text = lines[i];
            }
            else
            {
                MessageBox.Show(
                    "NO CARDS LEFT",
                    "All cards played",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                label2.Text = "thank you";
                label3.Text = "";

                panel1.Show();
                panel1.BackgroundImage = image.Images[0];
            }
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read the selected file
                    filePath = openFileDialog.FileName;
                    lines = File.ReadAllLines(filePath);
                    Console.WriteLine(filePath);

                    string temp = lines[0];
                    label2.Text = "question";
                    label3.Text = temp;
                    len = lines.Length;
                    i = 1;
                    label4.Text = filePath;

                    /*foreach (string line in lines)
                    {
                        label1.Text += line + Environment.NewLine;
                    }*/
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlashCard start = new FlashCard();
            start.Show();
        }
    }
}
