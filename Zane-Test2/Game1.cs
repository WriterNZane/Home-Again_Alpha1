using HomeAgain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAgain
{
    internal class Game1
    {
        public void Run()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("You chose the Bakery Treat Guesser! Have fun guessing treats!");
            //List of words that can be used for the game.
            var words = new[]
            {
             "cookies",
             "pie",
             "brownies",
             "cake",
             "bananabread",
             "cinnamonrolls",

            };
            var chosenWord = words[new Random().Next(0, words.Length - 1)];

            var validCharacters = new System.Text.RegularExpressions.Regex("^[a-z]$");

            var lives = 5;

            var letters = new List<string>();

            while (lives != 0)
            {
                var charactersLeft = 0;

                foreach (var character in chosenWord)
                {
                    var letter = character.ToString();

                    if (letters.Contains(letter))
                    {
                        Console.Write(letter);
                    }
                    else
                    {
                        Console.Write("_");

                        charactersLeft++;
                    }
                }
                Console.WriteLine(string.Empty);

                if (charactersLeft == 0)
                {
                    break;
                }

                Console.Write("Type in a letter (any letter will do!): ");

                var key = Console.ReadKey().Key.ToString().ToLower();
                Console.WriteLine(string.Empty);

                if (!validCharacters.IsMatch(key))
                {
                    Console.WriteLine($"The letter {key} is invalid :(. Try again!");
                    continue;
                }

                if (letters.Contains(key))
                {
                    Console.WriteLine("You already entered this letter silly!");
                    continue;
                }
                letters.Add(key);

                if (!chosenWord.Contains(key))
                {
                    lives--;

                    if (lives > 0)
                    {
                        Console.WriteLine($"The letter {key} is not in the word >:(. You have {lives} {(lives == 1 ? "try" : "tries")} left.");
                    }
                }
            }

            if (lives > 0)
            {
                Console.WriteLine($"You won with {lives} {(lives == 1 ? "life" : "lives")} left!");
            }
            else
            {
                Console.WriteLine($"You lost :(! The word was {chosenWord}.");
                Console.WriteLine("You spent so much time not guessing the right treat, that you dont get to eat any before heading to work :(");
                Console.WriteLine("Womp Womp loser");
            }


            {
                Console.WriteLine("Would you like to return to the start of your break?");
                Console.WriteLine("(Y)es, (N)o");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Y":
                        Program.Run();
                        break;
                    case "N":
                        break;
                }
            }
        }
    }
}


