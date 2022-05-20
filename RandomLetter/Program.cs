using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Random letter from your name: {0}", userName?[new Random().Next(userName.Length)]);
        }
    }
}
