using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string s2;
            Console.WriteLine("Введите строку в которой надо найти:");
            s1 = Console.ReadLine();
            Console.WriteLine("Введите что надо найти");
            s2 = Console.ReadLine();
            int i = 0;
            int x = -1;
            int count = -1; 
            while (i != -1)
            {
                i = s1.IndexOf(s2, x + 1); 
                x = i;
                count++; 
            }

            Console.WriteLine($"совпадений {count}");
            Console.ReadLine();


        }
    }
}
