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
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            this.Hide();
            playcard start = new playcard(s);
            start.Show();
        }
    }
}
