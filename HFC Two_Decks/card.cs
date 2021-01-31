using System;
using System.Collections.Generic;
using System.Text;

namespace HFC_Two_Decks
{
    class Card
    {

        public  Values Value { get; private set; }
        public Suits Suit { get; private set; }
 //       public string Name { get { return $"{Value} of {Suit}"; } }

        public Card(Values value, Suits suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }

    enum Suits
    {
        Diamonds,
        Clubs,
        Hearts,
        Spades,
    }

    enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five,
        Six,
        Seven,
        Eight, 
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    enum TrickScore
    {
        Sit = 6,
        Beg = 2,
        Rollover = 6,
        Speak = 30,
        Fetch = 11,
        ComeHere = 89,
    }

    enum byteScores : byte {
        Alex = 5,
        //Blackman = 999, byte max is 255
        //also, cannot use floating point numbers.

    }

}
