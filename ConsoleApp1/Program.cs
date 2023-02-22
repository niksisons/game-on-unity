global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int speed;
            int k, m;
            Console.Write("Введите скорость: ");
            speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(speed);
            Console.Write("Введите длинну: ");
            k = Convert.ToInt32(Console.ReadLine());
            m = 0;
            while (k < 100)
            {
                k++;
                m++;
            }

            Console.WriteLine(m);
            Console.WriteLine(k);
        }
    }
}