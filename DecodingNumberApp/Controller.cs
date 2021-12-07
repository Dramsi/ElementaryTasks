using System;

namespace DecodingNumberApp
{
    class Controller
    {
        public void Run()
        {
            bool check;
            do
            {
                View view = new View();
                object objectNumber = view.SetLongNumber();
                if (objectNumber != null)
                {
                    view.GetStringNumber(new Calculation().ConvertAllNumbers((ulong)objectNumber));
                }
                check = view.RetryMessage();
            } while (check);
            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadLine();
        }
    }
}
