using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_SilasDannullis
{
    class Table : Card
    {
        public List<Player> players = new List<Player>();
        Deck deck1 = new Deck();
        public string Naam;
        public int Waarde;
        public Player player = new Player();
        public Player dealer = new Player();
        public bool Winn;
        public bool Push;

        public Table()
        {
            players.Add(player);
            //players.Add(dealer); 
        }
        public void BeginCards()
        {
            for (int i = 0; i < 2; i++)
            {
                player.Hand.Add(deck1.Shuffled[0]);
                player.Value = player.Value + deck1.Shuffled[0].Value;
                deck1.Shuffled.RemoveAt(0);
            }
        }
        public void AddCard()
        {
            for (int i = 0; i < players.Count; i++)
            {
                player.Hand.Add(deck1.Shuffled[0]);
                player.Value = player.Value + deck1.Shuffled[0].Value;
                deck1.Shuffled.RemoveAt(0);
            }
        }
        public void DealerBegin()
        {
            dealer.Hand.Add(deck1.Shuffled[0]);
            dealer.Value = dealer.Value + deck1.Shuffled[0].Value;
            deck1.Shuffled.RemoveAt(0);
        }

        public void DealerAdd()
        {
            if (players.Count == 0)
            {
                while (dealer.Value < 17)
                {
                    DealerBegin();
                }
            }
        }
        public void Gewonnen()
        {
            if (player.Value > dealer.Value && player.Value < 21)
            {
                Winn = true;
            }
            else if (player.Value == dealer.Value)
            {
                Push = true;
            }
            else if (dealer.Value > 21 && player.Value <= 21)
            {
                Winn = true;
            }
            else if (player.Value > 21 || player.Value < dealer.Value && dealer.Value <= 21)
            {
                Winn = false;
            }
        }
    }
}
