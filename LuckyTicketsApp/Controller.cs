using System;

namespace LuckyTicketsApp
{
    class Controller
    {
        public void Run()
        {
            bool check;
            do
            {
                check = false;
                View view = new View();
                LuckyTickets luckyTickets = view.SetInputData();
                if (luckyTickets != null)
                {
                    Calculation calculation = new Calculation();
                    view.GetComparisonResults(calculation.CountLuckyTicketsTheEasyWay(luckyTickets), calculation.CountLuckyTicketsTheDifficulWay(luckyTickets));
                    check = view.RetryMessage();
                }
            } while (check);
            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadLine();
        }
    }
}
