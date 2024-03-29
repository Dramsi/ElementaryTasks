﻿using System;

namespace LuckyTicketsApp
{
    class View
    {
        public LuckyTickets SetInputData()
        {
            bool check;
            do
            {
                LuckyTickets luckyTickets = new LuckyTickets(SetValue("minimum"), SetValue("maximum"));
                if (verificationEmptyInput(luckyTickets) == null)
                {
                    return null;
                }
                if (luckyTickets.MinTiсketValue > luckyTickets.MaxTiсketValue)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("The minimum value cannot be greater than the maximum!");
                    check = RetryMessage();
                }
                else
                {
                    check = false;
                    return luckyTickets;
                }
            } while (check);
            return null;
        }
        private int SetValue(string valueName)
        {
            bool check;
            do
            {
                try
                {
                    check = false;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Enter {valueName} ticket value:");
                    Console.ForegroundColor = ConsoleColor.White;
                    string ticketValue = Console.ReadLine();
                    if (Convert.ToInt32(ticketValue) < 0 || Convert.ToInt32(ticketValue) > 999999 || ticketValue.Length != 6)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("The value must be no less than 000000 and no more than 999999.");
                        check = RetryMessage();
                    }
                    else
                    {
                        return Convert.ToInt32(ticketValue);
                    }
                }
                catch (FormatException)
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
            return -1;                                                                                              
        }
        private LuckyTickets verificationEmptyInput(LuckyTickets luckyTickets)                                      
        {
            if (luckyTickets.MinTiсketValue == -1 || luckyTickets.MaxTiсketValue == -1)
            {
                return null;
            }
            return luckyTickets;
        }
        public void GetComparisonResults(int numberOfLuckyTicketsEasyWay, int numberOfLuckyTicketsDifficultWay)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Number of lucky tickets counted in an easy way: {numberOfLuckyTicketsEasyWay}" +
                $"\nNumber of lucky tickets counted in a difficult way: {numberOfLuckyTicketsDifficultWay}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (numberOfLuckyTicketsEasyWay > numberOfLuckyTicketsDifficultWay)
            {
                Console.WriteLine("The easy way won!");
            }
            else
            {
                if (numberOfLuckyTicketsEasyWay < numberOfLuckyTicketsDifficultWay)
                {
                    Console.WriteLine("The difficult way won!");
                }
                else
                {
                    Console.WriteLine("Both methods are equal!");
                }
            }
        }
        public bool RetryMessage()
        {
            bool check = false;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("If you want to repeat, enter «Y» or «y».");
            Console.ForegroundColor = ConsoleColor.White;
            string answer = Console.ReadLine();
            if (String.Equals(answer, "y", StringComparison.OrdinalIgnoreCase))
            {
                check = true;
            }
            return check;
        }
    }
}
