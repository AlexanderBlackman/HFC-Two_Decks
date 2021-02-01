using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace HFC_Two_Decks
{
    class Deck: ObservableCollection<Card>
    {
        private static Random random = new Random();

        public Deck()
        {
            Reset();
        }

        public void Reset()
        {
            this.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int y = 1; y < 14; y++)
                {
                    this.Add(new Card((Values)y, (Suits)i));
                }
            }
        }

        public Card Deal(int index)
        {
            Card cardToDeal = base[index];
            RemoveAt(index);
            return cardToDeal;
        }

       public void Sort()
        {
            List<Card> placeholderList = new List<Card>(this);
            placeholderList.Sort(new CardCompererSuitThenValue());
            Clear();
            foreach(Card card in placeholderList)
            {
                Add(card);
            }           
        }
        /*
        public void Shuffle()
        {
            List<Card> copy = new List<Card>(this);
            Clear();
            while (copy.Count > 0)
            {
                int index = random.Next(copy.Count);
                Card card = copy[index];
                copy.RemoveAt(index);
                Add(card);
            }
        }*/

        public void Shuffle()
        {
            List<Card> listToShuffle = new List<Card>(this);
            Clear();
            while(listToShuffle.Count > 0)
            {
                Card currentCard = listToShuffle[random.Next(listToShuffle.Count)];
                listToShuffle.Remove(currentCard);
                Add(currentCard);



            }


        }


    }
}
