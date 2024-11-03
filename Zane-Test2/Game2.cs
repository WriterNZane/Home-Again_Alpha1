using HomeAgain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAgain
{
    internal class Game2
    {
        public void Run()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You chose Dust Bunny Number Guesser! Get ready for some guessing!");

            {
                {
                    Random random = new Random();
                    int returnValue = random.Next(1, 100);
                    int Guess = 0;
                    Console.WriteLine("I am thinking of a number between 1-100. If you can guess what it is, you'll win a prize!");
                    while (Guess != returnValue)
                    {
                        Guess = Convert.ToInt32(Console.ReadLine());
                        if (Guess < returnValue)
                        {
                            Console.WriteLine("Nah, the number I'm thinkin is higher than " + Guess + ". Keep tryin!");
                        }
                        else if (Guess > returnValue)
                        {
                            Console.WriteLine("Too high buddy, the number on my mind is lower than " + Guess + ". You got this!");
                        }
                    }

                    Console.WriteLine("Well done buddy! The answer was " + returnValue);
                    Console.WriteLine("You win a clean room, and a new pet bunny!");

                    if (Guess == returnValue)
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
    }
}