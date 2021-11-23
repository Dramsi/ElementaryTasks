using System;

namespace NumberSequenceApp
{
    public class View
    {
        public NumberSequence SetArg()
        {
            int lengthArray = SetLengthArray();
            double squareNumber = SetSquareNumber();
            return new NumberSequence(lengthArray, squareNumber);
        }
        public int SetLengthArray()
        {
            int lengthArray;
            bool check;
            do
            {
                Console.WriteLine("Enter the length of the row:");
                lengthArray = Convert.ToInt32(Console.ReadLine());
                if (lengthArray <= 0 || lengthArray > 10000)
                {
                    Console.WriteLine("The value must be no less than 1 and no more than 10000.\nTry again, please.");
                    check = RetryMessage();
                }
                else
                    check = false;
            } while (check);
            return lengthArray;
        }
        public double SetSquareNumber()
        {
            double squareNumber;
            bool check;
            do
            {
                Console.WriteLine("Enter the value of the minimum square:");
                squareNumber = Convert.ToDouble(Console.ReadLine());
                if (squareNumber < 0)
                {
                    Console.WriteLine("The value must be no less than 0.\nTry again, please.");
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
            return controller.ConversionToString(controller.Calculations(SetArg()));
        }
        public bool RetryMessage()
        {
            bool check;
            Console.WriteLine("If you want to repeat, enter «Y» or «y».");
            string answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
                check = true;
            else
                check = false;
            return check;
        }
    }
}
