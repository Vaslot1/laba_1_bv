using System;

namespace Lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму в копейках");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Logic.Convert_Money(n));

        }
    }
    public class Logic
    {


        public static String Convert_Money(int n)
        {
            string s = "";
            int a, b;
            if ((n >= 1) && (n <= 9999))
            {
                a = n / 100;
                b = n % 100;
                if (a != 0)
                {
                    if (a > 10 && a < 20)
                        s += n / 100 + " Рублей ";
                    else
                    {
                        if (a % 10 == 1)
                            s += n / 100 + " Рубль ";
                        else if (a % 10 > 1 && a % 10 < 5)
                            s += n / 100 + " Рубля ";
                        else if (a % 10 > 4 || a % 10 == 0)
                            s += n / 100 + " Рублей ";
                    }
                }
                if (b > 10 && b < 20)
                    s += n % 100 + " Копеек";
                else
                {
                    if (b % 10 == 1)
                        s += n % 100 + " Копейка";
                    else if (b % 10 > 1 && b % 10 < 5)
                        s += n % 100 + " Копейки";
                    else if (b % 10 > 4 || b % 10 == 0)
                        s += n % 100 + " Копеек";
                }
            }
            else
            {
                s = "Ошибка";
            }
            return s;
        }
    }
}