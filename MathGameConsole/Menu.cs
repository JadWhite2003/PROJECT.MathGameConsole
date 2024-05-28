
namespace MathGameConsole
{
    internal class Menu
    {
        GameEngine gameEngine = new();
      internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine($"Hello, {name.ToUpper()} the time is {date.TimeOfDay} Get ready to be MATHED!!!");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"Choose from the following below to be MATHED
        V - View previous games
        A - Addition
        S - Substraction
        M - Multication
        D - Division
        Q - Leave the realm of math?");
                Console.WriteLine("______________________________________________________________");
                var gameSeleted = Console.ReadLine();

                switch (gameSeleted.Trim().ToLower())
                {
                    case "v":
                        Helper.GetGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame();
                        break;
                    case "s":
                        gameEngine.SubtractionGame();
                        break;
                    case "m":
                        gameEngine.MultiplicationGame();
                        break;
                    case "d":
                        gameEngine.DivisionGame();
                        break;
                    case "q":
                        Console.WriteLine("No MATH today I guess?");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                };

            } while (isGameOn);
        }
    }
}
