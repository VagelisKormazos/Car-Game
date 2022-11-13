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
    public partial class Form3 : Form
    {

        Random r;
        int score;
        int maxTime = 20;
        public List<int> HiscoresList2 = new List<int>();

        SoundPlayer player = new SoundPlayer("car horn.wav");
        SoundPlayer player02 = new SoundPlayer("arcade.wav");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            player02.Play();
            
        }
        public void AddHighscore2(int x)
        {
            HiscoresList2.Add(x);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true && timer2.Enabled == true)
            {
                score += 15;
                label2.Text = score.ToString();
                player.Play();
                if (BackColor == Color.LightGreen)
                {
                    BackColor = Color.DeepSkyBlue;
                }
                else
                {
                    BackColor = Color.LightGreen;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < this.Width && pictureBox1.Location.Y < this.Height)
            {
                
                if(pictureBox1.Location.X%2 == 0)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 45, pictureBox1.Location.Y +21);
                }
                else
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 45, pictureBox1.Location.Y - 21);
                    
                }
            }
            else
            {
                r = new Random();
                int randX = r.Next(this.Width - pictureBox1.Width);
                int randY = r.Next(this.Height - pictureBox1.Height);
                pictureBox1.Location = new Point(randX, randY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void PlayerName3(string x)
        {
            label6.Text = x;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            maxTime -= 1;
            label3.Text = maxTime.ToString();
            if (maxTime == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                pictureBox1.Enabled = false;
                MessageBox.Show(label6.Text + " your score is " + score);

                Form1 f2 = new Form1();
                //sent the old Scores!
                for (int i = 0; i < HiscoresList2.Count; i++)
                {
                    int y = HiscoresList2[i];
                    f2.AddHighscore(y);
                }

                //f2.HiscoresList.Add(score);
                f2.Highscore(score);
                f2.PlayerName(label6.Text);
                f2.Show();
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
