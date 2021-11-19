using System;

namespace DzLess2
{
    class Program
    {
        static int Task1(int a, int b)
        {
            int c;
            if (a > b)
            {
                c = a + b;
            }
            else if (a < b)
            {
                c = a - b;
            }
            else
            {
                c = a * b;
            }
            return c;
        }

        static int Task2(int x, int y)
        {
            int d = 0;
            if (x > 0)
            {
                if (y > 0)
                {
                    d = 1;
                }
                else
                {
                    d = 4;
                }
            }

            else
            {
                if (y > 0)
                {
                    d = 2;
                }
                else
                {
                    d = 3;
                }


            }
            return d;
        }

        static string Task3(int a, int b, int c)
        {
            int d1 = 0;
            int d2 = 0;
            int d3 = 0;
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        d1 = a;
                        d2 = b;
                        d3 = c;
                    }
                    else
                    {
                        d1 = a;
                        d2 = c;
                        d3 = b;
                    }
                }
                else
                {
                    d1 = c;
                    d2 = a;
                    d3 = b;
                }
            }
            else if (a > c)
            {
                d1 = b;
                d2 = a;
                d3 = c;
            }

            else if (b > c)
            {
                d1 = b;
                d2 = c;
                d3 = a;
            }
            else
            {
                d1 = c;
                d2 = b;
                d3 = a;
            }

            string k = " "+d1+ " " + d2 + " " + d3;
            return k;
        }

        static void Main()
        {
            string resolt  = Task3(14,40,11);

            Console.WriteLine(resolt);
        }



    }


           

    }



     