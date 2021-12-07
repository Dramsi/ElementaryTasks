using System;

namespace NumberSequenceApp
{
    public class Calculation
    {
        public int[] CalculationSequence(NumberSequence numberSequence)
        {
            if (numberSequence != null)
            {
                int minNumber = Convert.ToInt32(Math.Ceiling(Math.Sqrt(numberSequence.SquareNumber)));
                int[] numbers = new int[numberSequence.LengthArray];
                for (int i = 0; i <= numbers.Length - 1; i++)
                {
                    numbers[i] = Convert.ToInt32(minNumber++);
                }
                return numbers;
            }
            return null;
        }
        public string TranslationToString(int[] numbers)
        {
            if (numbers != null)
            {
                return "Results: " + String.Join(" ", numbers);
            }
            return null;
        }
    }
}
