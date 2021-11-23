using System;

namespace NumberSequenceApp
{
    public class Controller
    {
        public int[] Calculations(NumberSequence numberSequence)
        {
            int minNumber = Convert.ToInt32(Math.Ceiling(Math.Sqrt(numberSequence.squareNumber)));
            int[] numbers = new int[numberSequence.lengthArray];
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = Convert.ToInt32(minNumber++);
            }
            return numbers;
        }
        public string ConversionToString(int[] numbers)
        {
            string resultString = "Results: ";
            foreach (int i in numbers)
            {
                resultString += i + " ";
            }
            return resultString;
        }
        public void Run()
        {
            bool check = true;
            View view = new View();
            do
            {
                try
                {
                    Console.WriteLine(view.GetResults());
                    check = view.RetryMessage();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    check = view.RetryMessage();
                }
            } while (check);
            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadLine();
        }
    }
}
