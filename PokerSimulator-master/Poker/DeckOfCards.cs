using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class DeckOfCards : Card
    {
        const int NumberOfCards = 52; //Загальна кількість карт у колоді
        private Card[] Deck; //Масив усіх карт

        public DeckOfCards()
        {
            Deck = new Card[NumberOfCards];
        }

        public Card[] GetDeck { get { return Deck; } } //Отримати поточну колоду

        //Створіть колоду з 52 карт, по 13 масті, 4 масті
        public void SetupDeck()
        {
            int i = 0;
            foreach(Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach(Value v in Enum.GetValues(typeof(Value)))
                {
                    Deck[i] = new Card { mySuit = s, myValue = v };
                    i++;
                }
            }
            ShuffleCards();
        }
        // Перетасуйте колоду
        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;
            //Виконайте перемішування 1000 разів
            for (int shuffle = 0; shuffle < 1000; shuffle++)
            {
                for (int i = 0; i < NumberOfCards; i++)
                {
                    //Поміняйте карти
                    int SecondCardIndex = rand.Next(13);
                    temp = Deck[i];
                    Deck[i] = Deck[SecondCardIndex];
                    Deck[SecondCardIndex] = temp;
                }
            }
        }
    }
}
