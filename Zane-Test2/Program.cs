

using System.ComponentModel.Design;
using HomeAgain;

namespace HomeAgain
//
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }
        public static Player currentPlayer = new Player();
        public static void Start()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"──────▄▀▄─────▄▀▄\r\n─────▄█░░▀▀▀▀▀░░█▄\r\n─▄▄──█░░░░░░░░░░░█──▄▄\r\n█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█\r\n");
            Console.WriteLine($"\r\n██╗░░██╗░█████╗░███╗░░░███╗███████╗  ░█████╗░░██████╗░░█████╗░██╗███╗░░██╗\r\n██║░░██║██╔══██╗████╗░████║██╔════╝  ██╔══██╗██╔════╝░██╔══██╗██║████╗░██║\r\n███████║██║░░██║██╔████╔██║█████╗░░  ███████║██║░░██╗░███████║██║██╔██╗██║\r\n██╔══██║██║░░██║██║╚██╔╝██║██╔══╝░░  ██╔══██║██║░░╚██╗██╔══██║██║██║╚████║\r\n██║░░██║╚█████╔╝██║░╚═╝░██║███████╗  ██║░░██║╚██████╔╝██║░░██║██║██║░╚███║\r\n╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚══════╝  ╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝");
            Console.WriteLine("");
            Console.WriteLine("Before we start, what's your name?");
            Console.Write("> ");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();

            if (currentPlayer.name == "")
                Console.WriteLine("What, forgot your name?");
            else
                Console.WriteLine("Good, lets begin " + currentPlayer.name + "!");



            Console.WriteLine("You've got about 10 minuets of freetime.");

            Console.WriteLine("You can 1) Guess what treat im baking, 2) count the dust bunnies or 3) play pong!");

            Console.WriteLine("What do you want to do? (input the number of your choice)");



            //Get userchoice 

            Console.Write("> ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Game1 game1 = new Game1();
                    game1.Run();
                    break;
                case "2":
                    Game2 game2 = new Game2();
                    game2.Run();
                    break;
                case "3":
                    Game3 game3 = new Game3();
                    game3.Run();
                    break;
                case "4":
                    Game4 game4 = new Game4();
                    game4.Run();
                    break;

            }

        }
        public static void Run()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"──────▄▀▄─────▄▀▄\r\n─────▄█░░▀▀▀▀▀░░█▄\r\n─▄▄──█░░░░░░░░░░░█──▄▄\r\n█▄▄█─█░░▀░░┬░░▀░░█─█▄▄█\r\n");
            Console.WriteLine($"\r\n██╗░░██╗░█████╗░███╗░░░███╗███████╗  ░█████╗░░██████╗░░█████╗░██╗███╗░░██╗\r\n██║░░██║██╔══██╗████╗░████║██╔════╝  ██╔══██╗██╔════╝░██╔══██╗██║████╗░██║\r\n███████║██║░░██║██╔████╔██║█████╗░░  ███████║██║░░██╗░███████║██║██╔██╗██║\r\n██╔══██║██║░░██║██║╚██╔╝██║██╔══╝░░  ██╔══██║██║░░╚██╗██╔══██║██║██║╚████║\r\n██║░░██║╚█████╔╝██║░╚═╝░██║███████╗  ██║░░██║╚██████╔╝██║░░██║██║██║░╚███║\r\n╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝╚══════╝  ╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝");
            Console.WriteLine("Welcome back " + currentPlayer.name);

            Console.WriteLine("You've got about 10 minuets of freetime.");

            Console.WriteLine("You can 1) Guess what treat im baking, 2) count the dust bunnies or 3) play pong!");

            Console.WriteLine("What do you want to do? (input the number of your choice)");



            //Get userchoice 

            Console.Write("> ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Game1 game1 = new Game1();
                    game1.Run();
                    break;
                case "2":
                    Game2 game2 = new Game2();
                    game2.Run();
                    break;
                case "3":
                    Game3 game3 = new Game3();
                    game3.Run();
                    break;

            }
        }





    }
}

