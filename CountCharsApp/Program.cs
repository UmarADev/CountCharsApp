using CountCharsApp.Services;
using System;

namespace CountCharsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isContinue;

            do
            {
                Console.WriteLine("Hi! This app gives you count of numbers and letters count of your text.");
                Console.WriteLine("Give me a text...");
                string userInput = Console.ReadLine();

                CountCharServices.GetCountValue(userInput);

                Console.WriteLine("Do you want to try again? y / n");
                isContinue = Console.ReadLine().ToLower();
            } while (isContinue == "y");
        }
    }
}
