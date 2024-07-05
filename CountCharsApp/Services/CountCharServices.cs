using System;

namespace CountCharsApp.Services
{
    internal class CountCharServices
    {
        private static int numbersCount = 0;
        private static int lettersCount = 0;
        private static int otherCount = 0;

        private static void GetCharacterCount(string userInput)
        {
            numbersCount = 0;
            lettersCount = 0;
            otherCount = 0;

            foreach (char character in userInput)
            {
                if (char.IsDigit(character))
                {
                    numbersCount++;
                }
                else if (char.IsLetter(character))
                {
                    lettersCount++;
                }
                else
                {
                    otherCount++;
                }
            }
        }

        public static void GetCountValue(string userInput)
        {
            GetCharacterCount(userInput);

            Console.WriteLine($"LETTERS: {lettersCount}\n");
            Console.WriteLine($"DIGITS: {numbersCount}\n");
            Console.WriteLine($"OTHERS: {otherCount}\n");
        }
    }
}
