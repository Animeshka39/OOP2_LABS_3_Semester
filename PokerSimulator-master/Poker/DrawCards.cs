using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class DrawCards
    {
        //Намалюйте контури карток
        public static void DrawCardOutline(int xCoor, int yCoor)
        {
            Console.BackgroundColor = ConsoleColor.White;

            int x = xCoor * 12; //10 символів підкреслення для малювання лінії та один пробіл з обох сторін для країв
            int y = yCoor;


            Console.SetCursorPosition(x, y);//Початкове положення, де брати картку
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" __________\n");//Верхній край картки

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 9)
                {
                    Console.WriteLine("|          |");//Лівий і правий краї картки
                }
                else
                {
                    Console.WriteLine("|__________|");//Нижня частина картки
                }
            }
        }
        //Display suit and value on the card
        public static void DrawCardSuitValue(Card card, int xCoor, int yCoor)
        {
            char cardSuit = ' ';
            int x = xCoor * 12;
            int y = yCoor;

            //Кодуйте кожен масив байтів за допомогою CodePage437 у символ для символу масті
            //Серця і ромби червоні, піки і трефи чорні
            switch (card.mySuit)
            {
                case Card.Suit.Hearts:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 3 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.Suit.Diamonds:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 4 })[0];
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.Suit.Clubs:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 5 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Card.Suit.Spades:
                    cardSuit = Encoding.GetEncoding(437).GetChars(new byte[] { 6 })[0];
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            //Відображати закодований символ на всіх 4 кутах і значення
            Console.SetCursorPosition(x + 2, y + 2);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 9, y + 2);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 2, y + 9);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 9, y + 9);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 4, y + 5);
            Console.Write(card.myValue);
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
}

