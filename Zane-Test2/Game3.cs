using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAgain
{
    internal class Game3
    {

    public void Run()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            {
                const int fieldLength = 50, fieldWidth = 15;
                const char fieldTile = '_';
                string line = string.Concat(Enumerable.Repeat(fieldTile, fieldLength));

                const int racketLength = fieldWidth / 8;
                const char racketTile = '|';

                int leftRacketHeight = 0;
                int rightRacketHeight = 0;

                int ballX = fieldLength / 2;
                int ballY = fieldWidth / 2;
                const char ballTile = 'O';

                bool isBallGoingDown = true;
                bool isBallGoingRight = true;

                int leftPlayerPoints = 0;
                int rightPlayerPoints = 0;

                int scoreboardX = fieldLength / 2 - 2;
                int scoreboardY = fieldWidth + 1;

                while (true)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(line);

                    Console.SetCursorPosition(0, fieldWidth);
                    Console.WriteLine(line);

                    for (int i = 0; i < racketLength; i++)
                    {
                        Console.SetCursorPosition(0, i + 1);
                        Console.WriteLine(racketTile);
                        Console.SetCursorPosition(fieldLength - 1, i + 1 + rightRacketHeight);
                        Console.WriteLine(racketTile);
                    }

                    while (!Console.KeyAvailable)
                    {
                        Console.SetCursorPosition(ballX, ballY);
                        Console.WriteLine(ballTile);
                        Thread.Sleep(100); 

                        Console.SetCursorPosition(ballX, ballY);
                        Console.WriteLine(" "); 

                        if (isBallGoingDown)
                        {
                            ballY++;
                        }
                        else
                        {
                            ballY--;
                        }
                        if (isBallGoingRight)
                        {
                            ballX++;
                        }
                        else
                        {
                            ballX--;
                        }

                        if (ballY == 1 || ballY == fieldWidth - 1)
                        {
                            isBallGoingDown = !isBallGoingDown; 
                        }

                        if (ballX == 1)
                        {
                            if (ballY >= leftRacketHeight + 1 && ballY <= leftRacketHeight + racketLength)
                            {
                                isBallGoingRight = !isBallGoingRight;
                            }
                            else 
                            {
                                rightPlayerPoints++;
                                ballY = fieldWidth / 2;
                                ballX = fieldLength / 2;
                                Console.SetCursorPosition(scoreboardX, scoreboardY);
                                Console.WriteLine($"{leftPlayerPoints} | {rightPlayerPoints}");
                                if (rightPlayerPoints == 3)
                                {
                                    goto outer;
                                }
                            }
                        }

                        if (ballX == fieldLength - 2)
                        {
                            
                            if (ballY >= rightRacketHeight + 1 && ballY <= rightRacketHeight + racketLength)
                            {
                                isBallGoingRight = !isBallGoingRight;
                            }
                            else 
                            {
                                leftPlayerPoints++;
                                ballY = fieldWidth / 2;
                                ballX = fieldLength / 2;
                                Console.SetCursorPosition(scoreboardX, scoreboardY);
                                Console.WriteLine($"{leftPlayerPoints} | {rightPlayerPoints}");
                                if (leftPlayerPoints == 3)
                                {
                                    goto outer;
                                }

                            }
                        }

                    } while (!Console.KeyAvailable)
                    {

                    }

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (rightRacketHeight > 0)
                            {
                                rightRacketHeight--;
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            if (rightRacketHeight < fieldWidth - racketLength - 1)
                            {
                                rightRacketHeight++;
                            }
                            break;

                        case ConsoleKey.W:
                            if (leftRacketHeight > 0)
                            {
                                leftRacketHeight--;
                            }
                            break;

                        case ConsoleKey.S:
                            if (leftRacketHeight < fieldWidth - racketLength - 1)
                            {
                                leftRacketHeight++;
                            }
                            break;
                    }

                    for (int i = 1; i < fieldWidth; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine(" ");
                        Console.SetCursorPosition(fieldLength - 1, i);
                        Console.WriteLine(" ");
                    }

                }

            outer:;
                Console.Clear();
                Console.SetCursorPosition(0, 0);

                if (rightPlayerPoints == 3)
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("You lost to a bot? Boo! No more game for you >:(");
                }

                if (rightPlayerPoints == 3)
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


    

