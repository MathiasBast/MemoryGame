using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class WelcomeForm : Form
    {
        private GameForm gameForm;
        private HighScores highScores;
        public WelcomeForm()
        {
            InitializeComponent();
            gameForm = new GameForm();
            highScores = new HighScores();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            gameForm.ShowDialog(this);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighScoresButton_Click(object sender, EventArgs e)
        {
            highScores.ShowDialog(this);
        }
    }
}
