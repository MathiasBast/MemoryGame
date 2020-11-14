using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Card
    {
        private int number;
        private string suit;
        Image frontImage, backImage;
        private bool faceUp;

        public string Suit
        {
            get
            {
                return suit;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
        }

        public Image CurrentImage
        {
            get
            {
                if (faceUp == true) return frontImage;
                if (faceUp == false) return backImage;
                return backImage;
            }
        }

        public Card(int number, string suit)
        {
            string card = suit + number.ToString();
            this.number = number;
            this.suit = suit;
            frontImage = (Image)MemoryGame.Properties.Resources.ResourceManager.GetObject(card);
            backImage = MemoryGame.Properties.Resources.cardBack;
            faceUp = false;
        }
        public void Flip()
        {
            faceUp = !faceUp;
        }

    }
}
