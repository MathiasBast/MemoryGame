using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class HighScores : Form
    {
        WelcomeForm welcomeForm;
        public HighScores()
        {
            InitializeComponent();


           
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            welcomeForm = this.Owner as WelcomeForm;
            string readText = File.ReadAllText("H:\\2020\\Sem2\\Object Orintated ITPR5.518\\WindowsForms\\MemoryGame\\Scores.txt");
            string[] scores = readText.Split('\n');

            highScoreText1.Text = readText;
            TextBox[] boxes = new TextBox[] { highScoreText1, highScoreText2, highScoreText3, highScoreText4, highScoreText5, highScoreText6, highScoreText7, highScoreText8, highScoreText9, highScoreText10 };

            int index = 0;
            foreach (TextBox textBox in boxes)
            {
                textBox.Text = scores[index];
                index++;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
