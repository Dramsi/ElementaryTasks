using System;

namespace DecodingNumberApp
{
    class View
    {
        public ulong? SetLongNumber()
        {
            ulong? number;
            bool check;
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enter the number:");
                    Console.ForegroundColor = ConsoleColor.White;
                    number = Convert.ToUInt64(Console.ReadLine());
                    check = false;
                    return (ulong)number;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"The value must be no less than {ulong.MinValue} and no more than {ulong.MaxValue}.");
                    check = RetryMessage();
                }
                catch(FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("The value must be whole numbers.");
                    check = RetryMessage();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(e.Message);
                    check = RetryMessage();
                }
            } while (check);
            return null;
        }
        public void GetStringNumber(string number)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(number);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public bool RetryMessage()
        {
            bool check;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("If you want to repeat, enter «Y» or «y».");
            Console.ForegroundColor = ConsoleColor.White;
            string answer = Console.ReadLine();
            if (String.Equals(answer, "y", StringComparison.OrdinalIgnoreCase))
                check = true;
            else
                check = false;
            return check;
        }
    }
}
