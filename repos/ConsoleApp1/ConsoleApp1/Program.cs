using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int x;
            int sum;
            int rezult;

            Console.WriteLine("Введите количество  чисел");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Введите заданное количество чисел");
                x = Convert.ToInt32(Console.ReadLine());
                sum = +x;
                rezult = sum / n;

            }
            Console.WriteLine(rezult);
        }
    }
}
