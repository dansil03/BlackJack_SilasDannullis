using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_SilasDannullis
{
    class Deck
    {
        public List<Card> deck = new List<Card>();
        public List<Card> Shuffled = new List<Card>();
        string[] suits = { "Harten", "Schoppen", "Klaver", "Ruiten" };
        string[] ranks = { "Boer", "Koningin", "Koning" };

        public Deck()
        {
            foreach (string suit in suits)
            {
                Card card3 = new Card(suit, "Aas", 11);
                deck.Add(card3);
                for (int i = 2; i < 11; i++)
                {
                    Card card2 = new Card(suit, i.ToString(), i);
                    deck.Add(card2);
                }
                foreach (string rank in ranks)
                {
                    Card card1 = new Card(suit, rank, 10);
                    deck.Add(card1);
                }
            }
            Shuffle();
        }
        private void Shuffle()
        {
            for (int i = 0; i < 52; i++)
            {
                var random = new Random();
                int r = random.Next(deck.Count);
                Card RandomKaart = deck[r];
                Shuffled.Add(RandomKaart);
                deck.RemoveAt(r);
            }
        }
    }
}
