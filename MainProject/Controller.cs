using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class Controller
    {
        Dictionary<int, Action<string[]>> ProgramNumber = new Dictionary<int, Action<string[]>>
        {
            { 1, new Action<string[]>(NumberSequenceApp.Program.Main) },
            { 2, new Action<string[]>(LuckyTicketsApp.Program.Main) },
            { 3, new Action<string[]>(DecodingNumberApp.Program.Main) }
            
        };
        public void Run(string[] args)
        {
            bool check = false;
            do
            {
                new View().ViewMenu();
                string answer = Console.ReadLine();
                bool answerIsValid = int.TryParse(answer, out int programNumber);
                if (!answerIsValid || (programNumber < 1 || programNumber > 3))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Data entered incorrectly. \nSelect from 1 to 3 or press any key to exit the program.");
                    check = RetryMessage();
                }
                else
                {
                    Console.Clear();
                    ProgramNumber[programNumber].Invoke(args);
                    Console.Clear();
                    check = true;
                }
            } while (check);
            Console.WriteLine("\nPress any key to close the main program.");
            Console.ReadLine();
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
                Console.Clear();
            }
            return check;
        }
    }
}
