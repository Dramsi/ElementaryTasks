using System;

namespace NumberSequenceApp
{
    class Controller
    {
        
        
        public void Run()
        {
            View view = new View();
            bool check;
            do
            {
                try
                {
                    Calculation calculation = new Calculation();
                    NumberSequence numberSequence = view.SetInputData();
                    view.GetResults(calculation.TranslationToString(calculation.CalculationSequence(numberSequence)));
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
