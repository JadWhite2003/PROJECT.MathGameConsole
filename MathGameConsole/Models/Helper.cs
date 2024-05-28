
using System.Runtime.CompilerServices;

namespace MathGameConsole.Models
{
    internal static class Helper
    {
        internal static List<Game> games = new List<Game>();
        internal static void GetGames()
        {

            Console.Clear();
            Console.WriteLine("Game history");
            Console.WriteLine("--------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} / 5");
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();


        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(0, 99);
            var secondNumber = random.Next(0, 99);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(0, 99);
                secondNumber = random.Next(0, 99);

            }
            result[0] = firstNumber;
            result[1] = secondNumber;


            return result;

        }

        internal static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType

            });

        }

        internal static string? ValidateResult( string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be a number... its math. Try again.");
                result = Console.ReadLine();

            }
            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name)) 
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();
            
            }

            return name;
        }
    }
}
