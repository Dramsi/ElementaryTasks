using System;

namespace NumberSequenceApp
{
    public class Controller
    {
        public int[] Calculations(NumberSequence numberSequence)
        {
            int minNumber = Convert.ToInt32(Math.Ceiling(Math.Sqrt(numberSequence.SquareNumber)));
            int[] numbers = new int[numberSequence.LengthArray];
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = Convert.ToInt32(minNumber++);
            }
            return numbers;
        }
        public string TranslationToString(int[] numbers)
        {
            return "Results: " + String.Join(" ", numbers);
        }
        public void Run()
        {
            bool check = true;
            View view = new View();
            do
            {
                Console.WriteLine(view.GetResults());
                check = view.RetryMessage();
            } while (check);
            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadLine();
        }
    }
}
