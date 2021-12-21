using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            int type = 0;
            while (type != 3)
            {
                menu = 0;
                Console.WriteLine("Виберiть тип фiгури: 1-Трикутник, 2-Чотирикутник 3-Завершити роботу");
                type = Convert.ToInt32(Console.ReadLine());

                if (type == 1)          //Трикутник  
                {
                    Console.WriteLine("Виберiть тип створеннятрикутника: 1-три сторони, 2-двi сторони i кут, 3-сторона i два кути, 4-Завершити роботу");
                    menu = Convert.ToInt32(Console.ReadLine());
                    if (menu != 4)
                    {
                        Console.WriteLine("        a        ");
                        Console.WriteLine("       /\\       ");
                        Console.WriteLine("      /  \\      ");
                        Console.WriteLine("    B/    \\C    ");
                        Console.WriteLine("    /      \\    ");
                        Console.WriteLine("  c/________\\b  ");
                        Console.WriteLine("        A        ");
                    }
                    if (menu == 1)                        //три сторони   
                    {
                        Console.WriteLine("Введiть сторону A ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введiть сторону B ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введiть сторону C ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
                        {
                            new Triangle(a, b, c);
                        }
                        else
                        {
                            Console.WriteLine("Такий трикутник не iснує введiть iнше значення.");
                        }
                    } //три сторони   
                    else if (menu == 2)                              //двi сторони
                    {
                        Console.WriteLine("Введiть сторону A ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введiть сторону B ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введiть кут c ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        new Triangle(a, b, c);
                    }//двi сторони i кут
                    else if (menu == 3)                                   //сторона i два кути
                    {
                        Console.WriteLine("Введiть сторону A ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введiть кут b ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введiть кут с ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        new Triangle(a, b, c);
                    }//сторона i два кути
                    else if (menu == 4)
                    {
                        type = 3;
                    }
                    else
                    {
                        Console.WriteLine("Ви ввели невiрне значення");
                    }
                    if (menu != 4)
                    {
                        Console.WriteLine("\nДля продовження натиснiть Ентер");
                        string z = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                    }
                }      //Трикутник
                else if (type == 2)    //Чотирикутник
                {
                    Console.WriteLine("Виберiть тип створеннятрикутника: 1-чотири сторони i два кута, 4-Завершити роботу");
                    menu = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("   ____A___    ");
                    Console.WriteLine("  a|\\    /|d  ");
                    Console.WriteLine("   | \\  / |   ");
                    Console.WriteLine("  B|  \\/  | D ");
                    Console.WriteLine("   |  /\\  |   ");
                    Console.WriteLine("   | /  \\ |   ");
                    Console.WriteLine("  b|/____\\|c  ");
                    Console.WriteLine("       C       ");
                    if (menu == 1)
                    {
                        Console.WriteLine("Введiть сторону A ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введiть сторону B ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введiть сторону C ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введiть сторону D ");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введiть кут a ");
                        double bk = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введiть кут с ");
                        double ck = Convert.ToDouble(Console.ReadLine());
                        new Square(a, b, c, d, bk, ck);
                    }
                    if (menu != 4)
                    {
                        Console.WriteLine("\nДля продовження натиснiть Ентер");
                        string z = Convert.ToString(Console.ReadLine());
                        Console.Clear();
                    }
                } //Чотирикутник
            }
        }
    }
    class GeometricShapes
    {
        public double area, halfPerim, ah, bh, ch, ro, rv, ak, bk, ck, dk, la, lb, lc, ma, mb, mc, a, b, c, d, d1, d2;
    }
    class Triangle : GeometricShapes
    {
        public Triangle() { }
        public Triangle(int at, int bt, int ct)                      //три сторони
        {
            a = at;
            b = bt;
            c = ct;
            halfPerim = (Convert.ToDouble(a + b + c) / 2);
            area = Math.Sqrt(halfPerim * (halfPerim - a) * (halfPerim - b) * (halfPerim - c));
            ak = getAngl(a, b, c, area);
            bk = getAngl(b, a, c, area);
            ck = getAngl(c, a, b, area);
            printResult();
        }
        public Triangle(int at, int bt, double ckt)                  //двi сторони i кут
        {
            a = at;
            b = bt;
            ck = ckt;
            area = (a * b * (Math.Sin(ck / 180 * Math.PI))) / 2;
            c = (Math.Sqrt((a * a) + (b * b) - (2 * a * b) * (Math.Cos(ck / 180 * Math.PI))));
            ak = getAngl(a, b, c, area);
            bk = getAngl(b, a, c, area);

            halfPerim = (Convert.ToDouble(a + b + c) / 2);
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                printResult();
            }
            else
            {
                Console.WriteLine("Такий трикутник не iснує, введiть iнше значення.");
            }
        }
        public Triangle(int at, double akt, double bkt)              //сторона i два кути
        {
            a = at;
            bk = akt;
            ck = bkt;

            ak = 180 - ck - bk;
            c = a * (Math.Sin(ck / 180 * Math.PI) / Math.Sin(ak / 180 * Math.PI));
            b = c * (Math.Sin(bk / 180 * Math.PI) / Math.Sin(ck / 180 * Math.PI));

            halfPerim = (Convert.ToDouble(a + b + c) / 2);
            area = Math.Sqrt(halfPerim * (halfPerim - a) * (halfPerim - b) * (halfPerim - c));
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                printResult();
            }
            else
            {
                Console.WriteLine("Такий трикутник не iснує введiть iнше значення.");
            }
        }
        public double getAngleAcute(double a, double b, double area)     //приймає дві сторони і площу, повертає кут між ними (тільки гострий)
        {
            return ((Math.Asin((area * 2) / (a * b))) * 180 / Math.PI);

        }
        public double getAngl(double a, double b, double c, double area)  //приймає 3 сторони і площу, повиртає кут навпроти першої сторони
        {
            double akr;
            if (a > b && a > c)
            {
                akr = 180 - getAngleAcute(c, a, area) - getAngleAcute(a, b, area);
            }
            else if (b > a && b > c)
            {
                akr = getAngleAcute(c, b, area);
            }
            else if (c > a && c > b)
            {
                akr = getAngleAcute(c, b, area);
            }
            else
            {
                akr = getAngleAcute(c, b, area);
            }
            return (akr);
        }
        public void printResult()                                    //результати трикутника
        {
            string typeAngle, typeSide;
            ah = area * 2 / a;
            bh = area * 2 / b;
            ch = area * 2 / c;

            ro = (a * b * c) / (4 * area);
            rv = area / halfPerim;

            la = (2 * (Math.Sqrt(b * c * halfPerim * (halfPerim - a))) / (b + c));
            lb = (2 * (Math.Sqrt(a * c * halfPerim * (halfPerim - b))) / (a + c));
            lc = (2 * (Math.Sqrt(b * a * halfPerim * (halfPerim - c))) / (b + a));
            ma = 0.5 * Math.Sqrt((2 * b * b) + (2 * c * c) - (a * a));
            mb = 0.5 * Math.Sqrt((2 * a * a) + (2 * c * c) - (b * b));
            mc = 0.5 * Math.Sqrt((2 * b * b) + (2 * a * a) - (c * c));

            if (ak > 90 || bk > 90 || ck > 90) { typeAngle = "тупий "; }
            else if (ak == 90 || bk == 90 || ck == 90) { typeAngle = "прямокутнiй "; }
            else { typeAngle = "гострокутнiй "; }

            if (a == b && b == c) { typeSide = "рiвностороннiй"; }
            else if (a == b || b == c || a == c) { typeSide = "рiвнобедрений"; }
            else { typeSide = "рiзностороннiй"; }

            Console.WriteLine("         РЕЗУЛЬТАТ          ");
            Console.WriteLine($"Трикутник {typeAngle}i {typeSide}");
            Console.WriteLine($"периметр ={Math.Round(halfPerim * 2, 2)}");
            Console.WriteLine($"площа ={Math.Round(area, 2)}");
            Console.WriteLine($"сторону а={Math.Round(a, 2)}");
            Console.WriteLine($"сторону b={Math.Round(b, 2)}");
            Console.WriteLine($"сторону c={Math.Round(c, 2)}");
            Console.WriteLine($"кут a={Math.Round(ak, 2)}");
            Console.WriteLine($"кут b={Math.Round(bk, 2)}");
            Console.WriteLine($"кут c={Math.Round(ck, 2)}");
            Console.WriteLine($"радiус вписаного кола={Math.Round(rv, 2)}");
            Console.WriteLine($"радiус описаного кола={Math.Round(ro, 2)}");
            Console.WriteLine($"висота до сторони а={Math.Round(ah, 2)}");
            Console.WriteLine($"висота до сторони b={Math.Round(bh, 2)}");
            Console.WriteLine($"висота до сторони c={Math.Round(ch, 2)}");
            Console.WriteLine($"бiсектриса до сторони а={Math.Round(la, 2)}");
            Console.WriteLine($"бiсектриса до сторони b={Math.Round(lb, 2)}");
            Console.WriteLine($"бiсектриса до сторони c={Math.Round(lc, 2)}");
            Console.WriteLine($"медiана до сторони a={Math.Round(ma, 2)}");
            Console.WriteLine($"медiана до сторони b={Math.Round(mb, 2)}");
            Console.WriteLine($"медiана до сторони c={Math.Round(mc, 2)}");
        }
    }
    class Square : Triangle
    {
        public Square(int at, int bt, int ct, int dt, double akt, double ckt)
        {
            a = at;
            b = bt;
            c = ct;
            d = dt;
            ak = akt;
            ck = ckt;
            double akd1, ckd1, bkd1, akd2, ckd2, bkd2;
            halfPerim = (Convert.ToDouble(a + b + c + d) / 2);
            area = Math.Sqrt(halfPerim * (halfPerim - a) * (halfPerim - b) * (halfPerim - c) - (a * b * c * d * Math.Pow(Math.Cos(((ak + ck) / 2) / 180 * Math.PI), 2)));

            double tymeArea = (a * b * (Math.Sin(ck / 180 * Math.PI))) / 2;
            d1 = (Math.Sqrt((a * a) + (b * b) - (2 * a * b) * (Math.Cos(ak / 180 * Math.PI))));
            {    //Тимчасові кути
                //-----abd1----------------------------------------------------------------------------
                double halfPerimTyme = (a + b + d1) / 2;
                double areaTyme = Math.Sqrt(halfPerimTyme * (halfPerimTyme - a) * (halfPerimTyme - b) * (halfPerimTyme - d1));
                bkd1 = getAngl(b, a, d1, area);
                ckd1 = getAngl(d1, a, b, area);
                akd1 = getAngl(a, b, d1, area);
                //-----cdd1----------------------------------------------------------------------------
                halfPerimTyme = (c + d + d1) / 2;
                areaTyme = Math.Sqrt(halfPerimTyme * (halfPerimTyme - c) * (halfPerimTyme - d) * (halfPerimTyme - d1));
                bkd1 = getAngl(b, a, d1, area);
                ckd1 = getAngl(d1, a, b, area);
                akd1 = getAngl(a, b, d1, area);

                if (c > d && c > d1)
                {
                    bkd2 = (Math.Asin((areaTyme * 2) / (d1 * c))) * 180 / Math.PI;
                    ckd2 = (Math.Asin((areaTyme * 2) / (c * d))) * 180 / Math.PI;
                    akd2 = 180 - bkd2 - ckd2;
                }
                else if (d > c && d > c)
                {
                    akd2 = (Math.Asin((areaTyme * 2) / (d1 * d))) * 180 / Math.PI;
                    ckd2 = (Math.Asin((areaTyme * 2) / (c * d))) * 180 / Math.PI;
                    bkd2 = 180 - akd2 - ckd2;
                }
                else if (d1 > c && d1 > d)
                {
                    akd2 = (Math.Asin((areaTyme * 2) / (1d * d))) * 180 / Math.PI;
                    bkd2 = (Math.Asin((areaTyme * 2) / (d1 * c))) * 180 / Math.PI;
                    ckd2 = 180 - akd2 - bkd2;
                }
                else
                {
                    akd2 = (Math.Asin((areaTyme * 2) / (d1 * d))) * 180 / Math.PI;
                    bkd2 = (Math.Asin((areaTyme * 2) / (d1 * c))) * 180 / Math.PI;
                    ckd2 = (Math.Asin((areaTyme * 2) / (c * d))) * 180 / Math.PI;
                }
            } //Тимчасові кути
            bk = akd1 + bkd2;
            dk = bkd1 + ckd2;
            tymeArea = (c * b * (Math.Sin(bk / 180 * Math.PI))) / 2;
            d2 = (Math.Sqrt((c * c) + (b * b) - (2 * c * b) * (Math.Cos(bk / 180 * Math.PI))));
            printResultKv();
        }
        public void printResultKv()                               //результати чотирикутника
        {
            string typeAngle;
            rv = area / halfPerim;
            if (a == b && b == c && c == d && ck == 90 && ak == 90 && bk == 90)
            {
                typeAngle = "квадрат ";
            }
            else if (a == b && b == c && c == d)
            {
                typeAngle = "ромб ";
            }
            else if (a == c && b == d && ck == 90 && ak == 90 && bk == 90)
            {
                typeAngle = "прямокутник ";
            }
            else if (a == c && b == d)
            {
                typeAngle = "паралелограм ";
            }
            else
            {
                typeAngle = "довiльний ";
            }

            Console.WriteLine("         РЕЗУЛЬТАТ          ");
            Console.WriteLine($"Чотирикутник {typeAngle}");
            Console.WriteLine($"периметр = {Math.Round(halfPerim * 2, 2)}");
            Console.WriteLine($"площа = {Math.Round(area, 2)}");
            Console.WriteLine($"сторона а= {Math.Round(a, 2)}");
            Console.WriteLine($"сторона b= {Math.Round(b, 2)}");
            Console.WriteLine($"сторона c= {Math.Round(c, 2)}");
            Console.WriteLine($"сторона d= {Math.Round(d, 2)}");
            Console.WriteLine($"кут a= {Math.Round(ak, 2)}");
            Console.WriteLine($"кут b= {Math.Round(bk, 2)}");
            Console.WriteLine($"кут c= {Math.Round(ck, 2)}");
            Console.WriteLine($"кут d= {Math.Round(dk, 2)}");
            Console.WriteLine($"радiус вписаного кола= {Math.Round(rv, 2)}");
            Console.WriteLine($"Дiагональ d1= {Math.Round(d1, 2)}");
            Console.WriteLine($"Дiагональ d2= {Math.Round(d2, 2)}");
        }
    }
}
