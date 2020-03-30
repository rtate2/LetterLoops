using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //shotout to Monica
            Console.WriteLine("Please enter string");
            var userInput = Console.ReadLine();
            var builder = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                var position = i + 1;
                for (int k = 0; k < position; k++)
                {
                    builder += userInput[i];
                }
                builder += "-";
            }
            char[] charToTrim = { '-' };
            var output = builder.TrimEnd(charToTrim);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
