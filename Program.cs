using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();
            PlayGame();
        }

        static void GetAppInfo()
        {
            string appName = "NumberGuesser";
            string author = "Tyler";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0}: Written by {1}", appName, author);
            Console.ResetColor();
        }

        static void GreetUser()
        {
             Console.WriteLine("Who are you?");
             string inputName = Console.ReadLine();
             Console.WriteLine("Hello {0} lets guess a number", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static int CorrectNumber()
        {
            Random random = new Random();
            int correctNumber = random.Next(1, 10);
            return correctNumber;
        }

        static void PlayGame()
        {
            while (true)
            {
                int correctNumber = CorrectNumber();
                int guess = 0;

                Console.WriteLine("Guess a Number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Are you drunk?! Enter number!");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Guess Again");
                    }
                }

                PrintColorMessage(ConsoleColor.Green, "Ya did it!");

                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

    }
}
