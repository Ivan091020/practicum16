using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum16
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ///Задание 1
            for (int i = 0; i < 10; i++)
            {
                Console.Write("A");
            }
            ////Задание2
            for (int q = 50; q >= 40; q--)
            {
                Console.WriteLine(q);
            }
            /// Задание 3
            int[] numbers = { 6, 12, 24, 30, 36 };
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            ///Задание 4
            int count = 0;
            int sum = 0;
            int e;
            for (e = 11; e < 100; e += 11)
            {
                Console.WriteLine(e);
                count++;
                sum += e;
            }
            Console.WriteLine($"Количество : {count}");
            Console.WriteLine($"Сумма : {sum}");
            ///задание 5
            for (int i = 100; i <= 999; i++)
            {
                int sumOfDigits = 0;
                int number = i;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number /= 10;
                }
                if (sumOfDigits == 20)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine($"Количество трехзначных чисел, сумма цифр которых равна 20: {count}");
            ///Задание 6
            Console.Write("Введите сумму вклада: ");
            double deposit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество месяцев: ");
            int months = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < months; i++)
            {
                deposit += deposit * 0.07;
            }

            Console.WriteLine($"Конечная сумма вклада: {deposit:F2}");
            ///Zadanie 7
            double initialPrice = 100;
            int numberOfShares = 1000;
            double[] prices = new double[10];

            for (int i = 0; i < 10; i++)
            {
                initialPrice += initialPrice * 0.1;
                prices[i] = initialPrice;
            }

            Console.WriteLine("Стоимость акции:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 2} месяц = {prices[i]:F2} руб");
            }

            double profit = prices[6] * numberOfShares;
            Console.WriteLine($"Стоимость 1000 акций на 7 месяц = {profit:F2} руб");

        }

    }
}
