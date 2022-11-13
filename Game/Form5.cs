using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing_Game
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text != "Write Your Name")
            {
                Form1 frm = new Form1();
                frm.PlayerName(richTextBox1.Text);
                this.Close();
                frm.Show();
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Text = null;
        }
    }
}
