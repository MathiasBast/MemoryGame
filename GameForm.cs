using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameForm : Form
    {
        PictureBox[] boxes;
        WelcomeForm welcomeForm;
        Card card1 = null;
        Card card2 = null;
        int matched;
        int totalCards;
        double timePassed = 0;
        PictureBox picBox1 = null, picBox2 = null;
        public GameForm()
        {
            InitializeComponent();
            
            Deck deck = new Deck();
            boxes = new PictureBox[] {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16};
            StartTimer.Start();
            totalCards = boxes.Count();
            NameBox.Hide();
            AskName.Hide();
            DisplayVictory.Hide();
            SubmitButton.Hide();

            foreach(PictureBox pictureBox in boxes)
            {
                Card card = deck.Deal();
                pictureBox.Image = card.CurrentImage;
                pictureBox.Tag = card;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox send = (PictureBox)sender;
            Card card = (Card)send.Tag;
            card.Flip();
            send.Image = card.CurrentImage;
            if(card1 == null)
            {
                picBox1 = send;
                card1 = card;
            } else
            {
                foreach(PictureBox box in boxes)
                {
                    box.Enabled = false;
                }
                DelayTimer.Start();
                picBox2 = send;
                card2 = card;
            }
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            timePassed += 0.1;
            timePassed = Math.Round(timePassed, 2);

            TimeBox.Text = String.Format("Time:  {0}", timePassed);
            
            if(matched == totalCards)
            {
                GameEnd();
            }
        }

        private void GameEnd()
        {
            StartTimer.Stop();
            NameBox.Show();
            AskName.Show();
            DisplayVictory.Show();
            SubmitButton.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            int newIdx = -1;
            string newScores = "";
            string readText = File.ReadAllText("H:\\2020\\Sem2\\Object Orintated ITPR5.518\\WindowsForms\\MemoryGame\\Scores.txt");
            string[] scores = readText.Split('\n');
            double firstTime = 0;
            bool chosen = false;
            foreach(var people in scores)
            {
                if (people.Length > 3)
                {
                    index++;
                    if (index > 0)
                    {
                        people.Remove(0, 2);
                    } 
                }
                string[] current = people.Split(',');
                string name = current[0];
                double time = Convert.ToDouble(current[1]);
                if (chosen)
                {
                    if(time < firstTime)
                    {
                        newIdx = index;
                        firstTime = time;
                    }
                }
                if(timePassed < time)
                {
                    chosen = true;
                    newIdx = index;
                    firstTime = time;
                }
            }
            if(newIdx != -1)
            {
                newIdx--;
                scores[newIdx] = String.Format(NameBox.Text + "," + timePassed);
            }
            index = 0;
            foreach(var people in scores)
            {
                index++;
                if(index != 10)
                {
                    newScores += people + "\n";
                }
                else
                {
                    newScores += people;
                }
            }
            if (newIdx != -1)
            {
                using (StreamWriter writer = new StreamWriter("H:\\2020\\Sem2\\Object Orintated ITPR5.518\\WindowsForms\\MemoryGame\\Scores.txt"))
                {
                    writer.WriteLine(newScores);
                }
            }
        }

        void RestartButton_Click(object sender, EventArgs e)
        {
            matched = 0;
            timePassed = 0;
            NameBox.Text = "";
            StartTimer.Start();
            NameBox.Hide();
            AskName.Hide();
            DisplayVictory.Hide();
            SubmitButton.Hide();

            Deck deck = new Deck();
            PictureBox[] boxes = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16 };


            totalCards = boxes.Count();
            foreach (PictureBox pictureBox in boxes)
            {
                Card card = deck.Deal();
                pictureBox.Image = card.CurrentImage;
                pictureBox.Tag = card;
                pictureBox.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            timePassed = 0;
            this.Close();

        }

        private void HighScore_Click(object sender, EventArgs e)
        {
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            welcomeForm = this.Owner as WelcomeForm;
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            if(card1 != null && card2 != null)
            {
                if (card1.Number == card2.Number && card1.Suit != card2.Suit)
                {
                    picBox2.Hide();
                    picBox1.Hide();
                    matched = matched + 2;
                }
            }
            
            card1.Flip();
            card2.Flip();
            picBox2.Image = card2.CurrentImage;
            picBox1.Image = card1.CurrentImage;
            card1 = null;
            card2 = null;
            DelayTimer.Stop();
            foreach(PictureBox box in boxes)
            {
                box.Enabled = true;
            }
        }


    }

}
