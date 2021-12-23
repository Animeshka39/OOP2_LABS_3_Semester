using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public enum Hand
    {
        Nothing,
        HighCard,
        OnePair,
        TwoPairs,
        ThreeKind,
        Straight,
        Flush,
        FullHouse,
        FourKind
    }

    public struct HandValue
    {
        public int Total { get; set; }
        public int HighCard { get; set; }
        public int SecondHighCard { get; set; }
    }

    class HandEvaluator : Card
    {
        private int heartsSum;
        private int diamondSum;
        private int clubSum;
        private int spadesSum;
        private Card[] cards;
        private HandValue handValue;

        public HandEvaluator(Card[] sortedHand)
        {
            heartsSum = 0;
            diamondSum = 0;
            clubSum = 0;
            spadesSum = 0;
            cards = new Card[7];
            Cards = sortedHand;
            handValue = new HandValue();
            if((int)cards[0].myValue > (int)cards[1].myValue)
            {
                handValue.HighCard = (int)cards[0].myValue;
                handValue.SecondHighCard = (int)cards[1].myValue;
            }
            else if ((int)cards[1].myValue > (int)cards[0].myValue)
            {
                handValue.HighCard = (int)cards[1].myValue;
                handValue.SecondHighCard = (int)cards[0].myValue;
            }

        }

        public HandValue HandValues
        {
            get { return handValue; }
            set { handValue = value; }
        }

        public Card[] Cards
        {
            get { return cards; }
            set
            {
                cards[0] = value[0];
                cards[1] = value[1];
                cards[2] = value[2];
                cards[3] = value[3];
                cards[4] = value[4];
                cards[5] = value[5];
                cards[6] = value[6];
            }
        }

        public Hand EvaluateHand()
        {
            //отримати номер кожної масті на руках
            getNumberOfSuit();
            if (FourOfKind())
                return Hand.FourKind;
            else if (FullHouse())
                return Hand.FullHouse;
            else if (Flush())
                return Hand.Flush;
            else if (Straight())
                return Hand.Straight;
            else if (ThreeOfKind())
                return Hand.ThreeKind;
            else if (TwoPairs())
                return Hand.TwoPairs;
            else if (OnePair())
                return Hand.OnePair;

            //якщо рука нічого, то виграє гравець з найвищою картою

            return Hand.HighCard;

            

        
    }


    private void getNumberOfSuit()
        {
            foreach (var element in Cards)
            {
                if (element.mySuit == Card.Suit.Hearts)
                    heartsSum++;
                else if (element.mySuit == Card.Suit.Diamonds)
                    diamondSum++;
                else if (element.mySuit == Card.Suit.Clubs)
                    clubSum++;
                else if (element.mySuit == Card.Suit.Spades)
                    spadesSum++;
            }
        }

        private bool FourOfKind()
        {
            //якщо перші 4 карти, додайте значення чотирьох карт і остання карта є найвищою
            if (cards[3].myValue == cards[4].myValue && cards[3].myValue == cards[5].myValue && cards[3].myValue == cards[6].myValue)
            {
                handValue.Total = (int)cards[1].myValue * 4;
                return true;
            }
            else if (cards[2].myValue == cards[3].myValue && cards[2].myValue == cards[4].myValue && cards[2].myValue == cards[5].myValue)
            {
                handValue.Total = (int)cards[2].myValue * 4;
                return true;
            }
            else if (cards[1].myValue == cards[2].myValue && cards[1].myValue == cards[3].myValue && cards[1].myValue == cards[4].myValue)
            {
                handValue.Total = (int)cards[1].myValue * 4;
                return true;
            }
            else if (cards[0].myValue == cards[1].myValue && cards[0].myValue == cards[2].myValue && cards[0].myValue == cards[3].myValue)
            {
                handValue.Total = (int)cards[0].myValue * 4;
                return true;
            }

            return false;
        }

        private bool FullHouse()
        {
            //перші три картки і дві останні карти однакового значення
            //перші дві картки та останні три карти однакового значення
            if
                ((cards[2].myValue == cards[3].myValue && cards[2].myValue == cards[4].myValue && cards[5].myValue == cards[6].myValue) ||
                (cards[2].myValue == cards[3].myValue && cards[4].myValue == cards[5].myValue && cards[4].myValue == cards[6].myValue))
            {
                handValue.Total = (int)(cards[2].myValue) + (int)(cards[3].myValue) + (int)(cards[4].myValue) +
                    (int)(cards[5].myValue) + (int)(cards[6].myValue);
                return true;
            }
            else if
                ((cards[1].myValue == cards[2].myValue && cards[1].myValue == cards[3].myValue && cards[4].myValue == cards[5].myValue) ||
                (cards[1].myValue == cards[2].myValue && cards[3].myValue == cards[4].myValue && cards[3].myValue == cards[5].myValue))
            {
                handValue.Total = (int)(cards[1].myValue) + (int)(cards[2].myValue) + (int)(cards[3].myValue) +
                    (int)(cards[4].myValue) + (int)(cards[5].myValue);
                return true;
            }
            else if ((cards[0].myValue == cards[1].myValue && cards[0].myValue == cards[2].myValue && cards[3].myValue == cards[4].myValue) ||
                (cards[0].myValue == cards[1].myValue && cards[2].myValue == cards[3].myValue && cards[2].myValue == cards[4].myValue))
            {
                handValue.Total = (int)(cards[0].myValue) + (int)(cards[1].myValue) + (int)(cards[2].myValue) +
                    (int)(cards[3].myValue) + (int)(cards[4].myValue);
                return true;
            }
            return false;
        }

        private bool Flush()
        {
            //якщо всі масті однакові
            if (heartsSum == 5 || diamondSum == 5 || clubSum == 5 || spadesSum == 5)
            {
                //якщо флеш, перемагає гравець з більш високими картами
                //у кого остання карта є найвищою, автоматично отримує всі карти вище
                handValue.Total = (int)cards[6].myValue;
                return true;
            }

            return false;
        }

        private bool Straight()
        {
            //якщо 5 послідовних значень
            if (cards[2].myValue + 1 == cards[3].myValue &&
                cards[3].myValue + 1 == cards[4].myValue &&
                cards[4].myValue + 1 == cards[5].myValue &&
                cards[5].myValue + 1 == cards[6].myValue)
            {
                //перемагає гравець з найбільшим значенням останньої карти
                handValue.Total = (int)cards[6].myValue;
                return true;
            }

            else if (
                cards[1].myValue + 1 == cards[2].myValue &&
                cards[2].myValue + 1 == cards[3].myValue &&
                cards[3].myValue + 1 == cards[4].myValue &&
                cards[4].myValue + 1 == cards[5].myValue)
            {
                handValue.Total = (int)cards[5].myValue;
                return true;
            }
            else if (
                cards[0].myValue + 1 == cards[1].myValue &&
                cards[1].myValue + 1 == cards[2].myValue &&
                cards[2].myValue + 1 == cards[3].myValue &&
                cards[3].myValue + 1 == cards[4].myValue)
            {
                //перемагає гравець з найбільшим значенням останньої карти
                handValue.Total = (int)cards[4].myValue;
                return true;
            }


            return false;
        }

        private bool ThreeOfKind()
        {
            //якщо 3 картки однакові
            if (cards[4].myValue == cards[5].myValue && cards[4].myValue == cards[6].myValue)
            {
                handValue.Total = (int)cards[6].myValue * 3;
                return true;
            }
            else if (cards[3].myValue == cards[4].myValue && cards[3].myValue == cards[5].myValue)
            {
                handValue.Total = (int)cards[5].myValue * 3;
                return true;
            }

            else if (cards[2].myValue == cards[3].myValue && cards[2].myValue == cards[4].myValue)
            {
                handValue.Total = (int)cards[4].myValue * 3;
                return true;
            }
            else if (cards[1].myValue == cards[2].myValue && cards[1].myValue == cards[3].myValue)
            {
                handValue.Total = (int)cards[3].myValue * 3;
                return true;
            }
            else if (cards[0].myValue == cards[1].myValue && cards[0].myValue == cards[2].myValue)
            {
                handValue.Total = (int)cards[2].myValue * 3;
                return true;
            }

            return false;
        }

        private bool TwoPairs()
        {
            //[6]+[5] 1-а пара і перевіряємо наявність другої пари
            if (cards[6].myValue == cards[5].myValue && cards[4].myValue == cards[3].myValue)
            {
                handValue.Total = ((int)cards[4].myValue * 2) + ((int)cards[6].myValue * 2);
                return true;
            }
            else if (cards[6].myValue == cards[5].myValue && cards[3].myValue == cards[2].myValue)
            {
                handValue.Total = ((int)cards[3].myValue * 2) + ((int)cards[6].myValue * 2);
                return true;
            }
            else if (cards[6].myValue == cards[5].myValue && cards[2].myValue == cards[1].myValue)
            {
                handValue.Total = ((int)cards[2].myValue * 2) + ((int)cards[6].myValue * 2);
                return true;
            }
            else if (cards[6].myValue == cards[5].myValue && cards[1].myValue == cards[0].myValue)
            {
                handValue.Total = ((int)cards[1].myValue * 2) + ((int)cards[6].myValue * 2);
                return true;
            }
            //[5]+[4] перша пара і перевіряємо наявність другої пари
            else if (cards[5].myValue == cards[4].myValue && cards[3].myValue == cards[2].myValue)
            {
                handValue.Total = ((int)cards[3].myValue * 2) + ((int)cards[5].myValue * 2);
                return true;
            }
            else if (cards[5].myValue == cards[4].myValue && cards[2].myValue == cards[1].myValue)
            {
                handValue.Total = ((int)cards[2].myValue * 2) + ((int)cards[5].myValue * 2);
                return true;
            }
            else if (cards[5].myValue == cards[4].myValue && cards[1].myValue == cards[0].myValue)
            {
                handValue.Total = ((int)cards[1].myValue * 2) + ((int)cards[5].myValue * 2);
                return true;
            }
            //[4]+[3] перевірка пари для другої пари
            else if (cards[4].myValue == cards[3].myValue && cards[2].myValue == cards[1].myValue)
            {
                handValue.Total = ((int)cards[2].myValue * 2) + ((int)cards[4].myValue * 2);
                return true;
            }
            else if (cards[4].myValue == cards[3].myValue && cards[1].myValue == cards[0].myValue)
            {
                handValue.Total = ((int)cards[1].myValue * 2) + ((int)cards[4].myValue * 2);
                return true;
            }
            //[3]+[2] перевірка пари для другої пари
            else if (cards[3].myValue == cards[2].myValue && cards[1].myValue == cards[0].myValue)
            {
                handValue.Total = ((int)cards[1].myValue * 2) + ((int)cards[3].myValue * 2);
                return true;
            }
            return false;
        }

        private bool OnePair()
        {
            //якщо 1,2 -> 5-а карта має найвище значення
            //2.3
            //3,4
            //4,5 -> картка №3 має найвище значення
            if (cards[6].myValue == cards[5].myValue)
            {
                handValue.Total = (int)cards[6].myValue * 2;
                return true;
            }
            else if (cards[5].myValue == cards[4].myValue)
            {
                handValue.Total = (int)cards[5].myValue * 2;
                return true;
            }
            else if (cards[4].myValue == cards[3].myValue)
            {
                handValue.Total = (int)cards[4].myValue * 2;
                return true;
            }
            else if (cards[3].myValue == cards[2].myValue)
            {
                handValue.Total = (int)cards[3].myValue * 2;
                return true;
            }
            else if (cards[2].myValue == cards[1].myValue)
            {
                handValue.Total = (int)cards[2].myValue * 2;
                return true;
            }
            else if (cards[1].myValue == cards[0].myValue)
            {
                handValue.Total = (int)cards[1].myValue * 2;
                return true;
            }
            return false;

        }
    }
}
