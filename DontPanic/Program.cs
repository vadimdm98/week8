using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "K33p C4lm";
            str = str.Replace('3', 'e')?.Replace('4', 'a');
            Console.WriteLine(str);
        }
    }
}
