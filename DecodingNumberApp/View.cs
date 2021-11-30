using System;
using System.Collections.Generic;
using System.Text;

namespace DecodingNumberApp
{
    class View
    {
        public ulong SetLongNumber()
        {
            ulong number;
            bool check;
            do
            {
                try
                {
                    Console.WriteLine("Enter the number:");
                    number = Convert.ToUInt64(Console.ReadLine());
                    if (number < 0 || number > 18446744073709551615)
                    {
                        Console.WriteLine("The value must be no less than 0 and no more than 18446744073709551615.");
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
            return 0;
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
