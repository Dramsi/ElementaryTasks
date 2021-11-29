using System;

namespace NumberSequenceApp
{
    public class View
    {
        private NumberSequence SetArg()
        {
            int lengthArray = SetLengthArray();
            double squareNumber = SetSquareNumber();
            return new NumberSequence(lengthArray, squareNumber);
        }
        private int SetLengthArray()
        {
            int lengthArray;
            bool check;
            do
            {
                Console.WriteLine("Enter the length of the row:");
                lengthArray = Convert.ToInt32(Console.ReadLine());
                if (lengthArray <= 0 || lengthArray > 10000)
                {
                    Console.WriteLine("The value must be no less than 1 and no more than 10000.");
                    check = RetryMessage();
                }
                else
                    check = false;
            } while (check);
            return lengthArray;
        }
        private double SetSquareNumber()
        {
            double squareNumber;
            bool check;
            do
            {
                Console.WriteLine("Enter the value of the minimum square:");
                squareNumber = Convert.ToDouble(Console.ReadLine());
                if (squareNumber < 0)
                {
                    Console.WriteLine("The value must be no less than 0.");
                    check = RetryMessage();
                }
                else
                    check = false;
            } while (check);
            return squareNumber;
        }
        public string GetResults()
        {
            Controller controller = new Controller();
            bool check = true;
            string result;
            do
            {
                try
                {
                    result = controller.TranslationToString(controller.Calculations(SetArg()));
                    return result;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Value was either too large.");
                    check = RetryMessage();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string was not in a correct format.");
                    check = RetryMessage();
                }
            } while (check);
            return null;
        }
        public bool RetryMessage()
        {
            bool check;
            Console.WriteLine("If you want to repeat, enter «Y» or «y».");
            string answer = Console.ReadLine();
            if (String.Equals(answer, "y", StringComparison.OrdinalIgnoreCase))
                check = true;
            else
                check = false;
            return check;
        }
    }
}
