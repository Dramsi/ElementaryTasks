using System;
using System.Collections.Generic;
using System.Text;

namespace DecodingNumberApp
{
    class View
    {
        public int SetIntNumber()
        {
            int number;
            bool check;
            do
            {
                Console.WriteLine("Enter the number:");
                number = Convert.ToInt32(Console.ReadLine());
                if (number <= 0 || number > 999)
                {
                    Console.WriteLine("The value must be no less than 1 and no more than 10000.");
                    check = RetryMessage();
                }
                else
                    check = false;
            } while (check);
            return number;
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
