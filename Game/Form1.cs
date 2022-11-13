using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishing_Game
{
    public partial class Form1 : Form
    {
        int hiscore = 0;
        string PlName; 
        public List<int> HiscoresList = new List<int>();
        SoundPlayer player01 = new SoundPlayer("Car engine.wav");
        


        public Form1()
        {   
            InitializeComponent();
            timer1.Enabled = true;
            
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = hiscore.ToString();
            richTextBox1.Hide();
            richTextBox2.Hide();
            DateTime currentDateTime = DateTime.Now;
            int d = currentDateTime.Hour;
            int h = currentDateTime.Minute;
            int m = currentDateTime.Day;
            int s = currentDateTime.Month;
            int t = currentDateTime.Year;
            richTextBox3.Text = d.ToString()+":" + h.ToString() + " " + m.ToString() +"/"+ s.ToString() + "/" + t.ToString();
           
            player01.Play();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Try to caught the car with your mouse and then press the right click!");
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if (label3.Text == "" )
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else
            {   
                Form2 f2 = new Form2();
                f2.PlayerName2(label3.Text);
                for (int i = 0; i < HiscoresList.Count; i++)
                {
                    int y = HiscoresList[i];
                    f2.AddHighscore(y);
                                   
                }
                this.Hide();                
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else
            {

                Form3 f2 = new Form3();
                f2.PlayerName3(label3.Text);
                for (int i = 0; i < HiscoresList.Count; i++)
                {
                    int y = HiscoresList[i];
                    f2.AddHighscore2(y);

                }
                this.Hide();
                f2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "")
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
            else
            {
                Form4 f2 = new Form4();
                f2.PlayerName4(label3.Text);
                for (int i = 0; i < HiscoresList.Count; i++)
                {
                    int y = HiscoresList[i];
                    f2.AddHighscore3(y);

                }
                this.Hide();
                f2.Show();

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < this.Width)
            {
                Point k = new Point(pictureBox1.Location.X, pictureBox1.Location.Y);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y);

            }
            else
            {
                pictureBox1.Location = new Point(0, pictureBox1.Location.Y);

            }
            
            if (label1.ForeColor == Color.Red)
            {
                label1.ForeColor = Color.Yellow;
                
            }
            else
            {
                label1.ForeColor = Color.Red;
            }

            if (label2.ForeColor == Color.Red)
            {
                label2.ForeColor = Color.Yellow;

            }
            else
            {
                label2.ForeColor = Color.Red;
            }
            if (label3.ForeColor == Color.Red)
            {
                label3.ForeColor = Color.Yellow;

            }
            else
            {
                label3.ForeColor = Color.Red;
            }
            if (label4.ForeColor == Color.Red)
            {
                label4.ForeColor = Color.Yellow;

            }
            else
            {
                label4.ForeColor = Color.Red;
            }
            if (label5.ForeColor == Color.Blue)
            {
                label5.ForeColor = Color.Yellow;

            }
            else
            {
                label5.ForeColor = Color.Blue;
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        


        public void Highscore(int x)
        {
            HiscoresList.Add(x);
            hiscore = HiscoresList.Max();
            label2.Text = hiscore.ToString();
              
        }

        public void AddHighscore(int x)
        {
            HiscoresList.Add(x);
        }
        public void PlayerName(string x)
        {   
            label3.Text = x;
            PlName = x;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            richTextBox1.Text =label4.Text + "=" + label3.Text + "=" + label1.Text + "=" + label2.Text +"  =>  " + richTextBox3.Text ;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\textfiles";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                var a = richTextBox2.Text;
                var words = a.Split('=');
                label2.Text = words[3];
                label3.Text = words[1];

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Easy level every time you hit the car you take 5 points\n" +
                "In Medium level every time you hit the car you take 15 points\n" +
                "In Hard level every time you hit the car you take 25 points\n" +
                " if you hit a BOMB you lose 100points!\n");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void L(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
