using System;
using System.Collections.Generic;

namespace MyCards
{
    class Deck
    {
        private List<Cards> deck;
        public Deck()
        {
            deck = new List<Cards>();
            List<string> suit = new List<string> { "Diamond", "Heart", "Spade", "Club" };
            List<string> value = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Cards card = new Cards(suit[i], value[j]);
                    deck.Add(card); 
                }
            }
        }
        public bool isEmpty()
        {
            if (deck.Count == 0) { return true; }
            else { return false; }
        }
        public void Shuffle()
        {
            List<Cards> CardDeck = deck;
            deck = new List<Cards>();
            Random r = new Random();
            int Repeater = CardDeck.Count;
            for (int i = 0; i < Repeater; i++)
            {
                int index = r.Next(0, CardDeck.Count);
                deck.Add(CardDeck[index]);
                CardDeck.RemoveAt(index);
            }
        }
        public void Deal()
        {
            Console.WriteLine($"{deck[0].Value}'s of {deck[0].Suit}");
            deck.RemoveAt(0);
        }
    }
}
