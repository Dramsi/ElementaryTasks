using System;

namespace NumberSequenceApp
{
    class Controller
    {
        private int[] Calculations(NumberSequence numberSequence)
        {
            int minNumber = Convert.ToInt32(Math.Ceiling(Math.Sqrt(numberSequence.SquareNumber)));
            int[] numbers = new int[numberSequence.LengthArray];
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = Convert.ToInt32(minNumber++);
            }
            return numbers;
        }
        private string TranslationToString(int[] numbers)
        {
            return "Results: " + String.Join(" ", numbers);
        }
        public void Run()
        {
            View view = new View();
            bool check;
            do
            {
                try
                {
                    view.GetResults(TranslationToString(Calculations(view.SetArg())));
                    check = view.RetryMessage();
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Value was either too large.");
                    check = view.RetryMessage();
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Input string was not in a correct format.");
                    check = view.RetryMessage();
                }
            } while (check);
            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadLine();
        }
    }
}
