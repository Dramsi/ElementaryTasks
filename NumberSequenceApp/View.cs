using System;

namespace NumberSequenceApp
{
    class View
    {
        public NumberSequence SetInputData() 
        {
            bool check;
            do
            {
                try
                {
                    check = false;
                    int lengthArray = SetLengthArray();
                    double squareNumber = SetSquareNumber();
                    return new NumberSequence(lengthArray, squareNumber);

                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Value was either too large.");
                    check = RetryMessage();
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Input string was not in a correct format.");
                    check = RetryMessage();
                }
            } while (check);
            return null;
        }
        private int SetLengthArray()
        {
            int lengthArray;
            bool check;
            do
            {
                check = false;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter the length of the row:");
                Console.ForegroundColor = ConsoleColor.White;
                lengthArray = Convert.ToInt32(Console.ReadLine());
                if (lengthArray <= 0 || lengthArray > 10000)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("The value must be no less than 1 and no more than 10000.");
                    check = RetryMessage();
                }
            } while (check);
            return lengthArray;
        }
        private double SetSquareNumber()
        {
            double squareNumber;
            bool check;
            do
            {
                check = false;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Enter the value of the minimum square:");
                Console.ForegroundColor = ConsoleColor.White;
                squareNumber = Convert.ToDouble(Console.ReadLine());
                if (squareNumber < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("The value must be no less than 0.");
                    check = RetryMessage();
                }
            } while (check);
            return squareNumber;
        }
        public void GetResults(string results)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(results);

        }
        public bool RetryMessage()
        {
            bool check = false;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("If you want to repeat, enter «Y» or «y».");
            Console.ForegroundColor = ConsoleColor.White;
            string answer = Console.ReadLine();
            if (String.Equals(answer, "y", StringComparison.OrdinalIgnoreCase))
            {
                check = true;
            }
            return check;
        }
    }
}
