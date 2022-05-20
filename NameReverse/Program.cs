using System;

namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, enter your name: ");
            string userName = Console.ReadLine();
            for (int i = userName.Length; i > 0; i--)
            {
                Console.Write(userName[i - 1]);
            }
        }
    }
}
