using System;

namespace LuckyTicketsApp
{
    public class Calculation
    {
        public int CountLuckyTicketsTheEasyWay(LuckyTickets luckyTickets)
        {
            int numberLuckyTickets = 0;
            for (int ticket = luckyTickets.MinTiсketValue; ticket <= luckyTickets.MaxTiсketValue; ticket++)
            {
                string ticketInFormat = ticket.ToString(luckyTickets.format);
                if ((ticketInFormat[0] + ticketInFormat[1] + ticketInFormat[2]) == (ticketInFormat[3] + ticketInFormat[4] + ticketInFormat[5]))
                {
                    numberLuckyTickets++;
                }
            }
            return numberLuckyTickets;
        }
        public int CountLuckyTicketsTheDifficulWay(LuckyTickets luckyTickets)
        {
            int numberLuckyTickets = 0;
            for (int ticket = luckyTickets.MinTiсketValue; ticket <= luckyTickets.MaxTiсketValue; ticket++)
            {
                string ticketInFormat = ticket.ToString(luckyTickets.format);
                int evenDigits = 0, oddDigits = 0;
                for (int number = 0; number < ticketInFormat.Length; number++)
                {
                    if (ticketInFormat[number] % 2 == 0)
                    {
                        evenDigits += Convert.ToInt32(char.GetNumericValue(ticketInFormat[number]));
                    }
                    else
                    {
                        oddDigits += Convert.ToInt32(char.GetNumericValue(ticketInFormat[number]));
                    }
                }
                if (evenDigits == oddDigits)
                {
                    numberLuckyTickets++;
                }
            }
            return numberLuckyTickets;
        }
    }
}
