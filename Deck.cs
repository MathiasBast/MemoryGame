using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();
        private string[] cardSuit = { };

        public Deck()
        {
            cards = new List<Card>();
        }

        public void shuffle()
        {
            string[] suits = { "club", "heart"};
            foreach (string suit in suits)
            {
                for (int i = 0; i < 8; i++)
                {
                    cards.Add(new Card(i + 1, suit));
                }
            }
        }

        public Card Deal()
        {
            if (cards.Count < cards.Count - 16)
            {
                cards.Clear();
                this.shuffle();
            }
            if (cardSuit.Length == 2)
            {
                cardSuit = null;
            }

            Card card = null;
            if (cards.Count == 0)
            {
                this.shuffle();
            }
            card = cards[random.Next(cards.Count)];
            cards.Remove(card);
            return card;

        }

    }
}
