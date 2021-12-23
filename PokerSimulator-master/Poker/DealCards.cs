using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class DealCards : DeckOfCards
    {
        private Card[] PlayerHand;
        private Card[] ComputerHand;
        private Card[] SortedPlayerHand;
        private Card[] SortedComputerHand;
        private Card[] FlopHand;
        public Card[] FirstPlayerHand;
        public Card[] FirstComputerHand;


        public DealCards()
        {
            FlopHand = new Card[5];
            PlayerHand = new Card[7];
            FirstPlayerHand = new Card[2];
            SortedPlayerHand = new Card[7];
            ComputerHand = new Card[7];
            FirstComputerHand = new Card[2];
            SortedComputerHand = new Card[7];

        }
        public void Deal()
        {
            SetupDeck(); // Створюємо колоду та перемішуємо її
            GetHand(); // Роздавальна рука
            SortCards(); // Сортування карток
            DisplayCards();// Відображення карток
            EvaluateHands(); // Обрахунок руки

        }
        public void GetHand()
        {
            //Роздати 2 карти гравцеві
            for (int i = 0; i < 2; i++)
                PlayerHand[i] = GetDeck[i];
            //Роздає 2 карти для ПК
            for (int i = 2; i < 4; i++)
                ComputerHand[i - 2] = GetDeck[i];
            //Роздає 5 карт на стіл     
            for (int i = 4; i < 9; i++)
                FlopHand[i - 4] = GetDeck[i];
            //Пам'ятайте про перші роздачі перед злиттям з столом для оцінки особистої високої карти
            FirstPlayerHand = PlayerHand;
            FirstComputerHand = ComputerHand;
            //Додайє стіл-руку в обидві руки
            FlopHand.CopyTo(PlayerHand, 2);
            FlopHand.CopyTo(ComputerHand, 2);


        }
        public void SortCards()
        {
            var QueryPlayer = from hand in PlayerHand
                              orderby hand.myValue
                              select hand;
            var QueryComputer = from hand in ComputerHand
                                orderby hand.myValue
                                select hand;
            var index = 0;

            foreach(var element in QueryPlayer.ToList())
            {
                SortedPlayerHand[index] = element;
                index++;
            }
            index = 0;
            foreach (var element in QueryComputer.ToList())
            {
                SortedComputerHand[index] = element;
                index++;
            }


        }
        public void DisplayCards()
        {
            Console.Clear();
            int x = 0; //Горизонтальне положення курсору
            int y = 1; //Вертикальне положення курсору

            //Показую руку гравця
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Players hand");
            for (int i = 0; i < 2; i++) 
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(PlayerHand[i], x, y);
                x++;//Рухайтеся вправо для наступної картки
            }

            y = 15; //Перемістіть ряд карт ПК вниз під гравцями
            x = 0;
            //Показує стіл
            Console.SetCursorPosition(x, 14);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Flop");
            for (int i = 0; i < 5; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(FlopHand[i], x, y);
                x++;//Рухайтеся вправо для наступної картки
            }


            y = 29; //Перемістить ряд карт ПК вниз під гравцями
            x = 0;
            //Показати руку ПК
            Console.SetCursorPosition(x, 28);
            Console.ForegroundColor = ConsoleColor.DarkYellow;            
            Console.WriteLine("Computers hand");            
            for (int i = 0; i < 2; i++)
            {                
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(ComputerHand[i], x, y);
                x++;//Рухайтеся вправо для наступної картки
            }




        }
        public void EvaluateHands()
        {
            //оцінити кожну руку гравця до столу
            HandEvaluator firstPlayerHandEvaluator = new HandEvaluator(FirstPlayerHand);
            HandEvaluator firstComputerHandEvaluator = new HandEvaluator(FirstComputerHand);
            //отримати кожну руку гравця та значення карт карт
            Hand playerHighCard = firstPlayerHandEvaluator.EvaluateHand();
            Hand computerHighCard = firstComputerHandEvaluator.EvaluateHand();

            //створити об'єкти оцінки комп'ютера гравця (передаючи SORTED руку конструктору)
            HandEvaluator playerHandEvaluator = new HandEvaluator(SortedPlayerHand);
            HandEvaluator computerHandEvaluator = new HandEvaluator(SortedComputerHand);

            //отримати руку гравця та комп’ютера
            Hand playerHand = playerHandEvaluator.EvaluateHand();
            Hand computerHand = computerHandEvaluator.EvaluateHand();

            //display each hand
            Console.WriteLine("\n\n\n\n\n\n\n\nPlayer's Hand: " + playerHand);
            Console.WriteLine("\nComputer's Hand: " + computerHand);

            //відобразити кожну руку
            if (playerHand > computerHand)
            {
                Console.WriteLine("Player WINS!");
            }
            else if (playerHand < computerHand)
            {
                Console.WriteLine("Computer WINS!");
            }
            else


            //якщо руки однакові, оцініть значення
            {
                //спочатку оцінюється, хто має вищу цінність покерної руки
                if (playerHandEvaluator.HandValues.Total > computerHandEvaluator.HandValues.Total)
                    Console.WriteLine("Player WINS!");
                else if (playerHandEvaluator.HandValues.Total < computerHandEvaluator.HandValues.Total)
                    Console.WriteLine("Computer WINS!");
                //якщо обидва мають однакову покерну руку (наприклад, у обох є пара дам),
                //тоді виграє гравець з наступною більш високою картою
                else if (firstPlayerHandEvaluator.HandValues.HighCard > firstComputerHandEvaluator.HandValues.HighCard)
                    Console.WriteLine("Player WINS!");
                else if (firstPlayerHandEvaluator.HandValues.HighCard < firstComputerHandEvaluator.HandValues.HighCard)
                    Console.WriteLine("Computer WINS!");
                //якщо старша карта такого ж значення, перевірте другу карту в руці гравця
                else if (firstPlayerHandEvaluator.HandValues.SecondHighCard > firstComputerHandEvaluator.HandValues.SecondHighCard)
                    Console.WriteLine("Player WINS!");
                else if (firstPlayerHandEvaluator.HandValues.SecondHighCard < firstComputerHandEvaluator.HandValues.SecondHighCard)
                    Console.WriteLine("Computer WINS!");
                else
                    Console.WriteLine("DRAW, everyone's a winner!");
            }
        }
    }
}
