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
    public partial class Form2 : Form
    {
        Random r;
        int score;
        int maxTime = 20;
        public List<int> HiscoresList1 = new List<int>();

        SoundPlayer player = new SoundPlayer("car horn.wav");
        SoundPlayer player02 = new SoundPlayer("arcade.wav");

        public Form2()
        {
            InitializeComponent();

        }
        /*public Form2(List<int> HiscoresList)
        {
            HiscoresList1 = HiscoresList;
        }*/

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            button1.Hide();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < this.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 22, pictureBox1.Location.Y);
            }
            else
            {
                r = new Random();
                int randX = r.Next(this.Width - pictureBox1.Width);
                int randY = r.Next(this.Height - pictureBox1.Height);
                pictureBox1.Location = new Point(randX, randY);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            player02.Play();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true && timer2.Enabled == true)
            {
                score += 5;
                label2.Text = score.ToString();
                player.Play();
            }
        }
        public void PlayerName2(string x)
        {
            label6.Text = x;
            
        }

        public void AddHighscore(int x)
        {
            HiscoresList1.Add(x);
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
                HiscoresList1.Add(score);
                Form1 f2 = new Form1();
                //sent the old Scores!
                for (int i = 0; i < HiscoresList1.Count; i++)
                {
                    int y = HiscoresList1[i];
                    f2.AddHighscore(y);
                }
                f2.Show();
                f2.Highscore(score);
                f2.PlayerName(label6.Text);
                this.Close();
            }
        }
    }
}
