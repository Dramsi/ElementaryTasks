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
                View view = new View();
                LuckyTickets luckyTickets = view.SetInputData();
                if (luckyTickets != null)
                {
                    view.GetComparisonResults(CountLuckyTicketsTheEasyWay(luckyTickets), CountLuckyTicketsTheDifficulWay(luckyTickets));
                    check = view.RetryMessage();
                }
                else
                    check = false;
            } while (check);
            Console.WriteLine("\nPress any key to close the program.");
            Console.ReadLine();
        }
        private int CountLuckyTicketsTheEasyWay(LuckyTickets luckyTickets)
        {
            int numberLuckyTickets = 0;
            for (int ticket = luckyTickets.MinTiketValue; ticket <= luckyTickets.MaxTiketValue; ticket++)
            {
                string ticketInFormat = ticket.ToString(luckyTickets.format);
                if ((ticketInFormat[0] + ticketInFormat[1] + ticketInFormat[2]) == (ticketInFormat[3] + ticketInFormat[4] + ticketInFormat[5]))
                    numberLuckyTickets++;
            }
            return numberLuckyTickets;
        }
        private int CountLuckyTicketsTheDifficulWay(LuckyTickets luckyTickets)
        {
            int numberLuckyTickets = 0;
            for (int ticket = luckyTickets.MinTiketValue; ticket <= luckyTickets.MaxTiketValue; ticket++)
            {
                string ticketInFormat = ticket.ToString(luckyTickets.format);
                int evenDigits = 0, oddDigits = 0;
                for (int number = 0; number < ticketInFormat.Length; number++)
                {
                    if (ticketInFormat[number] % 2 == 0)
                        evenDigits += Convert.ToInt32(char.GetNumericValue(ticketInFormat[number]));
                    else
                        oddDigits += Convert.ToInt32(char.GetNumericValue(ticketInFormat[number]));
                }
                if (evenDigits == oddDigits)
                    numberLuckyTickets++;
            }
            return numberLuckyTickets;
        }
    }
}
