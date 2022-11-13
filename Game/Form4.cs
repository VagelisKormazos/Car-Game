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
    public partial class Form4 : Form
    {

        Random r;
        Random x;
        Random y;
        Random z;

        int score;
        int maxTime = 20;
        public List<int> HiscoresList3 = new List<int>();

        SoundPlayer player = new SoundPlayer("car horn.wav");
        SoundPlayer player2 = new SoundPlayer("bomb.wav");
        SoundPlayer player02 = new SoundPlayer("arcade.wav");
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            player02.Play();
            /*int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);*/
        }
        public void AddHighscore3(int x)
        {
            HiscoresList3.Add(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            button1.Hide();

        }
        public void PlayerName4(string x)
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
                for (int i = 0; i < HiscoresList3.Count; i++)
                {
                    int y = HiscoresList3[i];
                    f2.AddHighscore(y);
                }

                f2.Highscore(score);
                f2.PlayerName(label6.Text);
                f2.Show();
                this.Close();
            }
            if (pictureBox2.Location.X < this.Width && pictureBox2.Location.Y < this.Height)
            {
                x = new Random();
                int randxX = x.Next(this.Width - pictureBox1.Width);
                int randxY = x.Next(this.Height - pictureBox1.Height);
                pictureBox2.Location = new Point(randxX, randxY);
            }
            else
            {
                
            }
        }





        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureBox1.Location.X < this.Width && pictureBox1.Location.Y < this.Height)
            {

                if (pictureBox1.Location.X % 2 == 0)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 30, pictureBox1.Location.Y + 20);
                    BackColor = Color.Red;
                }
                else
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 30, pictureBox1.Location.Y - 20);
                    BackColor = Color.Black;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true && timer2.Enabled == true) 
            { 
                score += 25;
                label2.Text = score.ToString();
                player.Play();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            score -= 100;
            label2.Text = score.ToString();
            player2.Play();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            score -= 100;
            label2.Text = score.ToString();
            player2.Play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            score -= 100;
            label2.Text = score.ToString();
            player2.Play();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
                
                if (pictureBox3.Location.X < this.Width && pictureBox3.Location.Y < this.Height)
                {

                    y = new Random();
                    int randyX = y.Next(this.Width - pictureBox1.Width);
                    int randyY = y.Next(this.Height - pictureBox1.Height);
                    pictureBox3.Location = new Point(randyX, randyY);
                }
                else
                {
                Point k = new Point(pictureBox3.Location.X, pictureBox3.Location.Y);
                pictureBox3.Location = new Point(pictureBox1.Location.X + 20, pictureBox1.Location.Y+20);
                    
                }
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Location.X < this.Width && pictureBox4.Location.Y < this.Height)
            {

                z = new Random();
                int randzX = z.Next(this.Width - pictureBox1.Width);
                int randzY = z.Next(this.Height - pictureBox1.Height);
                pictureBox4.Location = new Point(randzX, randzY);
            }
            else
            {
                Point k = new Point(pictureBox4.Location.X, pictureBox1.Location.Y);
                pictureBox4.Location = new Point(pictureBox4.Location.X , pictureBox4.Location.Y+20);

            }

        }

        private void Form4_Leave(object sender, EventArgs e)
        {

        }
    }
}
