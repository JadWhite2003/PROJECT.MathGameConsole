
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

       internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            
            });

        }
    }
}
