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
                try
                {
                    Console.WriteLine("Enter the number:");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number < 0 || number > 2147483647)
                    {
                        Console.WriteLine("The value must be no less than 0 and no more than 2147483647.");
                        check = RetryMessage();
                    }
                    else
                    {
                        check = false;
                        return number;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    check = RetryMessage();
                }
            } while (check);
            return -1;
        }
        public void GetStringNumber(string number)
        {
            Console.WriteLine(number);
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
