

namespace MathGameConsole.Models
{
    internal class GameEngine
    {
        internal void AdditionGame()
        {
            Console.WriteLine("Additiion game selected");
            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helper.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Cooorrecct!! Press enter for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("WRONG WRONG WRONG Press enter and get it right this time");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($" GAME OOOVERRRR  Your final score is....{score}!!! Press [ENTER] to return to menu");
                    Console.ReadLine();
                }
            }

            Helper.AddToHistory(score, GameType.Addition);


        }
        internal void SubtractionGame()
        {
            Console.WriteLine("Subtraction game selected");
            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helper.ValidateResult(result);


                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Cooorrecct!! Press enter for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("WRONG WRONG WRONG Press enter and get it right this time");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($" GAME OOOVERRRR  Your final score is....{score}!!! Press [ENTER] to return to menu");
                    Console.ReadLine();
                }
            }

            Helper.AddToHistory(score, GameType.Subtraction);

        }
        internal void MultiplicationGame()
        {
            Console.WriteLine("Multiplication game selected");
            var random = new Random();
            int score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} x {secondNumber}");
                var result = Console.ReadLine();

                result = Helper.ValidateResult(result);


                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Cooorrecct!! Press enter for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("WRONG WRONG WRONG Press enter and get it right this time");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($" GAME OOOVERRRR  Your final score is....{score}!!! Press [ENTER] to return to menu");
                    Console.ReadLine();
                }
            }

            Helper.AddToHistory(score, GameType.Multiplication);

        }
        internal void DivisionGame()
        {
            Console.WriteLine("Division game selected");
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                var divisionNumbers = Helper.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helper.ValidateResult(result);


                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Cooorrecct!! Press enter for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("WRONG WRONG WRONG Press enter and get it right this time");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($" GAME OOOVERRRR  Your final score is....{score}!!! Press [ENTER] to return to menu");
                    Console.ReadLine();
                }
            }

            Helper.AddToHistory(score, GameType.Division);

        }

    }
}
