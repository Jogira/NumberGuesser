using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GetUserDetails();

            char userAnswer = 'y';
            while (userAnswer != 'n')
            {

                //Make the correct number random.
                Random randomNumber = new Random();
                int correctNumber = randomNumber.Next(1, 11);
                int userGuess = 0;

                Console.WriteLine("Guess a number between 1 and 10.");

                while (userGuess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //Catch any invalid inputs
                    if (!int.TryParse(input, out userGuess))
                    {
                        PrintColoredMessage(ConsoleColor.DarkGreen, "That's not a valid input. Please enter a real number.");
                        continue;
                    }

                    userGuess = Int32.Parse(input);

                    if (userGuess != correctNumber)
                    {
                        PrintColoredMessage(ConsoleColor.Red, "That's the wrong number!");
                    }
                }

                PrintColoredMessage(ConsoleColor.DarkCyan, "That's correct! You win hahahahaaaaaaaaaaa. Want to play again? [Y/N]");

                userAnswer = Convert.ToChar(Console.ReadLine().ToLower());
            }
        }


        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Vueko Nakagawa";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.ResetColor();
        }

        static void GetUserDetails()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColoredMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
