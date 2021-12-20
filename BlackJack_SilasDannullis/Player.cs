using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_SilasDannullis
{
    class Player : Table
    {
        // public string Name;
        public int Value;
        public List<Card> Hand = new List<Card>();

        /* public override string ToString()
         {
             return string.Format(Name);
         }*/
    }
}

