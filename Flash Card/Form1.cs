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
    public partial class FlashCard : Form
    {
        public FlashCard()
        {
            InitializeComponent();
        }

        private void FlashCard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 start = new Form2();
            start.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addtoExist_Click(object sender, EventArgs e)
        {
            this.Hide();
            test start = new test();
            start.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            playcard start = new playcard();
            start.Show();
        }
    }
}
